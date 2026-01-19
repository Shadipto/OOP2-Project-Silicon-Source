using System;
using System.Windows.Forms;

namespace SiliconSource
{
    public partial class ucHomeAdmin : UserControl
    {
        private AdminDashboard AdminDashboardForm { get; set; }

        public ucHomeAdmin()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (AdminDashboardForm is AdminDashboard dashboard)
            {
                dashboard.RefreshHomeTab();
            }
        }
    }
}
