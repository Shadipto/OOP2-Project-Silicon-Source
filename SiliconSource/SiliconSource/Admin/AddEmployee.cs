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
            //var roleCodes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    {"Admin" , "OWN" },
            //    {"Manager" , "MGR" },
            //    {"SalesRepresentative" , "SRP" }
            //};

            
            string userID = this.GetID();
            

            string firstName = ucFirstName.TextboxText;

            string lastName = ucLastName.TextboxText;

            string userName = ucUserName.TextboxText;

            string password = PasswordHasher.GenerateSHA256Hash(ucPassword.TextboxText);

            string role = cmbRole.Text;
            
            double salary = double.Parse(ucSalary.TextboxText);

            string insertQuery = $"INSERT INTO AppUser (UserID, FirstName, LastName, UserName, PasswordHash, Role, Salary)" + $"VALUES ('{userID}', '{firstName}', '{lastName}', '{userName}', '<{password}>', '{role}', {salary});";

            int didItWork = Da.ExecuteDMLQuery(insertQuery);
            if (didItWork > 0)
            {
                MessageBox.Show("Update Successful" + " New ID: " + userID);
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
            AdminDashboardForm.Show();

            if (AdminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshEmployeeTab();
            }
        }
    }
}
