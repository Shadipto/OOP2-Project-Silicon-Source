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
            AdminDashboard adminDashboard = new AdminDashboard(this);
            EmployeeDashboard employeeDashboard = new EmployeeDashboard(this);
            adminDashboard.Show();
            //employeeDashboard.Show();
            this.Hide();

            // For testing purpose only [Dipto]
            string userID = ucLoginID.TextboxText;
            string password = ucLoginPassword.TextboxText;
            MessageBox.Show($"{userID}: {GenerateSHA256Hash(password)}");
        }

        private static string GenerateSHA256Hash(string password)
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
