namespace SiliconSource
{
    partial class ucCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlGridViewOperations = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gdvCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch.SuspendLayout();
            this.pnlGridViewOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
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
            // pnlGridViewOperations
            // 
            this.pnlGridViewOperations.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewOperations.BorderRadius = 10;
            this.pnlGridViewOperations.Controls.Add(this.btnRemove);
            this.pnlGridViewOperations.Controls.Add(this.btnCheckOut);
            this.pnlGridViewOperations.Controls.Add(this.cmbSort);
            this.pnlGridViewOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGridViewOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridViewOperations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.Location = new System.Drawing.Point(785, 100);
            this.pnlGridViewOperations.Name = "pnlGridViewOperations";
            this.pnlGridViewOperations.Size = new System.Drawing.Size(268, 490);
            this.pnlGridViewOperations.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Animated = true;
            this.btnRemove.AnimatedGIF = true;
            this.btnRemove.AutoRoundedCorners = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemove.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnRemove.Location = new System.Drawing.Point(50, 248);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(158, 45);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Animated = true;
            this.btnCheckOut.AnimatedGIF = true;
            this.btnCheckOut.AutoRoundedCorners = true;
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.Green;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnCheckOut.Location = new System.Drawing.Point(50, 197);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(158, 45);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Checkout";
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
            "$ Low - High",
            "$ High - Low"});
            this.cmbSort.ItemsAppearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cmbSort.Location = new System.Drawing.Point(50, 25);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(158, 36);
            this.cmbSort.StartIndex = 1;
            this.cmbSort.TabIndex = 0;
            this.cmbSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gdvCart
            // 
            this.gdvCart.AllowUserToAddRows = false;
            this.gdvCart.AllowUserToDeleteRows = false;
            this.gdvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvCart.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvCart.ColumnHeadersHeight = 15;
            this.gdvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.price,
            this.Quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.gdvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvCart.Location = new System.Drawing.Point(0, 100);
            this.gdvCart.Name = "gdvCart";
            this.gdvCart.ReadOnly = true;
            this.gdvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvCart.RowHeadersVisible = false;
            this.gdvCart.RowTemplate.Height = 25;
            this.gdvCart.Size = new System.Drawing.Size(785, 490);
            this.gdvCart.TabIndex = 12;
            this.gdvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.gdvCart.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.gdvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvCart.ThemeStyle.HeaderStyle.Height = 15;
            this.gdvCart.ThemeStyle.ReadOnly = true;
            this.gdvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvCart.ThemeStyle.RowsStyle.Height = 25;
            this.gdvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // productID
            // 
            this.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.HeaderText = "quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 70;
            // 
            // ucCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdvCart);
            this.Controls.Add(this.pnlGridViewOperations);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ucCart";
            this.Size = new System.Drawing.Size(1053, 590);
            this.pnlSearch.ResumeLayout(false);
            this.pnlGridViewOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSearch;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGridViewOperations;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        internal Guna.UI2.WinForms.Guna2DataGridView gdvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
