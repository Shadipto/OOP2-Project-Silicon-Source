using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource
{
    public partial class ucEmployeeControlAdmin : UserControl
    {
        private DataAccess Da { get; set; }

        private Form AdminDashboardForm { get; set; }

        public ucEmployeeControlAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
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
            if (gdvEmployee.SelectedRows.Count > 0)
            {
                string userID = gdvEmployee.SelectedRows[0].Cells["employeeID"].Value?.ToString();

                Form parentForm = this.FindForm();

                this.ParentForm.Hide();
                var updateEmployee = new UpdateEmployee(userID, parentForm);
                updateEmployee.Show();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gdvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Employee.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                                                  "Are you sure you want to remove this user?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question
                                                 );

            if (result == DialogResult.No)
            {
                return;
            }

            else
            {
                
                var employeeID = gdvEmployee.SelectedRows[0].Cells["employeeID"].Value?.ToString();

                // Check if user exists in Sale
                string checkQuery = $"SELECT COUNT(*) FROM Sale WHERE SalesRepresentativeID = '{employeeID}';";
                var referenceCount = 0;
                using (SqlCommand cmd = new SqlCommand(checkQuery, Da.Sqlcon))
                {
                    var output = cmd.ExecuteScalar();
                    if (output != null && output != DBNull.Value)
                        referenceCount = Convert.ToInt32(output);
                }

                string checkQuery2 = $"SELECT COUNT(*) FROM Expense WHERE UserID = '{employeeID}';";
                int expenseCount = 0;
                using (SqlCommand cmd = new SqlCommand(checkQuery2, Da.Sqlcon))
                {
                    var output = cmd.ExecuteScalar();
                    if (output != null && output != DBNull.Value)
                        expenseCount = Convert.ToInt32(output);
                }

                if (referenceCount > 0 || expenseCount > 0)
                {
                    // Seting salary to 0 as it is foreign key in Sale
                    string updateSalary = $"UPDATE AppUser SET Salary = 0 WHERE UserID = '{employeeID}';";
                    Da.ExecuteDMLQuery(updateSalary);
                    MessageBox.Show("User is associated with existing sales. Salary quantity set to 0 instead of deletion.", "Salary Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Can delete the user

                    string deleteSqlQuery = $"DELETE FROM AppUser WHERE UserID = '{employeeID}';";
                    int affectedRows = Da.ExecuteDMLQuery(deleteSqlQuery);

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            AdminDashboardForm = this.FindForm();
            if (AdminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshEmployeeTab();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PDFExporter exporter = new PDFExporter("EmployeeReport.pdf");
            exporter.Export(gdvEmployee);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (gdvEmployee.DataSource == null) return;

            DataTable dt = gdvEmployee.DataSource as DataTable;
            if (dt == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(searchValue))
            {
                (gdvEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                dt.DefaultView.RowFilter = $"EmployeeName LIKE '%{searchValue}%'";
            }
        }
    }
}
