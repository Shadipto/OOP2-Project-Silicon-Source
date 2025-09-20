using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource.Employee
{
    public partial class AdminDashboard : Form
    {
        private Form loginForm; // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucInventoryControlAdmin inventory;
        private ucEmployeeControlAdmin employee;
        private ucSalesControl sales;
        private ucAnalyticsControl analytics;

        public AdminDashboard(Form loginForm) // loginForm parameter (association) [Dipto]
        {
            
            InitializeComponent();
            rbtnInventory.Checked = true; // default [Dipto]

            this.loginForm = loginForm; // Assign the loginForm for keeping single login instance [Dipto]


            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]

            


            rbtnInventory.CheckedChanged += RadioButton_CheckedChanged;
            rbtnEmployee.CheckedChanged += RadioButton_CheckedChanged;
            rbtnSales.CheckedChanged += RadioButton_CheckedChanged;
            rbtnAnalytics.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void InitializeUserControls()
        {
            inventory = new ucInventoryControlAdmin { Dock = DockStyle.Fill };
            employee = new ucEmployeeControlAdmin { Dock = DockStyle.Fill };
            sales = new ucSalesControl { Dock = DockStyle.Fill };
            analytics = new ucAnalyticsControl { Dock = DockStyle.Fill };

            
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
