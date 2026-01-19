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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAnalyticsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gdvSalesAnalytics = new Guna.UI2.WinForms.Guna2DataGridView();
            this.salesRepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGridViewOperations = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAnalytics = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSalesAnalytics)).BeginInit();
            this.pnlGridViewOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HideSelection = false;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtSearch.Location = new System.Drawing.Point(26, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.PlaceholderText = "Search...........";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(420, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderRadius = 10;
            this.pnlSearch.BorderThickness = 2;
            this.pnlSearch.Controls.Add(this.txtSearch);
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvSalesAnalytics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gdvSalesAnalytics.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvSalesAnalytics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdvSalesAnalytics.ColumnHeadersHeight = 15;
            this.gdvSalesAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvSalesAnalytics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesRepID,
            this.salesRepName,
            this.totalSalesCount,
            this.totalSales,
            this.productsSold});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvSalesAnalytics.DefaultCellStyle = dataGridViewCellStyle7;
            this.gdvSalesAnalytics.Dock = System.Windows.Forms.DockStyle.Left;
            this.gdvSalesAnalytics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvSalesAnalytics.Location = new System.Drawing.Point(0, 100);
            this.gdvSalesAnalytics.Name = "gdvSalesAnalytics";
            this.gdvSalesAnalytics.ReadOnly = true;
            this.gdvSalesAnalytics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvSalesAnalytics.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // pnlGridViewOperations
            // 
            this.pnlGridViewOperations.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewOperations.BorderRadius = 10;
            this.pnlGridViewOperations.Controls.Add(this.btnAnalytics);
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
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSearch;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGridViewOperations;
        private Guna.UI2.WinForms.Guna2Button btnAnalytics;
        internal Guna.UI2.WinForms.Guna2DataGridView gdvSalesAnalytics;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsSold;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
