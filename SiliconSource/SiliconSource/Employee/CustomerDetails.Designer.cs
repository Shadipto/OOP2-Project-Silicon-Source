namespace SiliconSource.Employee
{
    partial class CustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetails));
            this.gunaCustomeretails = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlCustomerDetailsLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pbBilling = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDetails = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAdd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbCloud = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRadiant = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDevelopedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlCustomerDetailsRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ucCustomerEmail = new SiliconSource.LoginControl();
            this.ucPhoneNumber = new SiliconSource.LoginControl();
            this.ucCustomerLastName = new SiliconSource.LoginControl();
            this.ucCustomerFirstName = new SiliconSource.LoginControl();
            this.cmbPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.pnlCustomerDetailsLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            this.pnlCustomerDetailsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaCustomeretails
            // 
            this.gunaCustomeretails.AnimateWindow = true;
            this.gunaCustomeretails.BorderRadius = 10;
            this.gunaCustomeretails.ContainerControl = this;
            this.gunaCustomeretails.DockIndicatorTransparencyValue = 0.6D;
            this.gunaCustomeretails.ResizeForm = false;
            this.gunaCustomeretails.TransparentWhileDrag = true;
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
            this.btnExit.Location = new System.Drawing.Point(425, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCustomerDetailsLeft
            // 
            this.pnlCustomerDetailsLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlCustomerDetailsLeft.Controls.Add(this.pbBilling);
            this.pnlCustomerDetailsLeft.Controls.Add(this.lblDetails);
            this.pnlCustomerDetailsLeft.Controls.Add(this.lblAdd);
            this.pnlCustomerDetailsLeft.Controls.Add(this.lblCustomer);
            this.pnlCustomerDetailsLeft.Controls.Add(this.pbCloud);
            this.pnlCustomerDetailsLeft.Controls.Add(this.lblRadiant);
            this.pnlCustomerDetailsLeft.Controls.Add(this.lblDevelopedBy);
            this.pnlCustomerDetailsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCustomerDetailsLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerDetailsLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCustomerDetailsLeft.Name = "pnlCustomerDetailsLeft";
            this.pnlCustomerDetailsLeft.Size = new System.Drawing.Size(369, 763);
            this.pnlCustomerDetailsLeft.TabIndex = 4;
            // 
            // pbBilling
            // 
            this.pbBilling.Image = ((System.Drawing.Image)(resources.GetObject("pbBilling.Image")));
            this.pbBilling.ImageRotate = 0F;
            this.pbBilling.InitialImage = null;
            this.pbBilling.Location = new System.Drawing.Point(31, 107);
            this.pbBilling.Name = "pbBilling";
            this.pbBilling.Size = new System.Drawing.Size(173, 162);
            this.pbBilling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBilling.TabIndex = 18;
            this.pbBilling.TabStop = false;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDetails.Location = new System.Drawing.Point(33, 394);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(107, 38);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.Text = "DETAILS";
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdd.Location = new System.Drawing.Point(33, 310);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(2);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(64, 38);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "ADD";
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCustomer.Location = new System.Drawing.Point(33, 352);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(169, 38);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "CUSTOMERS";
            // 
            // pbCloud
            // 
            this.pbCloud.FillColor = System.Drawing.Color.Transparent;
            this.pbCloud.Image = ((System.Drawing.Image)(resources.GetObject("pbCloud.Image")));
            this.pbCloud.ImageRotate = 0F;
            this.pbCloud.InitialImage = null;
            this.pbCloud.Location = new System.Drawing.Point(159, -6);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(255, 769);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud.TabIndex = 6;
            this.pbCloud.TabStop = false;
            // 
            // lblRadiant
            // 
            this.lblRadiant.BackColor = System.Drawing.Color.Transparent;
            this.lblRadiant.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRadiant.Location = new System.Drawing.Point(8, 734);
            this.lblRadiant.Margin = new System.Windows.Forms.Padding(2);
            this.lblRadiant.Name = "lblRadiant";
            this.lblRadiant.Size = new System.Drawing.Size(47, 18);
            this.lblRadiant.TabIndex = 5;
            this.lblRadiant.Text = "Radiant";
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblDevelopedBy.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopedBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDevelopedBy.Location = new System.Drawing.Point(8, 720);
            this.lblDevelopedBy.Margin = new System.Windows.Forms.Padding(2);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(80, 18);
            this.lblDevelopedBy.TabIndex = 4;
            this.lblDevelopedBy.Text = "Developed By";
            // 
            // pnlCustomerDetailsRight
            // 
            this.pnlCustomerDetailsRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCustomerDetailsRight.Controls.Add(this.lblPaymentMethod);
            this.pnlCustomerDetailsRight.Controls.Add(this.cmbPaymentMethod);
            this.pnlCustomerDetailsRight.Controls.Add(this.btnClear);
            this.pnlCustomerDetailsRight.Controls.Add(this.btnSave);
            this.pnlCustomerDetailsRight.Controls.Add(this.ucCustomerEmail);
            this.pnlCustomerDetailsRight.Controls.Add(this.ucPhoneNumber);
            this.pnlCustomerDetailsRight.Controls.Add(this.ucCustomerLastName);
            this.pnlCustomerDetailsRight.Controls.Add(this.ucCustomerFirstName);
            this.pnlCustomerDetailsRight.Controls.Add(this.btnExit);
            this.pnlCustomerDetailsRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerDetailsRight.Location = new System.Drawing.Point(369, 0);
            this.pnlCustomerDetailsRight.Name = "pnlCustomerDetailsRight";
            this.pnlCustomerDetailsRight.Size = new System.Drawing.Size(482, 763);
            this.pnlCustomerDetailsRight.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(245, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 49);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 49);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucCustomerEmail
            // 
            this.ucCustomerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucCustomerEmail.IsPassword = false;
            this.ucCustomerEmail.IsReadOnly = false;
            this.ucCustomerEmail.Label = "E-mail";
            this.ucCustomerEmail.Location = new System.Drawing.Point(57, 407);
            this.ucCustomerEmail.Name = "ucCustomerEmail";
            this.ucCustomerEmail.Size = new System.Drawing.Size(349, 71);
            this.ucCustomerEmail.TabIndex = 9;
            this.ucCustomerEmail.TextboxText = "";
            // 
            // ucPhoneNumber
            // 
            this.ucPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucPhoneNumber.IsPassword = false;
            this.ucPhoneNumber.IsReadOnly = false;
            this.ucPhoneNumber.Label = "Phone";
            this.ucPhoneNumber.Location = new System.Drawing.Point(57, 305);
            this.ucPhoneNumber.Name = "ucPhoneNumber";
            this.ucPhoneNumber.Size = new System.Drawing.Size(349, 71);
            this.ucPhoneNumber.TabIndex = 8;
            this.ucPhoneNumber.TextboxText = "";
            // 
            // ucCustomerLastName
            // 
            this.ucCustomerLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucCustomerLastName.IsPassword = false;
            this.ucCustomerLastName.IsReadOnly = false;
            this.ucCustomerLastName.Label = "Last Name";
            this.ucCustomerLastName.Location = new System.Drawing.Point(57, 209);
            this.ucCustomerLastName.Name = "ucCustomerLastName";
            this.ucCustomerLastName.Size = new System.Drawing.Size(349, 71);
            this.ucCustomerLastName.TabIndex = 7;
            this.ucCustomerLastName.TextboxText = "";
            // 
            // ucCustomerFirstName
            // 
            this.ucCustomerFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucCustomerFirstName.IsPassword = false;
            this.ucCustomerFirstName.IsReadOnly = false;
            this.ucCustomerFirstName.Label = "First Name";
            this.ucCustomerFirstName.Location = new System.Drawing.Point(57, 109);
            this.ucCustomerFirstName.Name = "ucCustomerFirstName";
            this.ucCustomerFirstName.Size = new System.Drawing.Size(349, 71);
            this.ucCustomerFirstName.TabIndex = 5;
            this.ucCustomerFirstName.TextboxText = "";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPaymentMethod.ItemHeight = 30;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(57, 531);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(349, 36);
            this.cmbPaymentMethod.TabIndex = 18;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(53, 506);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(138, 22);
            this.lblPaymentMethod.TabIndex = 19;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // CustomerDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 763);
            this.Controls.Add(this.pnlCustomerDetailsRight);
            this.Controls.Add(this.pnlCustomerDetailsLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddInventory";
            this.pnlCustomerDetailsLeft.ResumeLayout(false);
            this.pnlCustomerDetailsLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            this.pnlCustomerDetailsRight.ResumeLayout(false);
            this.pnlCustomerDetailsRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gunaCustomeretails;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCustomerDetailsLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomer;
        private Guna.UI2.WinForms.Guna2PictureBox pbCloud;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRadiant;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDevelopedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDetails;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdd;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCustomerDetailsRight;
        private LoginControl ucCustomerEmail;
        private LoginControl ucPhoneNumber;
        private LoginControl ucCustomerLastName;
        private LoginControl ucCustomerFirstName;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2PictureBox pbBilling;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
    }
}