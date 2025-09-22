using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource.Admin
{
    public partial class PasswordUpdate : Form
    {
        private string UserID { get; set; }
        private DataAccess Da { get; set; }

        private Form UpdateEmployeeForm { get; set; }

        public PasswordUpdate(Form updateEmployeeForm, string userID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.UpdateEmployeeForm = updateEmployeeForm;
            this.UserID = userID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newPassword = ucNewPassword.TextboxText;
            string confirmPassword = ucConfirmPassword.TextboxText;

            if (string.IsNullOrEmpty(newPassword) ) 
            {
                MessageBox.Show("Fields cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (newPassword == confirmPassword)
            {
                string passwordHash = PasswordHasher.GenerateSHA256Hash(newPassword);

                string updateQuery = $"UPDATE AppUser SET PasswordHash = '{passwordHash}' WHERE UserID = '{UserID}';";

                int rowsAffected = Da.ExecuteDMLQuery(updateQuery);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    UpdateEmployeeForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateEmployeeForm.Show();
        }
    }
}
