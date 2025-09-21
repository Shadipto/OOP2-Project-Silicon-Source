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
    public partial class ucInventoryControlAdmin : UserControl
    {
        
        public ucInventoryControlAdmin()
        {
            InitializeComponent();
        }

        private void gdvInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdvInventory.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(gdvInventory.SelectedRows.Count > 0)
            {
                int productID = int.Parse(gdvInventory.SelectedRows[0].Cells["ProductID"].Value?.ToString());
                this.Hide();
                var updateInventory = new UpdateInventory(productID);
                updateInventory.Show();

            }
        }
    }
}
