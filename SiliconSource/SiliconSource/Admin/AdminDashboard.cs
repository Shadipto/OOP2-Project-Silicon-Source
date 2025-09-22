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


        private Form LoginForm { get; set; } // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucHomeAdmin homeAdmin;
        private ucInventoryControlAdmin inventory;
        private ucEmployeeControlAdmin employee;
        private ucSalesControl sales;
        private ucAnalyticsControl analytics;


        public AdminDashboard(Form loginForm, string adminName) // loginForm parameter (association) [Dipto]
        {
            
            InitializeComponent(); // default [Dipto]
            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]
            lblAdminName.Text = adminName; // Set admin name label [Dipto]
            rbtnHome.Checked = true; // default [Dipto]

            this.LoginForm = loginForm; // Assign the loginForm for keeping single login instance [Dipto]

            this.Da = new DataAccess();

            this.PopulateGridView("SELECT TOP 10 P.ProductName AS SoldRecently, SI.ProductID, SI.UnitPrice AS Price FROM SaleItem AS SI INNER JOIN Sale AS S ON SI.SaleID = S.SaleID INNER JOIN Product AS P ON SI.ProductID = P.ProductID ORDER BY S.SaleDate DESC; SELECT TOP 5 P.ProductName AS TopSelling, SUM(SI.Quantity) AS SoldQuantity FROM SaleItem AS SI INNER JOIN Product AS P ON SI.ProductID = P.ProductID GROUP BY P.ProductName ORDER BY SoldQuantity DESC; SELECT ProductName AS LowStockProducts, StockQuantity AS StockLeft FROM Product WHERE StockQuantity <= 10 ORDER BY StockQuantity ASC; SELECT TOP 1 CONCAT(AU.FirstName, ' ', AU.LastName) AS TopPerformer FROM AppUser AS AU INNER JOIN Sale AS S ON AU.UserID = S.SalesRepresentativeID GROUP BY AU.FirstName, AU.LastName ORDER BY SUM(S.TotalAmount) DESC;", "Home");

            rbtnHome.CheckedChanged += RadioButton_CheckedChanged;
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
                case "Home":
                    homeAdmin.dgvRecentSales.AutoGenerateColumns = false;
                    homeAdmin.dgvRecentSales.Columns["soldRecently"].DataPropertyName = "SoldRecently";
                    homeAdmin.dgvRecentSales.Columns["productID"].DataPropertyName = "ProductID";
                    homeAdmin.dgvRecentSales.Columns["price"].DataPropertyName = "Price";
                    homeAdmin.dgvRecentSales.DataSource = ds.Tables[0];

                    homeAdmin.dgvTopSelling.AutoGenerateColumns = false;
                    homeAdmin.dgvTopSelling.Columns["topSelling"].DataPropertyName = "TopSelling";
                    homeAdmin.dgvTopSelling.Columns["soldQuantity"].DataPropertyName = "SoldQuantity";
                    homeAdmin.dgvTopSelling.DataSource = ds.Tables[1];

                    homeAdmin.dgvLowStock.AutoGenerateColumns = false;
                    homeAdmin.dgvLowStock.Columns["lowStockProducts"].DataPropertyName = "LowStockProducts";
                    homeAdmin.dgvLowStock.Columns["stockLeft"].DataPropertyName = "StockLeft";
                    homeAdmin.dgvLowStock.DataSource = ds.Tables[2];

                    homeAdmin.dgvTopPerformer.AutoGenerateColumns = false;
                    homeAdmin.dgvTopPerformer.Columns["topPerformer"].DataPropertyName = "TopPerformer";
                    homeAdmin.dgvTopPerformer.DataSource = ds.Tables[3];
                    break;

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
            this.homeAdmin = new ucHomeAdmin { Dock = DockStyle.Fill };
            this.inventory = new ucInventoryControlAdmin { Dock = DockStyle.Fill };
            this.employee = new ucEmployeeControlAdmin { Dock = DockStyle.Fill };
            this.sales = new ucSalesControl { Dock = DockStyle.Fill };
            this.analytics = new ucAnalyticsControl { Dock = DockStyle.Fill };

            pnlGrid.Controls.Add(homeAdmin);
            pnlGrid.Controls.Add(inventory);
            pnlGrid.Controls.Add(employee);
            pnlGrid.Controls.Add(sales);
            pnlGrid.Controls.Add(analytics);

            
            homeAdmin.Visible = true;  // default
            inventory.Visible = false;   
            employee.Visible = false;
            sales.Visible = false;
            analytics.Visible = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            homeAdmin.Visible = rbtnHome.Checked;
            inventory.Visible = rbtnInventory.Checked;
            employee.Visible = rbtnEmployee.Checked;
            sales.Visible = rbtnSales.Checked;
            analytics.Visible = rbtnAnalytics.Checked;

            if (rbtnHome.Checked)
            {
                this.lblTitle.Text = rbtnHome.Text;
                PopulateGridView("SELECT TOP 10 P.ProductName AS SoldRecently, SI.ProductID, SI.UnitPrice AS Price FROM SaleItem AS SI INNER JOIN Sale AS S ON SI.SaleID = S.SaleID INNER JOIN Product AS P ON SI.ProductID = P.ProductID ORDER BY S.SaleDate DESC; SELECT TOP 5 P.ProductName AS TopSelling, SUM(SI.Quantity) AS SoldQuantity FROM SaleItem AS SI INNER JOIN Product AS P ON SI.ProductID = P.ProductID GROUP BY P.ProductName ORDER BY SoldQuantity DESC; SELECT ProductName AS LowStockProducts, StockQuantity AS StockLeft FROM Product WHERE StockQuantity <= 10 ORDER BY StockQuantity ASC; SELECT TOP 1 CONCAT(AU.FirstName, ' ', AU.LastName) AS TopPerformer FROM AppUser AS AU INNER JOIN Sale AS S ON AU.UserID = S.SalesRepresentativeID GROUP BY AU.FirstName, AU.LastName ORDER BY SUM(S.TotalAmount) DESC;", "Home");
            }
            else if (rbtnInventory.Checked)
            {
                this.lblTitle.Text = rbtnInventory.Text;
                PopulateGridView("SELECT ProductID, ProductName, Category, Price, Cost, StockQuantity FROM Product;", "Inventory");
            }
            else if (rbtnEmployee.Checked)
            {
                this.lblTitle.Text = rbtnEmployee.Text;
                PopulateGridView("SELECT UserID AS EmployeeID, FirstName || ' ' || LastName AS EmployeeName, Role, Salary FROM AppUser;", "Employee");
            }
            else if (rbtnSales.Checked)
            {
                this.lblTitle.Text = rbtnSales.Text;
                PopulateGridView("SELECT S.SaleID, S.SaleDate, COUNT(SI.SaleItemID) AS SaleItems, S.TotalAmount AS Bill, CONCAT(AU.FirstName, ' ', AU.LastName) AS SalesRep FROM Sale AS S JOIN SaleItem AS SI ON S.SaleID = SI.SaleID JOIN AppUser AS AU ON S.SalesRepresentativeID = AU.UserID GROUP BY S.SaleID, S.SaleDate, S.TotalAmount, AU.FirstName, AU.LastName;", "Sales");
            }
            else if (rbtnAnalytics.Checked)
            {
                this.lblTitle.Text = rbtnAnalytics.Text;
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

        internal void RefreshInventoryTab()
        {
            // Force trigger CheckedChanged
            rbtnInventory.Checked = false;
            rbtnInventory.Checked = true;
        }

        internal void RefreshHomeTab()
        {
            // Force trigger CheckedChanged
            rbtnHome.Checked = false;
            rbtnHome.Checked = true;
        }
    }
}
