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
    public partial class ucEmployeeControlAdmin : UserControl
    {
        public ucEmployeeControlAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // admin dashboard form
            Form parentForm = this.FindForm();

            // Only create one updateInventory instance
            var addEmployee = new AddEmployee(parentForm);
            parentForm.Hide();
            addEmployee.Show();
        }
    }
}
