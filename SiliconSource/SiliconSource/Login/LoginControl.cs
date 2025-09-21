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
    public partial class LoginControl : UserControl
    {
        public string Label { get; set; }
        public bool IsPassword {  get; set; }
        public bool IsReadOnly {  get; set; }
        public LoginControl()
        {
            this.Label = "Default Value";
            this.IsPassword = false;
            this.IsReadOnly = false;
            InitializeComponent();
        }

        public string TextboxText
        {
            get { return this.txtInfo.Text; }
            set { this.txtInfo.Text = value; }
        }

        private void pnlLoginTextbox_Paint(object sender, PaintEventArgs e)
        {
            this.lblText.Text = this.Label;
            if(this.IsPassword) 
                this.txtInfo.UseSystemPasswordChar = true;
            else
                this.txtInfo.UseSystemPasswordChar=false;

            if(this.IsReadOnly)
                this.txtInfo.ReadOnly = true;
            else
                this.txtInfo.ReadOnly = false;
        }
    }
}
