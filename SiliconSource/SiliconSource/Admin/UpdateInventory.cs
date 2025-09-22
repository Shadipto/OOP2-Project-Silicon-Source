using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource
{
    public partial class UpdateInventory : Form
    {
        private Form AdminDashboardform { get; set; } // Reference to the calling UserControl
        private int ProductID {  get; set; }
        private int SupplierID {  get; set; }
        private DataAccess Da { set; get; }


        public UpdateInventory(int productID, Form adminDashboardForm)
        {
            InitializeComponent();
            this.ProductID = productID;
            this.AdminDashboardform = adminDashboardForm;
            this.Da = new DataAccess();

            string productToUpdate = $@"SELECT
                                           [ProductName]
                                          ,[Category]
                                          ,[Description]
                                          ,[Price]
                                          ,[Cost]
                                          ,[StockQuantity]
                                          ,[SKU]
                                          ,[SupplierID]
                                      FROM [dbo].[Product]
                                      WHERE [ProductID] = {ProductID};";

            DataTable dstUpdate = Da.ExecuteQueryTable(productToUpdate);

            ucProductName.TextboxText = dstUpdate.Rows[0][0].ToString();
            cmbCategory.Text = dstUpdate.Rows[0][1].ToString();
            ucDescription.TextboxText = dstUpdate.Rows[0][2].ToString();
            ucPrice.TextboxText = dstUpdate.Rows[0][3].ToString();
            ucCost.TextboxText = dstUpdate.Rows[0][4].ToString();
            ucStockQuantity.TextboxText = dstUpdate.Rows[0][5].ToString();
            ucSKU.TextboxText = dstUpdate.Rows[0][6].ToString();
            this.SupplierID = int.Parse(dstUpdate.Rows[0][7].ToString());

            string queryToFindSuppilerName = $"SELECT [SupplierName] FROM [dbo].[Supplier] WHERE [SupplierID] = {this.SupplierID};";
            DataTable dstSup = Da.ExecuteQueryTable(queryToFindSuppilerName);

            cmbSupplierName.Text = dstSup.Rows[0][0].ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            //string productToUpdate =    $@"SELECT
            //                              ,[ProductName]
            //                              ,[Category]
            //                              ,[Description]
            //                              ,[Price]
            //                              ,[Cost]
            //                              ,[StockQuantity]
            //                              ,[SKU]
            //                              ,[SupplierID]
            //                          FROM [dbo].[Product]
            //                          WHERE [ProductID] = {ProductID};";
            //DataTable dstUpdate = da.ExecuteQueryTable(productToUpdate);

            //ucProductName.TextboxText = dstUpdate.Rows[0][0].ToString();
            //cmbCategory.Text = dstUpdate.Rows[0][1].ToString();
            //ucDescription.TextboxText = dstUpdate.Rows[0][2].ToString();
            //ucPrice.TextboxText = dstUpdate.Rows[0][3].ToString();
            //ucCost.TextboxText = dstUpdate.Rows[0][4].ToString();
            //ucStockQuantity.TextboxText = dstUpdate.Rows[0][5].ToString();
            //ucSKU.TextboxText = dstUpdate.Rows[0][6].ToString();
            
            //int supplierID = int.Parse(dstUpdate.Rows[0][7].ToString());

            //string queryToFindSuppilerName = $"SELECT [SupplierName] FROM [dbo].[Supplier] WHERE [SupplierID] = '{supplierID}';";
            //DataTable dstSup = da.ExecuteQueryTable(queryToFindSuppilerName);

            //cmbSupplierName.Text = dstSup.Rows[0][0].ToString();

            string productName = ucProductName.TextboxText;
            string category = cmbCategory.Text;
            string description = ucDescription.TextboxText;
            double price = double.Parse(ucPrice.TextboxText);
            double cost = double.Parse(ucCost.TextboxText);
            int stockQuantity = int.Parse(ucStockQuantity.TextboxText);
            string SKU = ucSKU.TextboxText;

            string insertQuary = $@"UPDATE [dbo].[Product]
                                    SET 
                                        [ProductName] = '{productName}',
                                        [Category] = '{category}',
                                        [Description] = '{description}',
                                        [Price] = {price},
                                        [Cost] = {cost},
                                        [StockQuantity] = {stockQuantity},
                                        [SKU] = '{SKU}',
                                        [SupplierID] = {this.SupplierID}
                                    WHERE [ProductID] = {this.ProductID};
                                    ";

            int didItWork = Da.ExecuteDMLQuery(insertQuary);
            if (didItWork > 0)
            {
                MessageBox.Show("Update Successful");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

        }

        private void ClearForm()
        {
            ucProductName.TextboxText = string.Empty;
            cmbCategory.SelectedIndex = -1;  // clears selection
            ucDescription.TextboxText = string.Empty;
            ucPrice.TextboxText = string.Empty;
            ucCost.TextboxText = string.Empty;
            ucStockQuantity.TextboxText = string.Empty;
            ucSKU.TextboxText = string.Empty;
            cmbSupplierName.SelectedIndex = -1;  // clears supplier selection

            this.ProductID = 0;
            this.SupplierID = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboardform.Show();
            
            if (AdminDashboardform is AdminDashboard dashboard)
            {
                dashboard.RefreshInventoryTab();
            }
        }
    }
}
