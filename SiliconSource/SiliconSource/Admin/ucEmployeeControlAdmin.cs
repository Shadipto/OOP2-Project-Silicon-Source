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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gdvInventory.SelectedRows.Count > 0)
            {
                string userID = gdvInventory.SelectedRows[0].Cells["employeeID"].Value?.ToString();


                this.Hide();
                var updateEmployee = new UpdateEmployee(userID);
                updateEmployee.Show();

            }
        }
    }
}
