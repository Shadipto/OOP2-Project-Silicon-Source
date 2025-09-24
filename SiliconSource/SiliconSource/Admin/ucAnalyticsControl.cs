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
    public partial class ucAnalyticsControl : UserControl
    {
        public ucAnalyticsControl()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (gdvSalesAnalytics.DataSource == null) return;

            DataTable dt = gdvSalesAnalytics.DataSource as DataTable;
            if (dt == null) return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue))
            {
                (gdvSalesAnalytics.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                dt.DefaultView.RowFilter = $"SalesRepID LIKE '%{searchValue}%'";
            }
        }
    }
}
