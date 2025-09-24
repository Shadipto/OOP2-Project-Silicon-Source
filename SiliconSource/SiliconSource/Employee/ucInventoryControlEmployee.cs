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
            if (gdvInventory.SelectedRows.Count > 0)
            {
                var row = gdvInventory.SelectedRows[0];

                Product selectedProduct = new Product(
                row.Cells["productID"].Value.ToString(),
                row.Cells["productName"].Value.ToString(),
                row.Cells["category"].Value.ToString(),
                Convert.ToDecimal(row.Cells["price"].Value), 1);

                Product existing = null;
                foreach (Product p in CartSession.CartItems)
                {
                    if (p.ProductID == selectedProduct.ProductID)
                    {
                        existing = p;
                        break;
                    }
                }
                if (existing != null)
                {
                    existing.Quantity += 1;
                }
                else
                {
                    CartSession.CartItems.Add(selectedProduct);
                }

                MessageBox.Show("Product added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        
    }
    
}
