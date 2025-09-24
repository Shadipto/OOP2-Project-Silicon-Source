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
            //this.VisibleChanged += ucCart_VisibleChanged;

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
