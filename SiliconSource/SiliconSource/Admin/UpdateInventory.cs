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
        internal int ProductID {  get; set; }
        internal int SupplierID {  get; set; }
        DataAccess da;
        public UpdateInventory(int productID)
        {
            InitializeComponent();
            this.ProductID = productID;
            this.da = new DataAccess();

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
            DataTable dstUpdate = da.ExecuteQueryTable(productToUpdate);

            ucProductName.TextboxText = dstUpdate.Rows[0][0].ToString();
            cmbCategory.Text = dstUpdate.Rows[0][1].ToString();
            ucDescription.TextboxText = dstUpdate.Rows[0][2].ToString();
            ucPrice.TextboxText = dstUpdate.Rows[0][3].ToString();
            ucCost.TextboxText = dstUpdate.Rows[0][4].ToString();
            ucStockQuantity.TextboxText = dstUpdate.Rows[0][5].ToString();
            ucSKU.TextboxText = dstUpdate.Rows[0][6].ToString();
            this.SupplierID = int.Parse(dstUpdate.Rows[0][7].ToString());

            string queryToFindSuppilerName = $"SELECT [SupplierName] FROM [dbo].[Supplier] WHERE [SupplierID] = {this.SupplierID};";
            DataTable dstSup = da.ExecuteQueryTable(queryToFindSuppilerName);

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

            int didItWork = da.ExecuteDMLQuery(insertQuary);
            MessageBox.Show(didItWork.ToString());
        }
    }
}
