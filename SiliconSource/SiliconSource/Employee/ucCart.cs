using iTextSharp.text;
using iTextSharp.text.pdf;
using SiliconSource.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource
{
    public partial class ucCart : UserControl
    {
        private DataAccess Da { set; get; }

        private Form EmployeeDashboardForm { get; set; }

        internal string EmployeeId { get; set; }

        internal decimal GrandTotal { get; set; }


        public ucCart()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            

            Form parentForm = this.FindForm();
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvCart.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product to remove.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = gdvCart.SelectedRows[0];
                string productId = row.Cells["productID"].Value?.ToString();

                if (string.IsNullOrEmpty(productId)) return;

                Product productToRemove = CartSession.CartItems.FirstOrDefault(p => p.ProductID == productId);

                if (productToRemove != null)
                    CartSession.CartItems.Remove(productToRemove);

                UpdateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            UpdateGrandTotal();
        }









        private void cbtnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvCart.SelectedRows.Count == 0) return;

                var row = gdvCart.SelectedRows[0];
                string productId = row.Cells["productID"].Value?.ToString();
                if (string.IsNullOrEmpty(productId)) return;

                Product existing = CartSession.CartItems.FirstOrDefault(p => p.ProductID == productId);

                if (existing != null)
                {
                    if (existing.Quantity > 1)
                    {
                        existing.Quantity--;
                        gdvCart.InvalidateRow(row.Index);
                    }
                    else
                    {
                        CartSession.CartItems.Remove(existing);
                    }
                }
                UpdateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while decreasing the quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateGrandTotal();
        }






        private void cbtnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvCart.SelectedRows.Count == 0) return;

                var row = gdvCart.SelectedRows[0];
                string productId = row.Cells["productID"].Value?.ToString();
                if (string.IsNullOrEmpty(productId)) return;

                Product productToIncrement = CartSession.CartItems.FirstOrDefault(p => p.ProductID == productId);

                if (productToIncrement != null)
                {
                    if (productToIncrement.Quantity < productToIncrement.Stock)
                    {
                        productToIncrement.Quantity++;
                        gdvCart.InvalidateRow(row.Index);
                    }
                    else
                    {
                        MessageBox.Show("Cannot add more. Stock limit reached.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                UpdateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while increasing the quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateGrandTotal();
        }





        private void btnClearCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (CartSession.CartItems.Count == 0)
                {
                    MessageBox.Show("Cart is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CartSession.CartItems.Clear();
                MessageBox.Show("All products have been removed from the cart.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing the cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateGrandTotal();
        }





        // Refresh
        public void UpdateGrandTotal()
        {
            this.GrandTotal = 0;

            foreach (Product p in CartSession.CartItems)
            {
                this.GrandTotal += p.Total; 
            }

            lblAmount.Text = "TK " + this.GrandTotal.ToString(); 
        }





        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            

            if (CartSession.CartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            Form parentForm = this.FindForm();

            var customerDetails = new CustomerDetails(parentForm,this.EmployeeId, this.GrandTotal );
            parentForm.Hide();
            customerDetails.Show();

        }


    }
}
