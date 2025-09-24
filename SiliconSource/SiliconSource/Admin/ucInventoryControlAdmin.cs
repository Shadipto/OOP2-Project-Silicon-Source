using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource
{
    public partial class ucInventoryControlAdmin : UserControl
    {
        // DataAccess instance
        private DataAccess Da { set; get; }

        private Form AdminDashboardForm { get; set; }
        

        public ucInventoryControlAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void gdvInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdvInventory.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(gdvInventory.SelectedRows.Count > 0)
            {
                int productID = int.Parse(gdvInventory.SelectedRows[0].Cells["ProductID"].Value?.ToString());

                // admin dashboard form
                Form parentForm = this.FindForm();

                // Only create one updateInventory instance
                var updateInventory = new UpdateInventory(productID, ParentForm);
                parentForm.Hide();
                updateInventory.Show();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gdvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                                                  "Are you sure you want to delete this product?", 
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question
                                                 );

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                int productID = int.Parse(gdvInventory.SelectedRows[0].Cells["ProductID"].Value?.ToString());

                // Check if product exists in SaleItem
                string checkQuery = $"SELECT COUNT(*) FROM SaleItem WHERE ProductID = {productID};";
                int referenceCount = 0;
                using (SqlCommand cmd = new SqlCommand(checkQuery, Da.Sqlcon))
                {
                    var output = cmd.ExecuteScalar();
                    if (output != null && output != DBNull.Value)
                        referenceCount = Convert.ToInt32(output);
                }

                if (referenceCount > 0)
                {
                    // Seting stock to 0 as it is foreign key in SaleItem
                    string updateStockQuery = $"UPDATE Product SET StockQuantity = 0 WHERE ProductID = {productID};";
                    Da.ExecuteDMLQuery(updateStockQuery);
                    MessageBox.Show("Product is associated with existing sales. Stock quantity set to 0 instead of deletion.", "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Can delete the product
                    
                    string deleteSqlQuery = $"DELETE FROM Product WHERE ProductID = {productID};";
                    int affectedRows = Da.ExecuteDMLQuery(deleteSqlQuery);

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            AdminDashboardForm = this.FindForm();
            if (AdminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshInventoryTab();
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PDFExporter exporter = new PDFExporter("InventoryReport.pdf");
            exporter.Export(gdvInventory);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // admin dashboard form
            Form parentForm = this.FindForm();

            // Only create one updateInventory instance
            var addInventory = new AddInventory(parentForm);
            parentForm.Hide();
            addInventory.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (gdvInventory.DataSource == null) return;

            DataTable dt = gdvInventory.DataSource as DataTable;
            if (dt == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''"); 

            if (string.IsNullOrEmpty(searchValue))
            {
                (gdvInventory.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                dt.DefaultView.RowFilter = $"ProductName LIKE '%{searchValue}%'";
            }
        }
    }
}
