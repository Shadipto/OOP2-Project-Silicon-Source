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
            string passwordHash = this.GenerateSHA256Hash(ucLoginPassword.TextboxText);
            string query = $"SELECT [Role] FROM [dbo].[AppUser] WHERE [UserID] = '{userID}' AND [PasswordHash]  = '{passwordHash}' ;"; 
            var dst = da.ExecuteQueryTable(query);
            if (dst.Rows.Count == 1)
            {
                if (dst.Rows[0][0].ToString() == "Owner")
                {
                    this.Hide();
                    MessageBox.Show("Login Successful");
                    var adminDashboard = new AdminDashboard(this);
                    adminDashboard.Show();
                   

                    
                }
                else if (dst.Rows[0][0].ToString() == "Manager")
                {
                    this.Hide();
                    MessageBox.Show("Manager");
                    var managerDashboard = new ManagerDashboard();
                    managerDashboard.Show();
                }
                else if (dst.Rows[0][0].ToString() == "SalesRepresentative")
                {
                    this.Hide();
                    MessageBox.Show("SalesRepresentative");
                    var employeeDashboard = new EmployeeDashboard(this);
                    employeeDashboard.Show();

                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Error");
                    this.Close();
                }
                    
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }

            
        }

        private string GenerateSHA256Hash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
