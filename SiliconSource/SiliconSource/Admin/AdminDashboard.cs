using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace SiliconSource
{
    public partial class AdminDashboard : Form
    {
        private DataAccess Da { get; set; } // DataAccess reference (composition) [Dipto]


        private Form loginForm; // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucInventoryControlAdmin inventory;
        private ucEmployeeControlAdmin employee;
        private ucSalesControl sales;
        private ucAnalyticsControl analytics;


        public AdminDashboard(Form loginForm) // loginForm parameter (association) [Dipto]
        {
            
            InitializeComponent();
            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]
            rbtnInventory.Checked = true; // default [Dipto]

            this.loginForm = loginForm; // Assign the loginForm for keeping single login instance [Dipto]

            this.Da = new DataAccess();
            
            this.PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;");


            rbtnInventory.CheckedChanged += RadioButton_CheckedChanged;
            rbtnEmployee.CheckedChanged += RadioButton_CheckedChanged;
            rbtnSales.CheckedChanged += RadioButton_CheckedChanged;
            rbtnAnalytics.CheckedChanged += RadioButton_CheckedChanged;

        }

        // Method to fill DataGridView from DB [Dipto]
        internal void PopulateGridView(string query)
        {
            var ds = this.Da.GetDataSet(query);

            this.inventory.gdvInventory.AutoGenerateColumns = false;

            this.inventory.gdvInventory.Columns["productID"].DataPropertyName = "ProductID";
            this.inventory.gdvInventory.Columns["productName"].DataPropertyName = "ProductName";
            this.inventory.gdvInventory.Columns["category"].DataPropertyName = "Category";
            this.inventory.gdvInventory.Columns["price"].DataPropertyName = "Price";
            this.inventory.gdvInventory.Columns["cost"].DataPropertyName = "Cost";
            this.inventory.gdvInventory.Columns["stock"].DataPropertyName = "StockQuantity";

            this.inventory.gdvInventory.DataSource = ds.Tables[0];
        }


        // userControl initialization method (aggregation) [Dipto]
        private void InitializeUserControls()
        {
            this.inventory = new ucInventoryControlAdmin { Dock = DockStyle.Fill };
            this.employee = new ucEmployeeControlAdmin { Dock = DockStyle.Fill };
            this.sales = new ucSalesControl { Dock = DockStyle.Fill };
            this.analytics = new ucAnalyticsControl { Dock = DockStyle.Fill };

            
            pnlGrid.Controls.Add(inventory);
            pnlGrid.Controls.Add(employee);
            pnlGrid.Controls.Add(sales);
            pnlGrid.Controls.Add(analytics);

            
            inventory.Visible = true;   // default 
            employee.Visible = false;
            sales.Visible = false;
            analytics.Visible = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inventory.Visible = rbtnInventory.Checked;
            employee.Visible = rbtnEmployee.Checked;
            sales.Visible = rbtnSales.Checked;
            analytics.Visible = rbtnAnalytics.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
