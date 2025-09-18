namespace SiliconSource
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaAdminDashboard = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Menu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Body = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaAdminDashboard
            // 
            this.gunaAdminDashboard.AnimateWindow = true;
            this.gunaAdminDashboard.AnimationInterval = 400;
            this.gunaAdminDashboard.BorderRadius = 20;
            this.gunaAdminDashboard.ContainerControl = this;
            this.gunaAdminDashboard.DockForm = false;
            this.gunaAdminDashboard.DockIndicatorTransparencyValue = 0.6D;
            this.gunaAdminDashboard.TransparentWhileDrag = true;
            // 
            // guna2Menu
            // 
            this.guna2Menu.BackColor = System.Drawing.Color.White;
            this.guna2Menu.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Menu.BorderRadius = 10;
            this.guna2Menu.BorderThickness = 1;
            this.guna2Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.guna2Menu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.guna2Menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Menu.Location = new System.Drawing.Point(10, 10);
            this.guna2Menu.Name = "guna2Menu";
            this.guna2Menu.Size = new System.Drawing.Size(200, 700);
            this.guna2Menu.TabIndex = 0;
            // 
            // guna2Body
            // 
            this.guna2Body.BackColor = System.Drawing.Color.White;
            this.guna2Body.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Body.BorderRadius = 10;
            this.guna2Body.BorderThickness = 1;
            this.guna2Body.Controls.Add(this.guna2btnExit);
            this.guna2Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Body.FillColor = System.Drawing.Color.White;
            this.guna2Body.FillColor2 = System.Drawing.Color.White;
            this.guna2Body.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Body.Location = new System.Drawing.Point(210, 10);
            this.guna2Body.Name = "guna2Body";
            this.guna2Body.Size = new System.Drawing.Size(1060, 700);
            this.guna2Body.TabIndex = 1;
            // 
            // guna2btnExit
            // 
            this.guna2btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2btnExit.Animated = true;
            this.guna2btnExit.AutoRoundedCorners = true;
            this.guna2btnExit.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.guna2btnExit.BorderRadius = 13;
            this.guna2btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.guna2btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2btnExit.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2btnExit.IconColor = System.Drawing.Color.White;
            this.guna2btnExit.Location = new System.Drawing.Point(1012, 3);
            this.guna2btnExit.Name = "guna2btnExit";
            this.guna2btnExit.Size = new System.Drawing.Size(45, 29);
            this.guna2btnExit.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.guna2Body);
            this.Controls.Add(this.guna2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gunaAdminDashboard;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2Menu;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2Body;
        private Guna.UI2.WinForms.Guna2ControlBox guna2btnExit;
    }
}

