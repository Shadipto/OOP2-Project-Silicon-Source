using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource.Manager
{
    public partial class ucSalesControlManager : UserControl
    {
        public ucSalesControlManager()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (gdvSales.DataSource == null) return;

                DataTable dt = gdvSales.DataSource as DataTable;
                if (dt == null) return;

                string searchValue = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

                if (string.IsNullOrEmpty(searchValue))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    // Case-insensitive search on SaleID
                    dt.DefaultView.RowFilter = $"Convert(SaleID, 'System.String') LIKE '%{searchValue}%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PDFExporter exporter = new PDFExporter("SalesReport.pdf");
            exporter.Export(gdvSales);
        }
    }
}
