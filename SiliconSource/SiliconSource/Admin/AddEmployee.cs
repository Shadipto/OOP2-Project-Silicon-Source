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
    public partial class AddEmployee : Form
    {
        private Form AdminDashboardForm { get; set; } // Reference to the calling UserControl
        private DataAccess Da { set; get; }

        public AddEmployee(Form adminDashboardForm)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AdminDashboardForm = adminDashboardForm;
        }


        internal string GetID()
        {
            string quaryToGetLastID = "SELECT COUNT([UserID]) FROM [dbo].[AppUser];";
            DataTable dt = this.Da.ExecuteQueryTable(quaryToGetLastID);
            int lastID = int.Parse(dt.Rows[0][0].ToString());

            var roleCodes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"Admin" , "OWN" },
                {"Manager" , "MGR" },
                {"SalesRepresentative" , "SRP" }
            };

            string roleToAddTheSuffix = roleCodes[cmbRole.Text];
            return roleToAddTheSuffix + "-" + (++lastID).ToString("D3");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(ucFirstName.TextboxText) ||
                    string.IsNullOrWhiteSpace(ucLastName.TextboxText) ||
                    string.IsNullOrWhiteSpace(ucUserName.TextboxText) ||
                    string.IsNullOrWhiteSpace(ucPassword.TextboxText) ||
                    string.IsNullOrWhiteSpace(cmbRole.Text) ||
                    string.IsNullOrWhiteSpace(ucSalary.TextboxText))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(ucSalary.TextboxText, out double salary))
                {
                    MessageBox.Show("Please enter a valid numeric salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string userID = this.GetID();
                string passwordHash = PasswordHasher.GenerateSHA256Hash(ucPassword.TextboxText);

                string insertQuery = $"INSERT INTO AppUser (UserID, FirstName, LastName, UserName, PasswordHash, Role, Salary) " +
                                     $"VALUES ('{userID}', '{ucFirstName.TextboxText}', '{ucLastName.TextboxText}', '{ucUserName.TextboxText}', '{passwordHash}', '{cmbRole.Text}', {salary});";

                int rowsAffected = Da.ExecuteDMLQuery(insertQuery);
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Employee added successfully! New ID: {userID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            ucFirstName.TextboxText = string.Empty;
            ucLastName.TextboxText = string.Empty;
            ucUserName.TextboxText = string.Empty;
            ucPassword.TextboxText = string.Empty;
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
    }
}
