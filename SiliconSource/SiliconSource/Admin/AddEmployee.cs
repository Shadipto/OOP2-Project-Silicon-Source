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
        private Form adminDashboardForm { get; set; } // Reference to the calling UserControl
        private DataAccess Da { set; get; }

        public AddEmployee(Form adminDashboardForm)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.adminDashboardForm = adminDashboardForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = ucFirstName.TextboxText;

            string lastName = ucLastName.TextboxText;

            string userName = ucUserName.TextboxText;

            string password = PasswordHasher.GenerateSHA256Hash(ucPassword.TextboxText);

            string role = cmbRole.Text;

            double salary = double.Parse(ucSalary.TextboxText);

            string insertQuery = $"INSERT INTO AppUser (UserID, FirstName, LastName, UserName, PasswordHash, Role, Salary)" + $"VALUES ('OWN-TAS', '{firstName}', '{lastName}', '{userName}', '<{password}>', '{role}', {salary});";

            int didItWork = Da.ExecuteDMLQuery(insertQuery);
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
            adminDashboardForm.Show();

            if (adminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshEmployeeTab();
            }
        }
    }
}
