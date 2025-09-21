namespace SiliconSource
{
    partial class ucAnalyticsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Guna2TextBox txtSearch;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAnalyticsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gdvSalesAnalytics = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlGridViewOperations = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAnalytics = new Guna.UI2.WinForms.Guna2Button();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.prgTarget = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblTargetAmout = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.salesRepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSalesAnalytics)).BeginInit();
            this.pnlGridViewOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Animated = true;
            txtSearch.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            txtSearch.BackColor = System.Drawing.Color.Transparent;
            txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.BorderRadius = 20;
            txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            txtSearch.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSearch.ForeColor = System.Drawing.Color.Black;
            txtSearch.HideSelection = false;
            txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            txtSearch.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            txtSearch.IconLeftOffset = new System.Drawing.Point(15, 0);
            txtSearch.Location = new System.Drawing.Point(26, 30);
            txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtSearch.PlaceholderText = "Search...........";
            txtSearch.SelectedText = "";
            txtSearch.Size = new System.Drawing.Size(420, 40);
            txtSearch.TabIndex = 2;
            txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderRadius = 10;
            this.pnlSearch.BorderThickness = 2;
            this.pnlSearch.Controls.Add(txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.FillColor3 = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.FillColor4 = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1053, 100);
            this.pnlSearch.TabIndex = 9;
            // 
            // gdvSalesAnalytics
            // 
            this.gdvSalesAnalytics.AllowUserToAddRows = false;
            this.gdvSalesAnalytics.AllowUserToDeleteRows = false;
            this.gdvSalesAnalytics.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvSalesAnalytics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvSalesAnalytics.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvSalesAnalytics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvSalesAnalytics.ColumnHeadersHeight = 15;
            this.gdvSalesAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvSalesAnalytics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesRepID,
            this.salesRepName,
            this.totalSalesCount,
            this.totalSales,
            this.productsSold});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvSalesAnalytics.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvSalesAnalytics.Dock = System.Windows.Forms.DockStyle.Left;
            this.gdvSalesAnalytics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvSalesAnalytics.Location = new System.Drawing.Point(0, 100);
            this.gdvSalesAnalytics.Name = "gdvSalesAnalytics";
            this.gdvSalesAnalytics.ReadOnly = true;
            this.gdvSalesAnalytics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvSalesAnalytics.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvSalesAnalytics.RowHeadersVisible = false;
            this.gdvSalesAnalytics.RowTemplate.Height = 25;
            this.gdvSalesAnalytics.Size = new System.Drawing.Size(662, 490);
            this.gdvSalesAnalytics.TabIndex = 10;
            this.gdvSalesAnalytics.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.gdvSalesAnalytics.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSalesAnalytics.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvSalesAnalytics.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvSalesAnalytics.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvSalesAnalytics.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvSalesAnalytics.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvSalesAnalytics.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.gdvSalesAnalytics.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvSalesAnalytics.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSalesAnalytics.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvSalesAnalytics.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvSalesAnalytics.ThemeStyle.HeaderStyle.Height = 15;
            this.gdvSalesAnalytics.ThemeStyle.ReadOnly = true;
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.Height = 25;
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvSalesAnalytics.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlGridViewOperations
            // 
            this.pnlGridViewOperations.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewOperations.BorderRadius = 10;
            this.pnlGridViewOperations.Controls.Add(this.btnAnalytics);
            this.pnlGridViewOperations.Controls.Add(this.cmbSort);
            this.pnlGridViewOperations.Controls.Add(this.lblTotalSales);
            this.pnlGridViewOperations.Controls.Add(this.lblSales);
            this.pnlGridViewOperations.Controls.Add(this.prgTarget);
            this.pnlGridViewOperations.Controls.Add(this.lblTargetAmout);
            this.pnlGridViewOperations.Controls.Add(this.lblTarget);
            this.pnlGridViewOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGridViewOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridViewOperations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.Location = new System.Drawing.Point(662, 100);
            this.pnlGridViewOperations.Name = "pnlGridViewOperations";
            this.pnlGridViewOperations.Size = new System.Drawing.Size(391, 490);
            this.pnlGridViewOperations.TabIndex = 11;
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Animated = true;
            this.btnAnalytics.AnimatedGIF = true;
            this.btnAnalytics.AutoRoundedCorners = true;
            this.btnAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAnalytics.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAnalytics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnalytics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnalytics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnalytics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnalytics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnalytics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAnalytics.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAnalytics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnalytics.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnAnalytics.Location = new System.Drawing.Point(115, 389);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(158, 45);
            this.btnAnalytics.TabIndex = 8;
            this.btnAnalytics.Text = "Print Summary";
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.Color.Transparent;
            this.cmbSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cmbSort.BorderRadius = 20;
            this.cmbSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cmbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cmbSort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cmbSort.ItemHeight = 30;
            this.cmbSort.Items.AddRange(new object[] {
            "Highest",
            "Lowest"});
            this.cmbSort.ItemsAppearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cmbSort.Location = new System.Drawing.Point(24, 25);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(158, 36);
            this.cmbSort.StartIndex = 0;
            this.cmbSort.TabIndex = 7;
            this.cmbSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(18, 284);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(115, 32);
            this.lblTotalSales.TabIndex = 4;
            this.lblTotalSales.Text = "Amount";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(18, 238);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(159, 32);
            this.lblSales.TabIndex = 3;
            this.lblSales.Text = "Total Sales";
            // 
            // prgTarget
            // 
            this.prgTarget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.prgTarget.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prgTarget.ForeColor = System.Drawing.Color.White;
            this.prgTarget.Location = new System.Drawing.Point(235, 87);
            this.prgTarget.Minimum = 0;
            this.prgTarget.Name = "prgTarget";
            this.prgTarget.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prgTarget.Size = new System.Drawing.Size(130, 130);
            this.prgTarget.TabIndex = 2;
            this.prgTarget.Text = "guna2CircleProgressBar1";
            // 
            // lblTargetAmout
            // 
            this.lblTargetAmout.AutoSize = true;
            this.lblTargetAmout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetAmout.Location = new System.Drawing.Point(18, 145);
            this.lblTargetAmout.Name = "lblTargetAmout";
            this.lblTargetAmout.Size = new System.Drawing.Size(115, 32);
            this.lblTargetAmout.TabIndex = 1;
            this.lblTargetAmout.Text = "Amount";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(18, 99);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(211, 32);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "Monthly Target";
            // 
            // salesRepID
            // 
            this.salesRepID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salesRepID.HeaderText = "Sales Rep ID";
            this.salesRepID.Name = "salesRepID";
            this.salesRepID.ReadOnly = true;
            // 
            // salesRepName
            // 
            this.salesRepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salesRepName.FillWeight = 126.9036F;
            this.salesRepName.HeaderText = "Sales Rep Name";
            this.salesRepName.Name = "salesRepName";
            this.salesRepName.ReadOnly = true;
            this.salesRepName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRepName.Width = 130;
            // 
            // totalSalesCount
            // 
            this.totalSalesCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalSalesCount.HeaderText = "Total Sales Count";
            this.totalSalesCount.Name = "totalSalesCount";
            this.totalSalesCount.ReadOnly = true;
            this.totalSalesCount.Width = 80;
            // 
            // totalSales
            // 
            this.totalSales.HeaderText = "Total Sales";
            this.totalSales.Name = "totalSales";
            this.totalSales.ReadOnly = true;
            // 
            // productsSold
            // 
            this.productsSold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productsSold.HeaderText = "Products Sold";
            this.productsSold.Name = "productsSold";
            this.productsSold.ReadOnly = true;
            this.productsSold.Width = 200;
            // 
            // ucAnalyticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGridViewOperations);
            this.Controls.Add(this.gdvSalesAnalytics);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ucAnalyticsControl";
            this.Size = new System.Drawing.Size(1053, 590);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvSalesAnalytics)).EndInit();
            this.pnlGridViewOperations.ResumeLayout(false);
            this.pnlGridViewOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSearch;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGridViewOperations;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTargetAmout;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblSales;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prgTarget;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private Guna.UI2.WinForms.Guna2Button btnAnalytics;
        internal Guna.UI2.WinForms.Guna2DataGridView gdvSalesAnalytics;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsSold;
    }
}
