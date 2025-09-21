namespace SiliconSource
{
    partial class UpdateInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInventory));
            this.gunaUpdateInventory = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlUpdateInventoryLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pbInventory = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblInventory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUpdate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExisting = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbCloud = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRadiant = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDevelopedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlUpdateInventoryRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.cmbSupplierName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ucSKU = new SiliconSource.LoginControl();
            this.ucStockQuantity = new SiliconSource.LoginControl();
            this.ucCost = new SiliconSource.LoginControl();
            this.ucPrice = new SiliconSource.LoginControl();
            this.ucDescription = new SiliconSource.LoginControl();
            this.ucProductName = new SiliconSource.LoginControl();
            this.pnlUpdateInventoryLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            this.pnlUpdateInventoryRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaUpdateInventory
            // 
            this.gunaUpdateInventory.AnimateWindow = true;
            this.gunaUpdateInventory.ContainerControl = this;
            this.gunaUpdateInventory.DockIndicatorTransparencyValue = 0.6D;
            this.gunaUpdateInventory.DragForm = false;
            this.gunaUpdateInventory.ResizeForm = false;
            this.gunaUpdateInventory.TransparentWhileDrag = true;
            // 
            // pnlUpdateInventoryLeft
            // 
            this.pnlUpdateInventoryLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlUpdateInventoryLeft.Controls.Add(this.pbInventory);
            this.pnlUpdateInventoryLeft.Controls.Add(this.lblInventory);
            this.pnlUpdateInventoryLeft.Controls.Add(this.lblUpdate);
            this.pnlUpdateInventoryLeft.Controls.Add(this.lblExisting);
            this.pnlUpdateInventoryLeft.Controls.Add(this.pbCloud);
            this.pnlUpdateInventoryLeft.Controls.Add(this.lblRadiant);
            this.pnlUpdateInventoryLeft.Controls.Add(this.lblDevelopedBy);
            this.pnlUpdateInventoryLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUpdateInventoryLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateInventoryLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpdateInventoryLeft.Name = "pnlUpdateInventoryLeft";
            this.pnlUpdateInventoryLeft.Size = new System.Drawing.Size(369, 763);
            this.pnlUpdateInventoryLeft.TabIndex = 5;
            // 
            // pbInventory
            // 
            this.pbInventory.Image = ((System.Drawing.Image)(resources.GetObject("pbInventory.Image")));
            this.pbInventory.ImageRotate = 0F;
            this.pbInventory.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbInventory.InitialImage")));
            this.pbInventory.Location = new System.Drawing.Point(31, 88);
            this.pbInventory.Name = "pbInventory";
            this.pbInventory.Size = new System.Drawing.Size(173, 162);
            this.pbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInventory.TabIndex = 9;
            this.pbInventory.TabStop = false;
            // 
            // lblInventory
            // 
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.lblInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInventory.Location = new System.Drawing.Point(24, 394);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(2);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(175, 35);
            this.lblInventory.TabIndex = 8;
            this.lblInventory.Text = "INVENTORY";
            // 
            // lblUpdate
            // 
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.lblUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdate.Location = new System.Drawing.Point(24, 310);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(123, 35);
            this.lblUpdate.TabIndex = 7;
            this.lblUpdate.Text = "UPDATE";
            // 
            // lblExisting
            // 
            this.lblExisting.BackColor = System.Drawing.Color.Transparent;
            this.lblExisting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.lblExisting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExisting.Location = new System.Drawing.Point(24, 352);
            this.lblExisting.Margin = new System.Windows.Forms.Padding(2);
            this.lblExisting.Name = "lblExisting";
            this.lblExisting.Size = new System.Drawing.Size(140, 35);
            this.lblExisting.TabIndex = 3;
            this.lblExisting.Text = "EXISTING";
            // 
            // pbCloud
            // 
            this.pbCloud.Image = ((System.Drawing.Image)(resources.GetObject("pbCloud.Image")));
            this.pbCloud.ImageRotate = 0F;
            this.pbCloud.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCloud.InitialImage")));
            this.pbCloud.Location = new System.Drawing.Point(159, 0);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(255, 763);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud.TabIndex = 6;
            this.pbCloud.TabStop = false;
            // 
            // lblRadiant
            // 
            this.lblRadiant.BackColor = System.Drawing.Color.Transparent;
            this.lblRadiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRadiant.Location = new System.Drawing.Point(8, 734);
            this.lblRadiant.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblDevelopedBy.Location = new System.Drawing.Point(8, 720);
            this.lblDevelopedBy.Margin = new System.Windows.Forms.Padding(2);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(79, 14);
            this.lblDevelopedBy.TabIndex = 4;
            this.lblDevelopedBy.Text = "Developed By";
            // 
            // pnlUpdateInventoryRight
            // 
            this.pnlUpdateInventoryRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUpdateInventoryRight.Controls.Add(this.btnClear);
            this.pnlUpdateInventoryRight.Controls.Add(this.btnUpdate);
            this.pnlUpdateInventoryRight.Controls.Add(this.lblSupplierName);
            this.pnlUpdateInventoryRight.Controls.Add(this.cmbSupplierName);
            this.pnlUpdateInventoryRight.Controls.Add(this.cmbCategory);
            this.pnlUpdateInventoryRight.Controls.Add(this.lblCategory);
            this.pnlUpdateInventoryRight.Controls.Add(this.ucSKU);
            this.pnlUpdateInventoryRight.Controls.Add(this.ucStockQuantity);
            this.pnlUpdateInventoryRight.Controls.Add(this.ucCost);
            this.pnlUpdateInventoryRight.Controls.Add(this.ucPrice);
            this.pnlUpdateInventoryRight.Controls.Add(this.ucDescription);
            this.pnlUpdateInventoryRight.Controls.Add(this.ucProductName);
            this.pnlUpdateInventoryRight.Controls.Add(this.btnExit);
            this.pnlUpdateInventoryRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateInventoryRight.Location = new System.Drawing.Point(369, 0);
            this.pnlUpdateInventoryRight.Name = "pnlUpdateInventoryRight";
            this.pnlUpdateInventoryRight.Size = new System.Drawing.Size(482, 763);
            this.pnlUpdateInventoryRight.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(245, 682);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 49);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(30, 682);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 49);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(49, 586);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(111, 17);
            this.lblSupplierName.TabIndex = 15;
            this.lblSupplierName.Text = "SupplierName";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplierName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.cmbSupplierName.BorderRadius = 20;
            this.cmbSupplierName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplierName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSupplierName.ItemHeight = 30;
            this.cmbSupplierName.Items.AddRange(new object[] {
            "AMD",
            "ASUS",
            "Cooler Master",
            "Corsair",
            "Gigabyte",
            "Global Brand Pvt Ltd",
            "HP",
            "Intel",
            "Lenovo",
            "MSI",
            "NVIDIA",
            "Smart Technologies BD Ltd",
            "Star Tech & Engineering Ltd",
            "TechLand BD",
            "UCC"});
            this.cmbSupplierName.Location = new System.Drawing.Point(51, 616);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(349, 36);
            this.cmbSupplierName.TabIndex = 14;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.cmbCategory.BorderRadius = 20;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Items.AddRange(new object[] {
            "Desktop Computers",
            "Laptops & Notebooks",
            "Monitors & Displays",
            "Processors (CPUs)",
            "Graphics Cards (GPUs)",
            "RAM & Storage Devices",
            "Motherboards",
            "Peripherals & Accessories",
            "Networking Equipment",
            "Power Supplies & Cooling Solutions"});
            this.cmbCategory.Location = new System.Drawing.Point(51, 156);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(349, 36);
            this.cmbCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(51, 131);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 17);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category";
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
            // ucSKU
            // 
            this.ucSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucSKU.IsPassword = false;
            this.ucSKU.IsReadOnly = false;
            this.ucSKU.Label = "SKU";
            this.ucSKU.Location = new System.Drawing.Point(51, 506);
            this.ucSKU.Name = "ucSKU";
            this.ucSKU.Size = new System.Drawing.Size(349, 71);
            this.ucSKU.TabIndex = 11;
            this.ucSKU.TextboxText = "";
            // 
            // ucStockQuantity
            // 
            this.ucStockQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucStockQuantity.IsPassword = false;
            this.ucStockQuantity.IsReadOnly = false;
            this.ucStockQuantity.Label = "Stock Quantity";
            this.ucStockQuantity.Location = new System.Drawing.Point(51, 429);
            this.ucStockQuantity.Name = "ucStockQuantity";
            this.ucStockQuantity.Size = new System.Drawing.Size(349, 71);
            this.ucStockQuantity.TabIndex = 10;
            this.ucStockQuantity.TextboxText = "";
            // 
            // ucCost
            // 
            this.ucCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucCost.IsPassword = false;
            this.ucCost.IsReadOnly = false;
            this.ucCost.Label = "Cost";
            this.ucCost.Location = new System.Drawing.Point(51, 352);
            this.ucCost.Name = "ucCost";
            this.ucCost.Size = new System.Drawing.Size(349, 71);
            this.ucCost.TabIndex = 9;
            this.ucCost.TextboxText = "";
            // 
            // ucPrice
            // 
            this.ucPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucPrice.IsPassword = false;
            this.ucPrice.IsReadOnly = false;
            this.ucPrice.Label = "Price";
            this.ucPrice.Location = new System.Drawing.Point(51, 275);
            this.ucPrice.Name = "ucPrice";
            this.ucPrice.Size = new System.Drawing.Size(349, 71);
            this.ucPrice.TabIndex = 8;
            this.ucPrice.TextboxText = "";
            // 
            // ucDescription
            // 
            this.ucDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucDescription.IsPassword = false;
            this.ucDescription.IsReadOnly = false;
            this.ucDescription.Label = "Description";
            this.ucDescription.Location = new System.Drawing.Point(51, 198);
            this.ucDescription.Name = "ucDescription";
            this.ucDescription.Size = new System.Drawing.Size(349, 71);
            this.ucDescription.TabIndex = 7;
            this.ucDescription.TextboxText = "";
            // 
            // ucProductName
            // 
            this.ucProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.ucProductName.IsPassword = false;
            this.ucProductName.IsReadOnly = false;
            this.ucProductName.Label = "ProductName";
            this.ucProductName.Location = new System.Drawing.Point(51, 53);
            this.ucProductName.Name = "ucProductName";
            this.ucProductName.Size = new System.Drawing.Size(349, 71);
            this.ucProductName.TabIndex = 5;
            this.ucProductName.TextboxText = "";
            // 
            // UpdateInventory
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 763);
            this.Controls.Add(this.pnlUpdateInventoryRight);
            this.Controls.Add(this.pnlUpdateInventoryLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateInventory";
            this.pnlUpdateInventoryLeft.ResumeLayout(false);
            this.pnlUpdateInventoryLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            this.pnlUpdateInventoryRight.ResumeLayout(false);
            this.pnlUpdateInventoryRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gunaUpdateInventory;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlUpdateInventoryLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInventory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExisting;
        private Guna.UI2.WinForms.Guna2PictureBox pbCloud;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRadiant;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlUpdateInventoryRight;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label lblSupplierName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSupplierName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private LoginControl ucSKU;
        private LoginControl ucStockQuantity;
        private LoginControl ucCost;
        private LoginControl ucPrice;
        private LoginControl ucDescription;
        private LoginControl ucProductName;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox pbInventory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDevelopedBy;
    }
}