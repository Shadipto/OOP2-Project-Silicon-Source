namespace SiliconSource
{
    partial class ucInventoryControlEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInventoryControlEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlGridViewOperations = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.gdvInventory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSearch.SuspendLayout();
            this.pnlGridViewOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInventory)).BeginInit();
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
            this.pnlSearch.TabIndex = 8;
            // 
            // pnlGridViewOperations
            // 
            this.pnlGridViewOperations.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewOperations.BorderRadius = 10;
            this.pnlGridViewOperations.Controls.Add(this.btnAddToCart);
            this.pnlGridViewOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGridViewOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridViewOperations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.Location = new System.Drawing.Point(785, 100);
            this.pnlGridViewOperations.Name = "pnlGridViewOperations";
            this.pnlGridViewOperations.Size = new System.Drawing.Size(268, 490);
            this.pnlGridViewOperations.TabIndex = 10;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Animated = true;
            this.btnAddToCart.AnimatedGIF = true;
            this.btnAddToCart.AutoRoundedCorners = true;
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddToCart.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnAddToCart.Location = new System.Drawing.Point(51, 203);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(158, 45);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // gdvInventory
            // 
            this.gdvInventory.AllowUserToAddRows = false;
            this.gdvInventory.AllowUserToDeleteRows = false;
            this.gdvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvInventory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvInventory.ColumnHeadersHeight = 15;
            this.gdvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.category,
            this.price,
            this.cost,
            this.stock});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvInventory.Dock = System.Windows.Forms.DockStyle.Left;
            this.gdvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvInventory.Location = new System.Drawing.Point(0, 100);
            this.gdvInventory.Name = "gdvInventory";
            this.gdvInventory.ReadOnly = true;
            this.gdvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvInventory.RowHeadersVisible = false;
            this.gdvInventory.RowTemplate.Height = 25;
            this.gdvInventory.Size = new System.Drawing.Size(785, 490);
            this.gdvInventory.TabIndex = 11;
            this.gdvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.gdvInventory.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvInventory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvInventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.gdvInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvInventory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvInventory.ThemeStyle.HeaderStyle.Height = 15;
            this.gdvInventory.ThemeStyle.ReadOnly = true;
            this.gdvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvInventory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvInventory.ThemeStyle.RowsStyle.Height = 25;
            this.gdvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // productID
            // 
            this.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productID.FillWeight = 126.9036F;
            this.productID.Frozen = true;
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productID.Width = 90;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.FillWeight = 329.0299F;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category.FillWeight = 14.68883F;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.category.Width = 110;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.FillWeight = 14.68883F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.Width = 90;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stock.FillWeight = 14.68883F;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 50;
            // 
            // ucInventoryControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdvInventory);
            this.Controls.Add(this.pnlGridViewOperations);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ucInventoryControlEmployee";
            this.Size = new System.Drawing.Size(1053, 590);
            this.pnlSearch.ResumeLayout(false);
            this.pnlGridViewOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSearch;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGridViewOperations;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        internal Guna.UI2.WinForms.Guna2DataGridView gdvInventory;
    }
}
