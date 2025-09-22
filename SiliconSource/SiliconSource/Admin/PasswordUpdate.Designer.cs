namespace SiliconSource.Admin
{
    partial class PasswordUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordUpdate));
            this.gunaPasswordUpdate = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlBase = new Guna.UI2.WinForms.Guna2Panel();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.ucConfirmPassword = new SiliconSource.LoginControl();
            this.ucNewPassword = new SiliconSource.LoginControl();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPasswordUpdate
            // 
            this.gunaPasswordUpdate.AnimateWindow = true;
            this.gunaPasswordUpdate.BorderRadius = 10;
            this.gunaPasswordUpdate.ContainerControl = this;
            this.gunaPasswordUpdate.DockIndicatorTransparencyValue = 0.6D;
            this.gunaPasswordUpdate.TransparentWhileDrag = true;
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.White;
            this.pnlBase.Controls.Add(this.btnExit);
            this.pnlBase.Controls.Add(this.pbLogo);
            this.pnlBase.Controls.Add(this.btnConfirm);
            this.pnlBase.Controls.Add(this.ucConfirmPassword);
            this.pnlBase.Controls.Add(this.ucNewPassword);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(0, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(400, 450);
            this.pnlBase.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BorderRadius = 10;
            this.pbLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.ErrorImage")));
            this.pbLogo.FillColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(144, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 99);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            this.pbLogo.UseTransparentBackground = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.AnimatedGIF = true;
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnConfirm.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirm.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnConfirm.Location = new System.Drawing.Point(112, 349);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(158, 45);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ucConfirmPassword
            // 
            this.ucConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucConfirmPassword.IsPassword = false;
            this.ucConfirmPassword.IsReadOnly = false;
            this.ucConfirmPassword.Label = "Confirm Password";
            this.ucConfirmPassword.Location = new System.Drawing.Point(12, 229);
            this.ucConfirmPassword.Name = "ucConfirmPassword";
            this.ucConfirmPassword.Size = new System.Drawing.Size(349, 71);
            this.ucConfirmPassword.TabIndex = 1;
            this.ucConfirmPassword.TextboxText = "";
            // 
            // ucNewPassword
            // 
            this.ucNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucNewPassword.IsPassword = false;
            this.ucNewPassword.IsReadOnly = false;
            this.ucNewPassword.Label = "New Password";
            this.ucNewPassword.Location = new System.Drawing.Point(12, 133);
            this.ucNewPassword.Name = "ucNewPassword";
            this.ucNewPassword.Size = new System.Drawing.Size(349, 71);
            this.ucNewPassword.TabIndex = 0;
            this.ucNewPassword.TextboxText = "";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 13;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(343, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PasswordUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pnlBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordUpdate";
            this.pnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gunaPasswordUpdate;
        private Guna.UI2.WinForms.Guna2Panel pnlBase;
        private LoginControl ucNewPassword;
        private LoginControl ucConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
    }
}