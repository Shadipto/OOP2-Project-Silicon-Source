using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource.Employee
{
    public partial class CustomerDetails : Form
    {
        private Form EmployeeDashboardForm { get; set; }
        private DataGridView gdvCart { get; set; }

        private DataAccess Da { get; set; }

        internal string EmployeeID { get; set; }

        internal int CustomerID { get; set; }
        internal decimal GrandTotalFromCart {  get; set; }
        

        public CustomerDetails(Form employeeDashboard,string employeeID, decimal grandTotal)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;
            this.EmployeeDashboardForm = employeeDashboard;
            this.gdvCart = gdvCart;
            this.Da = new DataAccess();
            this.GrandTotalFromCart = grandTotal;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            ucCustomerFirstName.TextboxText = string.Empty;
            ucCustomerLastName.TextboxText = string.Empty;
            ucCustomerEmail.TextboxText = string.Empty;
            ucPhoneNumber.TextboxText = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = ucCustomerFirstName.TextboxText.Trim();
                string lastName = ucCustomerLastName.TextboxText.Trim();
                string email = ucCustomerEmail.TextboxText.Trim();
                string phone = ucPhoneNumber.TextboxText.Trim();
                string paymentMethod = cmbPaymentMethod.Text;

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Please enter First Name and Last Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email 
                if (!string.IsNullOrWhiteSpace(email))
                {
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (!Regex.IsMatch(email, emailPattern))
                    {
                        MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // (digits only, 11-11 characters)
                if (!string.IsNullOrWhiteSpace(phone))
                {
                    string phonePattern = @"^\d{11,11}$";
                    if (!Regex.IsMatch(phone, phonePattern))
                    {
                        MessageBox.Show("Please enter a valid phone number (7-15 digits).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeDashboardForm.Show();

            if (EmployeeDashboardForm is EmployeeDashboard dashboard)
            {
                dashboard.RefreshCart();
            }
        }
    }
}
