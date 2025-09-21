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


        public AdminDashboard(Form loginForm, string adminName) // loginForm parameter (association) [Dipto]
        {
            
            InitializeComponent(); // default [Dipto]
            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]
            lblAdminName.Text = adminName; // Set admin name label [Dipto]
            rbtnInventory.Checked = true; // default [Dipto]

            this.loginForm = loginForm; // Assign the loginForm for keeping single login instance [Dipto]

            this.Da = new DataAccess();
            
            this.PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;","Inventory");


            rbtnInventory.CheckedChanged += RadioButton_CheckedChanged;
            rbtnEmployee.CheckedChanged += RadioButton_CheckedChanged;
            rbtnSales.CheckedChanged += RadioButton_CheckedChanged;
            rbtnAnalytics.CheckedChanged += RadioButton_CheckedChanged;

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
                case "Employee":
                    employee.gdvInventory.AutoGenerateColumns = false;
                    employee.gdvInventory.Columns["employeeID"].DataPropertyName = "EmployeeID";
                    employee.gdvInventory.Columns["employeeName"].DataPropertyName = "EmployeeName";
                    employee.gdvInventory.Columns["role"].DataPropertyName = "Role";
                    employee.gdvInventory.Columns["salary"].DataPropertyName = "Salary";
                    employee.gdvInventory.DataSource = ds.Tables[0];
                    break;
                case "Sales":
                    sales.gdvSales.AutoGenerateColumns = false;
                    sales.gdvSales.Columns["saleId"].DataPropertyName = "SaleID";
                    sales.gdvSales.Columns["saleDate"].DataPropertyName = "SaleDate";
                    sales.gdvSales.Columns["saleItems"].DataPropertyName = "SaleItems";
                    sales.gdvSales.Columns["bill"].DataPropertyName = "Bill";
                    sales.gdvSales.Columns["salesRep"].DataPropertyName = "SalesRep";
                    sales.gdvSales.DataSource = ds.Tables[0];
                    break;
                case "Analytics":
                    analytics.gdvSalesAnalytics.AutoGenerateColumns = false;
                    analytics.gdvSalesAnalytics.Columns["salesRepID"].DataPropertyName = "SalesRepID";
                    analytics.gdvSalesAnalytics.Columns["salesRepName"].DataPropertyName = "SalesRepName";
                    analytics.gdvSalesAnalytics.Columns["totalSalesCount"].DataPropertyName = "TotalSalesCount";
                    analytics.gdvSalesAnalytics.Columns["totalSales"].DataPropertyName = "TotalSales";
                    analytics.gdvSalesAnalytics.Columns["productsSold"].DataPropertyName = "SalesDetails";
                    analytics.gdvSalesAnalytics.DataSource = ds.Tables[0];
                    break;
            }
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

            if (rbtnInventory.Checked)
                PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;", "Inventory");
            else if (rbtnEmployee.Checked)
                PopulateGridView("SELECT UserID AS EmployeeID, FirstName || ' ' || LastName AS EmployeeName, Role, Salary FROM AppUser;", "Employee");
            else if (rbtnSales.Checked)
                PopulateGridView("SELECT S.SaleID, S.SaleDate, COUNT(SI.SaleItemID) AS SaleItems, S.TotalAmount AS Bill, CONCAT(AU.FirstName, ' ', AU.LastName) AS SalesRep FROM Sale AS S JOIN SaleItem AS SI ON S.SaleID = SI.SaleID JOIN AppUser AS AU ON S.SalesRepresentativeID = AU.UserID GROUP BY S.SaleID, S.SaleDate, S.TotalAmount, AU.FirstName, AU.LastName;", "Sales");
            else if (rbtnAnalytics.Checked)
                PopulateGridView("SELECT AU.UserID AS SalesRepID, CONCAT(AU.FirstName, ' ', AU.LastName) AS SalesRepName, COUNT(S.SaleID) AS TotalSalesCount, SUM(S.TotalAmount) AS TotalSales, ( SELECT STRING_AGG(P.ProductName, ', ') FROM SaleItem AS SI INNER JOIN Product AS P ON SI.ProductID = P.ProductID WHERE SI.SaleID IN ( SELECT SaleID FROM Sale WHERE SalesRepresentativeID = AU.UserID ) ) AS ProductsSold FROM AppUser AS AU INNER JOIN Sale AS S ON AU.UserID = S.SalesRepresentativeID GROUP BY AU.UserID, AU.FirstName, AU.LastName ORDER BY TotalSales DESC;", "Analytics");
        
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
