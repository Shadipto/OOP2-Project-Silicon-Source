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
    public partial class ucEmployeeControlManager : UserControl
    {
        public ucEmployeeControlManager()
        {
            InitializeComponent();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PDFExporter exporter = new PDFExporter("EmployeeReport.pdf");
            exporter.Export(gdvEmployee);
        }
    }
}
