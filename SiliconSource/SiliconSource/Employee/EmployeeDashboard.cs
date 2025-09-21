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
    public partial class EmployeeDashboard : Form
    {
        private Form loginForm; // loninForm reference (association) [Dipto]

        // UserControl references (aggregation) [Dipto]
        private ucInventoryControlEmployee inventory;
        private ucCart cart;


        public EmployeeDashboard(Form loginform)
        {
            InitializeComponent();
            rbtnInventory.Checked = true;

            this.loginForm = loginform; // Assign the loginForm for keeping single login instance [Dipto]

            InitializeUserControls(); // Initialize UserControls (aggregation) [Dipto]

            rbtnInventory.CheckedChanged += RadioButton_CheckedChanged;
            rbtnCart.CheckedChanged += RadioButton_CheckedChanged;

        }

        private void InitializeUserControls()
        {
            this.inventory = new ucInventoryControlEmployee { Dock = DockStyle.Fill };
            this.cart = new ucCart { Dock = DockStyle.Fill };
            


            pnlGrid.Controls.Add(inventory);
            pnlGrid.Controls.Add(cart);
            


            inventory.Visible = true;   // default 
            cart.Visible = false;
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inventory.Visible = rbtnInventory.Checked;
            cart.Visible = rbtnCart.Checked;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
