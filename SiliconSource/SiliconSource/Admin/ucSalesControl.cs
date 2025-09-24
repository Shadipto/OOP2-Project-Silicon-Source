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
    public partial class ucSalesControl : UserControl
    {
        public ucSalesControl()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (gdvSales.DataSource == null) return;

            DataTable dt = gdvSales.DataSource as DataTable;
            if (dt == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(searchValue))
            {
                (gdvSales.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                dt.DefaultView.RowFilter = $"Convert(SaleID, 'System.String') LIKE '%{searchValue}%'";
            }
        }
    }
}
