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
    public partial class ucHomeAdmin : UserControl
    {
        private AdminDashboard AdminDashboardform { get; set; }

        public ucHomeAdmin()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (AdminDashboardform is AdminDashboard dashboard)
            {
                dashboard.RefreshHomeTab();
            }
        }
    }
}
