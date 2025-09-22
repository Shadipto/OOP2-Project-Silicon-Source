using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace SiliconSource
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var da = new DataAccess();
            string userID = ucLoginID.TextboxText;
            string passwordHash = PasswordHasher.GenerateSHA256Hash(ucLoginPassword.TextboxText);
            string query = $"SELECT [Role], [FirstName] FROM [dbo].[AppUser] WHERE [UserID] = '{userID}' AND [PasswordHash]  = '{passwordHash}' ;"; 
            var dst = da.ExecuteQueryTable(query);
            if (dst.Rows.Count == 1)
            {
                if (dst.Rows[0][0].ToString() == "Owner")
                {
                    this.Hide();
                    MessageBox.Show("Login Successfully!", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var adminDashboard = new AdminDashboard(this, dst.Rows[0][1].ToString());
                    adminDashboard.Show();
                }
                else if (dst.Rows[0][0].ToString() == "Manager")
                {
                    this.Hide();
                    MessageBox.Show("Manager", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var managerDashboard = new ManagerDashboard();
                    managerDashboard.Show();
                }
                else if (dst.Rows[0][0].ToString() == "SalesRepresentative")
                {
                    this.Hide();
                    MessageBox.Show("Sales Representative", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var employeeDashboard = new EmployeeDashboard(this);
                    employeeDashboard.Show();

                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Error", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                    
            }
            else
            {
                MessageBox.Show("Invalid Information", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
