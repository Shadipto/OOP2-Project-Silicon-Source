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
    public partial class ucCart : UserControl
    {
        public ucCart()
        {
            InitializeComponent();
            //this.lblAmount.Text = "TK " + Product.GetGrandTotalString(CartSession.CartItems.ToList());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gdvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var row = gdvCart.SelectedRows[0];
            string productId = row.Cells["productID"].Value.ToString();

            
            Product productToRemove = null;
            foreach (Product p in CartSession.CartItems)
            {
                if (p.ProductID == productId)
                {
                    productToRemove = p;
                    break; 
                }
            }
            // Remove totally
            if (productToRemove != null)
            {
                CartSession.CartItems.Remove(productToRemove);
            }
            UpdateGrandTotal();
        }

        private void cbtnMinus_Click(object sender, EventArgs e)
        {
            if (gdvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = gdvCart.SelectedRows[0];
            string productId = row.Cells["productID"].Value.ToString();

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
                if (existing.Quantity > 1)
                {
                    existing.Quantity -= 1; // decrease quantity

                    int rowIndex = row.Index;
                    gdvCart.InvalidateRow(rowIndex);
                }
                else
                {
                    CartSession.CartItems.Remove(existing); 
                }
            }
            UpdateGrandTotal();
        }

        private void cbtnPlus_Click(object sender, EventArgs e)
        {
            if (gdvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to increment.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var row = gdvCart.SelectedRows[0];
            string productId = row.Cells["productID"].Value.ToString();

            
            Product productToIncrement = null;
            foreach (Product p in CartSession.CartItems)
            {
                if (p.ProductID == productId)
                {
                    productToIncrement = p;
                    break; 
                }
            }

            // Increment
            if (productToIncrement != null)
            {
                productToIncrement.Quantity += 1;
                
                int rowIndex = row.Index;
                gdvCart.InvalidateRow(rowIndex);

            }
            UpdateGrandTotal();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (CartSession.CartItems.Count == 0)
            {
                MessageBox.Show("Cart is already empty.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear all products
            CartSession.CartItems.Clear();

            MessageBox.Show("All products have been removed from the cart.", "Cart Cleared",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateGrandTotal();
        }

        // Refresh
        public void UpdateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (Product p in CartSession.CartItems)
            {
                grandTotal += p.Total; 
            }

            lblAmount.Text = "TK " + grandTotal.ToString(); 
        }




        /*
        public void RefreshCart()
        {
            MessageBox.Show($"Cart count: {CartSession.CartItems.Count}");
            foreach (var item in CartSession.CartItems)
            {
                MessageBox.Show($"{item.ProductID} | {item.ProductName} | {item.Quantity}");
            }
            this.gdvCart.AutoGenerateColumns = true;
            this.gdvCart.DataSource = CartSession.CartItems;
        }
        private void ucCart_Load(object sender, EventArgs e)
        {
            this.gdvCart.AutoGenerateColumns = true;
            this.gdvCart.DataSource = CartSession.CartItems;
        }

        private void ucCart_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) 
                 this.RefreshCart();
        }
        

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CartSession.CartItems.Add(new Product("TEST-001", "Test Product", "TestCat", 99.99m, 1));
            //RefreshCart();

        }*/

    }
}
