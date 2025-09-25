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
    public partial class EmployeeDashboard : Form
    {
        private DataAccess Da { get; set; }
        internal string EmployeeId { get; set; }

        private Form LoginForm { get; set; } // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucInventoryControlEmployee inventory;
        private ucCart cart;

        public EmployeeDashboard(Form loginForm, string employeeName, string employeeId)
        {
            InitializeComponent();

            lblName.Text = employeeName;
            EmployeeId = employeeId;
            rbtnInventory.Checked = true;

            this.LoginForm = loginForm; // Assign the loginForm for keeping single login instance [Dipto]

            this.Da = new DataAccess(); // Assign the loginForm for keeping single login instance [Dipto]

            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]

            this.PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;", "Inventory");

            rbtnInventory.CheckedChanged += RadioButton_CheckedChanged;
            rbtnCart.CheckedChanged += RadioButton_CheckedChanged;
        }

        // Method to fill DataGridView from DB [Dipto]
        internal void PopulateGridView(string query, string controlType)
        {
            var ds = this.Da.GetDataSet(query);

            switch (controlType)
            {
                
                case "Inventory":
                    inventory.gdvInventory.AutoGenerateColumns = false;
                    inventory.gdvInventory.Columns["productID"].DataPropertyName = "ProductID";
                    inventory.gdvInventory.Columns["productName"].DataPropertyName = "ProductName";
                    inventory.gdvInventory.Columns["category"].DataPropertyName = "Category";
                    inventory.gdvInventory.Columns["price"].DataPropertyName = "Price";
                    inventory.gdvInventory.Columns["cost"].DataPropertyName = "Cost";
                    inventory.gdvInventory.Columns["stock"].DataPropertyName = "StockQuantity";
                    inventory.gdvInventory.DataSource = ds.Tables[0];
                    break;

            }
        }

        internal void PopulateCartGridView()
        {
            cart.gdvCart.AutoGenerateColumns = false;
            cart.gdvCart.Columns["productID"].DataPropertyName = "productId";      
            cart.gdvCart.Columns["productName"].DataPropertyName = "productName";
            cart.gdvCart.Columns["price"].DataPropertyName = "price";
            cart.gdvCart.Columns["quantity"].DataPropertyName = "quantity";
            cart.gdvCart.Columns["total"].DataPropertyName = "Total";
            cart.gdvCart.DataSource = null;
            cart.gdvCart.DataSource = CartSession.CartItems;
            
        }

        private void InitializeUserControls()
        {
            this.inventory = new ucInventoryControlEmployee { Dock = DockStyle.Fill };
            this.cart = new ucCart { Dock = DockStyle.Fill };
            


            pnlGrid.Controls.Add(inventory);
            pnlGrid.Controls.Add(cart);
            

            inventory.Visible = true;   // default 
            cart.Visible = false;
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inventory.Visible = rbtnInventory.Checked;
            cart.Visible = rbtnCart.Checked;


            if (rbtnInventory.Checked)
            {
                this.lblTitle.Text = rbtnInventory.Text;
                PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;", "Inventory");
            }
            else if (rbtnCart.Checked)
            {
                this.cart.EmployeeId = this.EmployeeId;
                this.lblTitle.Text = rbtnCart.Text;
                PopulateCartGridView();
                this.cart.UpdateGrandTotal();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Show();
        }

        public void RefreshCart()
        {
            rbtnCart.Checked = false;
            rbtnCart.Checked = true;
        }
    }
}
