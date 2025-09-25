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

        private Form LoginForm { get; set; } // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucInventoryControlEmployee inventory;
        private ucCart cart;


        public EmployeeDashboard(Form loginForm, string employeeName)
        {
            InitializeComponent();

            lblName.Text = employeeName;
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


            if (rbtnHome.Checked)
            {
                this.lblTitle.Text = rbtnHome.Text;
                
            }
            else if (rbtnInventory.Checked)
            {
                this.lblTitle.Text = rbtnInventory.Text;
                PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;", "Inventory");
            }
            else if (rbtnCart.Checked)
            {
                this.lblTitle.Text = rbtnCart.Text;
                PopulateCartGridView();
                this.cart.UpdateGrandTotal();

            }
            else if (rbtnRecord.Checked)
            {
                this.lblTitle.Text = rbtnRecord.Text;
                PopulateGridView("SELECT AU.UserID AS SalesRepID, CONCAT(AU.FirstName, ' ', AU.LastName) AS SalesRepName, COUNT(S.SaleID) AS TotalSalesCount, SUM(S.TotalAmount) AS TotalSales, ( SELECT STRING_AGG(P.ProductName, ', ') FROM SaleItem AS SI INNER JOIN Product AS P ON SI.ProductID = P.ProductID WHERE SI.SaleID IN ( SELECT SaleID FROM Sale WHERE SalesRepresentativeID = AU.UserID ) ) AS ProductsSold FROM AppUser AS AU INNER JOIN Sale AS S ON AU.UserID = S.SalesRepresentativeID GROUP BY AU.UserID, AU.FirstName, AU.LastName ORDER BY TotalSales DESC;", "Analytics");
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
    }
}
