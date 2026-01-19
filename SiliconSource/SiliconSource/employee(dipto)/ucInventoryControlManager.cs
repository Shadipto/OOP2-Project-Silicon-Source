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
    public partial class ucInventoryControlManager : UserControl
    {
        public ucInventoryControlManager()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (gdvInventory.DataSource == null) return;

                DataTable dt = gdvInventory.DataSource as DataTable;
                if (dt == null) return;

                string searchValue = txtSearch.Text.Trim().Replace("'", "''");

                if (string.IsNullOrEmpty(searchValue))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    // Filter ProductName safely
                    dt.DefaultView.RowFilter = $"ProductName LIKE '%{searchValue}%'";
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
            PDFExporter exporter = new PDFExporter("InventoryReport.pdf");
            exporter.Export(gdvInventory);
        }
    }
}
