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
            if (gdvInventory.DataSource == null) return;

            DataTable dt = gdvInventory.DataSource as DataTable;
            if (dt == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue))
            {
                (gdvInventory.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                dt.DefaultView.RowFilter = $"ProductName LIKE '%{searchValue}%'";
            }
        }
    }
}
