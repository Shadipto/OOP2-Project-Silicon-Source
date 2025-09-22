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
    public partial class AddInventory : Form
    {
        private Form AdminDashboardForm { get; set; } // Reference to the calling UserControl
        
        private DataAccess Da { set; get; }

        public AddInventory(Form adminDashboardForm)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AdminDashboardForm = adminDashboardForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string productName = ucProductName.TextboxText;

            string category = cmbCategory.Text;

            string description = ucDescription.TextboxText;

            double price = double.Parse(ucPrice.TextboxText);

            double cost = double.Parse(ucCost.TextboxText);

            int stockQuantity = int.Parse(ucStockQuantity.TextboxText);

            string SKU = ucSKU.TextboxText;

            string supplierName = cmbSupplierName.Text;

            string queryToFindSuppilerID = $"SELECT [SupplierID] FROM [dbo].[Supplier] WHERE [SupplierName] = '{supplierName}';";


            DataTable dst = Da.ExecuteQueryTable(queryToFindSuppilerID);

            int supplierID = Convert.ToInt32(dst.Rows[0][0]);

            string insertQuery = "INSERT INTO Product (ProductName, Category, Description, Price, Cost, StockQuantity, SKU, SupplierID)" +
                $"VALUES ('{productName}', '{category}', '{description}', {price}, {cost}, {stockQuantity}, '{SKU}', {supplierID});";

            int didItWork = Da.ExecuteDMLQuery(insertQuery);
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboardForm.Show();

            if (AdminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshInventoryTab();
            }
        }
    }
}
