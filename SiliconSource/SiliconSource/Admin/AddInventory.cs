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
        public AddInventory()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            
            
            
            string productName = ucProductName.TextboxText;
            string category = cmbCategory.Text;
            string description = ucDescription.TextboxText;
            double price = double.Parse(ucPrice.TextboxText);
            double cost = double.Parse(ucCost.TextboxText);
            int stockQuantity = int.Parse(ucStockQuantity.TextboxText);
            string SKU = ucSKU.TextboxText;
            string supplierName = cmbSupplierName.Text;
            string queryToFindSuppilerID = $"SELECT [SupplierID] FROM [dbo].[Supplier] WHERE [SupplierName] = '{supplierName}';";
            DataTable dst = da.ExecuteQueryTable(queryToFindSuppilerID);
            int supplierID = Convert.ToInt32(dst.Rows[0][0]);
            string insertQuary = "INSERT INTO Product (ProductName, Category, Description, Price, Cost, StockQuantity, SKU, SupplierID)" +
                $"VALUES ('{productName}', '{category}', '{description}', {price}, {cost}, {stockQuantity}, '{SKU}', {supplierID});";
            int didItWork = da.ExecuteDMLQuery(insertQuary);
            MessageBox.Show(didItWork.ToString() );
            
        }
    }
}
