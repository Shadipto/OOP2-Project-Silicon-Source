﻿using SiliconSource.Manager;
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
    public partial class ManagerDashboard : Form
    {
        private DataAccess Da { get; set; } // DataAccess reference (composition) [Dipto]


        private Form LoginForm { get; set; } // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucHomeManager homeManager;
        private ucEmployeeControlManager employee;
        private ucInventoryControlManager inventory;
        private ucSalesControlManager sales;
        private ucAnalyticsControl analytics; ///////////////////////////////////////////////////////////

        public ManagerDashboard(Form loginForm, string managerName)
        {
            InitializeComponent();
            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]
            lblName.Text = managerName; // Set admin name label [Dipto]
            rbtnHome.Checked = true; // default [Dipto]

            this.LoginForm = loginForm; // Assign the loginForm for keeping single login instance [Dipto]

            this.Da = new DataAccess();

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
                    homeManager.dgvRecentSales.AutoGenerateColumns = false;
                    homeManager.dgvRecentSales.Columns["soldRecently"].DataPropertyName = "SoldRecently";
                    homeManager.dgvRecentSales.Columns["productID"].DataPropertyName = "ProductID";
                    homeManager.dgvRecentSales.Columns["price"].DataPropertyName = "Price";
                    homeManager.dgvRecentSales.DataSource = ds.Tables[0];

                    homeManager.dgvTopSelling.AutoGenerateColumns = false;
                    homeManager.dgvTopSelling.Columns["topSelling"].DataPropertyName = "TopSelling";
                    homeManager.dgvTopSelling.Columns["soldQuantity"].DataPropertyName = "SoldQuantity";
                    homeManager.dgvTopSelling.DataSource = ds.Tables[1];

                    homeManager.dgvLowStock.AutoGenerateColumns = false;
                    homeManager.dgvLowStock.Columns["lowStockProducts"].DataPropertyName = "LowStockProducts";
                    homeManager.dgvLowStock.Columns["stockLeft"].DataPropertyName = "StockLeft";
                    homeManager.dgvLowStock.DataSource = ds.Tables[2];

                    homeManager.dgvTopPerformer.AutoGenerateColumns = false;
                    homeManager.dgvTopPerformer.Columns["topPerformer"].DataPropertyName = "TopPerformer";
                    homeManager.dgvTopPerformer.DataSource = ds.Tables[3];
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
                    employee.gdvEmployee.AutoGenerateColumns = false;
                    employee.gdvEmployee.Columns["employeeID"].DataPropertyName = "EmployeeID";
                    employee.gdvEmployee.Columns["employeeName"].DataPropertyName = "EmployeeName";
                    employee.gdvEmployee.Columns["role"].DataPropertyName = "Role";
                    employee.gdvEmployee.Columns["salary"].DataPropertyName = "Salary";
                    employee.gdvEmployee.DataSource = ds.Tables[0];
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
            this.homeManager = new ucHomeManager { Dock = DockStyle.Fill };
            this.inventory = new ucInventoryControlManager { Dock = DockStyle.Fill };
            this.employee = new ucEmployeeControlManager { Dock = DockStyle.Fill };
            this.sales = new ucSalesControlManager { Dock = DockStyle.Fill };
            this.analytics = new ucAnalyticsControl { Dock = DockStyle.Fill };

            pnlGrid.Controls.Add(homeManager);
            pnlGrid.Controls.Add(inventory);
            pnlGrid.Controls.Add(employee);
            pnlGrid.Controls.Add(sales);
            pnlGrid.Controls.Add(analytics);


            homeManager.Visible = true;  // default
            inventory.Visible = false;
            employee.Visible = false;
            sales.Visible = false;
            analytics.Visible = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            homeManager.Visible = rbtnHome.Checked;
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
                PopulateGridView("SELECT UserID AS EmployeeID, FirstName || ' ' || LastName AS EmployeeName, Role, Salary FROM AppUser WHERE Role != 'Owner';", "Employee");            }
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








        // Force trigger CheckedChanged
        internal void RefreshInventoryTab()
        {
            
            rbtnInventory.Checked = false;
            rbtnInventory.Checked = true;
        }

        internal void RefreshEmployeeTab()
        {
            
            rbtnEmployee.Checked = false;
            rbtnEmployee.Checked = true;
        }

        internal void RefreshHomeTab()
        {
            
            rbtnHome.Checked = false;
            rbtnHome.Checked = true;
        }

        internal void RefreshSalesTab()
        {
            
            rbtnSales.Checked = false;
            rbtnSales.Checked = true;
        }

        internal void RefreshAnalyticsTab()
        {
            
            rbtnAnalytics.Checked = false;
            rbtnAnalytics.Checked = true;
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
