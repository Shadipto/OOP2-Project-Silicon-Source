using Guna.UI2.WinForms.Suite;
using SiliconSource.Admin;
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
    public partial class UpdateEmployee : Form
    {
        private Form AdminDashboardForm { get; set; }
        private string UserID {  get; set; }
        private DataAccess Da { set; get; }

        public UpdateEmployee(string userID, Form adminDashboardForm)
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
            this.ucFirstName.TextboxText = dt.Rows[0][0].ToString();
            this.ucLastName.TextboxText = dt.Rows[0][1].ToString();
            this.ucUserName.TextboxText = dt.Rows[0][2].ToString();
            this.cmbRole.Text = dt.Rows[0][3].ToString();
            this.ucSalary.TextboxText = dt.Rows[0][4].ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = ucFirstName.TextboxText;

            string lastName = ucLastName.TextboxText;

            string userName = ucUserName.TextboxText;

            string role = cmbRole.Text;

            double salary = double.Parse(ucSalary.TextboxText);

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

        private void ClearForm()
        {
            ucFirstName.TextboxText = string.Empty;
            ucLastName.TextboxText = string.Empty;
            ucUserName.TextboxText = string.Empty;
            cmbRole.SelectedIndex = -1;  // clears selection
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

        
    }
}
