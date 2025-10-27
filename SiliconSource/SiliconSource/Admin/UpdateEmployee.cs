using Guna.UI2.WinForms.Suite;
using SiliconSource.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace SiliconSource
{
    public partial class UpdateEmployee : Form
    {
        private Form AdminDashboardForm { get; set; }
        private string UserID {  get; set; }
        private DataAccess Da { set; get; }

        public UpdateEmployee(string userID, Form adminDashboardForm)
        {
            try
            {
                InitializeComponent();
                Da = new DataAccess();
                this.UserID = userID;
                this.AdminDashboardForm = adminDashboardForm;

                string userToUpdate = $@"SELECT 
                                       [FirstName]
                                      ,[LastName]
                                      ,[UserName]
                                      ,[Role]
                                      ,[Salary]
                                  FROM [dbo].[AppUser]
                                  WHERE [UserID] = '{this.UserID}' ;";
                DataTable dt = Da.ExecuteQueryTable(userToUpdate);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No user found with the provided ID.");
                    return;
                }

                this.ucFirstName.TextboxText = dt.Rows[0][0].ToString();
                this.ucLastName.TextboxText = dt.Rows[0][1].ToString();
                this.ucUserName.TextboxText = dt.Rows[0][2].ToString();
                this.cmbRole.Text = dt.Rows[0][3].ToString();
                this.ucSalary.TextboxText = dt.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(ucFirstName.TextboxText))
                {
                    MessageBox.Show("First Name is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ucLastName.TextboxText))
                {
                    MessageBox.Show("Last Name is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ucUserName.TextboxText))
                {
                    MessageBox.Show("User Name is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbRole.Text))
                {
                    MessageBox.Show("Role must be selected.");
                    return;
                }

                if (!double.TryParse(ucSalary.TextboxText, out double salary))
                {
                    MessageBox.Show("Salary must be a valid number.");
                    return;
                }

                string firstName = ucFirstName.TextboxText;
                string lastName = ucLastName.TextboxText;
                string userName = ucUserName.TextboxText;
                string role = cmbRole.Text;

                string insertQuary = $@"UPDATE [dbo].[AppUser]
                                SET 
                                    [FirstName] = '{firstName}',
                                    [LastName] = '{lastName}',
                                    [UserName] = '{userName}',
                                    [Role] = '{role}',
                                    [Salary] = {salary}
                                WHERE [UserID] = '{this.UserID}'; ";

                int didItWork = Da.ExecuteDMLQuery(insertQuary);
                if (didItWork > 0)
                {
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            ucFirstName.TextboxText = string.Empty;
            ucLastName.TextboxText = string.Empty;
            ucUserName.TextboxText = string.Empty;
            cmbRole.SelectedIndex = -1;  
            ucSalary.TextboxText = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboardForm.Show();

            if (AdminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshEmployeeTab();
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            
            var passwordUpdate = new PasswordUpdate(this, this.UserID);
            this.Hide();
            passwordUpdate.Show();
        }

        private void ucSalary_Load(object sender, EventArgs e)
        {

        }
    }
}
