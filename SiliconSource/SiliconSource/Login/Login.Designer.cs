namespace SiliconSource
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaLogin = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlLoginLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblSiliconSource = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbCloud = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRadiant = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDevelopedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlLoginRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.ucLoginPassword = new SiliconSource.LoginControl();
            this.ucLoginID = new SiliconSource.LoginControl();
            this.lblSignin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlLoginLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            this.pnlLoginRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLogin
            // 
            this.gunaLogin.AnimateWindow = true;
            this.gunaLogin.AnimationInterval = 400;
            this.gunaLogin.BorderRadius = 10;
            this.gunaLogin.ContainerControl = this;
            this.gunaLogin.DockForm = false;
            this.gunaLogin.DockIndicatorTransparencyValue = 0.6D;
            this.gunaLogin.ResizeForm = false;
            this.gunaLogin.TransparentWhileDrag = true;
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
            this.btnExit.Location = new System.Drawing.Point(378, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 2;
            // 
            // pnlLoginLeft
            // 
            this.pnlLoginLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlLoginLeft.Controls.Add(this.lblSiliconSource);
            this.pnlLoginLeft.Controls.Add(this.lblWelcome);
            this.pnlLoginLeft.Controls.Add(this.pbLogo);
            this.pnlLoginLeft.Controls.Add(this.pbCloud);
            this.pnlLoginLeft.Controls.Add(this.lblRadiant);
            this.pnlLoginLeft.Controls.Add(this.lblDevelopedBy);
            this.pnlLoginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLoginLeft.Name = "pnlLoginLeft";
            this.pnlLoginLeft.Size = new System.Drawing.Size(515, 600);
            this.pnlLoginLeft.TabIndex = 3;
            // 
            // lblSiliconSource
            // 
            this.lblSiliconSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSiliconSource.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiliconSource.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSiliconSource.Location = new System.Drawing.Point(101, 395);
            this.lblSiliconSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSiliconSource.Name = "lblSiliconSource";
            this.lblSiliconSource.Size = new System.Drawing.Size(227, 39);
            this.lblSiliconSource.TabIndex = 8;
            this.lblSiliconSource.Text = "Silicon Source";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(110, 159);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 35);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "WELCOME TO";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(101, 190);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // pbCloud
            // 
            this.pbCloud.Image = ((System.Drawing.Image)(resources.GetObject("pbCloud.Image")));
            this.pbCloud.ImageRotate = 0F;
            this.pbCloud.Location = new System.Drawing.Point(307, 0);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(255, 600);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud.TabIndex = 6;
            this.pbCloud.TabStop = false;
            // 
            // lblRadiant
            // 
            this.lblRadiant.BackColor = System.Drawing.Color.Transparent;
            this.lblRadiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRadiant.Location = new System.Drawing.Point(8, 571);
            this.lblRadiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblRadiant.Name = "lblRadiant";
            this.lblRadiant.Size = new System.Drawing.Size(46, 14);
            this.lblRadiant.TabIndex = 5;
            this.lblRadiant.Text = "Radiant";
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblDevelopedBy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopedBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDevelopedBy.Location = new System.Drawing.Point(8, 557);
            this.lblDevelopedBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(79, 14);
            this.lblDevelopedBy.TabIndex = 4;
            this.lblDevelopedBy.Text = "Developed By";
            // 
            // pnlLoginRight
            // 
            this.pnlLoginRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLoginRight.Controls.Add(this.btnExit);
            this.pnlLoginRight.Controls.Add(this.btnLogin);
            this.pnlLoginRight.Controls.Add(this.ucLoginPassword);
            this.pnlLoginRight.Controls.Add(this.ucLoginID);
            this.pnlLoginRight.Controls.Add(this.lblSignin);
            this.pnlLoginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginRight.Location = new System.Drawing.Point(515, 0);
            this.pnlLoginRight.Name = "pnlLoginRight";
            this.pnlLoginRight.Size = new System.Drawing.Size(435, 600);
            this.pnlLoginRight.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(140, 422);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 49);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ucLoginPassword
            // 
            this.ucLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucLoginPassword.IsPassword = true;
            this.ucLoginPassword.IsReadOnly = false;
            this.ucLoginPassword.Label = "Password";
            this.ucLoginPassword.Location = new System.Drawing.Point(53, 270);
            this.ucLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucLoginPassword.Name = "ucLoginPassword";
            this.ucLoginPassword.Size = new System.Drawing.Size(349, 71);
            this.ucLoginPassword.TabIndex = 11;
            // 
            // ucLoginID
            // 
            this.ucLoginID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucLoginID.IsPassword = false;
            this.ucLoginID.IsReadOnly = false;
            this.ucLoginID.Label = "UserID";
            this.ucLoginID.Location = new System.Drawing.Point(53, 193);
            this.ucLoginID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucLoginID.Name = "ucLoginID";
            this.ucLoginID.Size = new System.Drawing.Size(349, 71);
            this.ucLoginID.TabIndex = 10;
            // 
            // lblSignin
            // 
            this.lblSignin.BackColor = System.Drawing.Color.Transparent;
            this.lblSignin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSignin.Location = new System.Drawing.Point(168, 100);
            this.lblSignin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(125, 39);
            this.lblSignin.TabIndex = 9;
            this.lblSignin.Text = "SIGN IN";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnlLoginRight);
            this.Controls.Add(this.pnlLoginLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLoginLeft.ResumeLayout(false);
            this.pnlLoginLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            this.pnlLoginRight.ResumeLayout(false);
            this.pnlLoginRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gunaLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlLoginLeft;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRadiant;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDevelopedBy;
        private Guna.UI2.WinForms.Guna2PictureBox pbCloud;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlLoginRight;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSiliconSource;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSignin;
        private LoginControl ucLoginID;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private LoginControl ucLoginPassword;
    }
}