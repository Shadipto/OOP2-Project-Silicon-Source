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
    public partial class ucInventoryControlEmployee : UserControl
    {
        
        public ucInventoryControlEmployee()
        {
            InitializeComponent();
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (gdvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = gdvInventory.SelectedRows[0];
            string productId = row.Cells["productID"].Value.ToString();
            string productName = row.Cells["productName"].Value.ToString();
            string category = row.Cells["category"].Value.ToString();
            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
            int stock = Convert.ToInt32(row.Cells["stock"].Value);

            
            Product existing = null;
            foreach (Product p in CartSession.CartItems)
            {
                if (p.ProductID == productId)
                {
                    existing = p;
                    break;
                }
            }

            if (existing != null)
            {
                if (existing.Quantity < stock)
                {
                    existing.Quantity += 1;
                    MessageBox.Show("Quantity increased in cart", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot add more. Stock limit reached!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (stock > 0)
                {
                    Product selectedProduct = new Product(productId, productName, category, price, 1, stock);
                    CartSession.CartItems.Add(selectedProduct);
                    MessageBox.Show("Product added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
    
}
