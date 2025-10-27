using Guna.UI2.WinForms.Suite;
using System;
using System.Data;
using System.Text.RegularExpressions;
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

                    // (digits 11-11 characters)
                    if (!string.IsNullOrWhiteSpace(phone))
                    {
                        string phonePattern = @"^\d{11,11}$";
                        if (!Regex.IsMatch(phone, phonePattern))
                        {
                            MessageBox.Show("Please enter a valid phone number (11 digits).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                string query = $@"INSERT INTO Customer (FirstName, LastName, PhoneNumber, Email) VALUES ('{firstName}', '{lastName}', '{phone}', '{email}')";

                int rows = this.Da.ExecuteDMLQuery(query);

                if (rows > 0)
                {

                    MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    string quaryToFindCustomerID = $"SELECT [CustomerID] FROM [dbo].[Customer] WHERE [FirstName] = '{firstName}' AND [Email] = '{email}' ;";
                    DataTable dtci = Da.ExecuteQueryTable(quaryToFindCustomerID);

                    this.CustomerID = int.Parse(dtci.Rows[0][0].ToString());
                    string saleDateString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    string quaryToAddSale = $"INSERT INTO Sale (SaleDate, TotalAmount, PaymentMethod, SalesRepresentativeID, CustomerID) " +
                                            $"VALUES ('{saleDateString}', {this.GrandTotalFromCart}, '{paymentMethod}', '{this.EmployeeID}', {this.CustomerID});";

                    int didItWork = Da.ExecuteDMLQuery(quaryToAddSale);
                    if (didItWork > 0)
                    {
                        foreach (var item in CartSession.CartItems)
                        {
                            string insertQuary = $@"UPDATE [dbo].[Product]
                                    SET 
                                        [StockQuantity] = StockQuantity - {item.Quantity}
                                    WHERE 
                                        [ProductID] = {item.ProductID};
                                    ";
                            Da.ExecuteDMLQuery(insertQuary);

                        }
                        MessageBox.Show("Purchase Successful");
                        this.Hide();
                        EmployeeDashboardForm.Show();

                        if (EmployeeDashboardForm is EmployeeDashboard dashboard)
                        {
                            dashboard.RefreshCart();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                        this.Hide();
                        EmployeeDashboardForm.Show();

                        if (EmployeeDashboardForm is EmployeeDashboard dashboard)
                        {
                            dashboard.RefreshCart();
                        }

                    }


                    CartSession.CartItems.Clear();
                }
                else
                {
                    MessageBox.Show("Customer could not be saved. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    EmployeeDashboardForm.Show();

                    if (EmployeeDashboardForm is EmployeeDashboard dashboard)
                    {
                        dashboard.RefreshCart();
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
            this.Hide();
            EmployeeDashboardForm.Show();

            if (EmployeeDashboardForm is EmployeeDashboard dashboard)
            {
                dashboard.RefreshCart();
            }
        }
    }
}
