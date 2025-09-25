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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrandTotal = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.pnlGridViewOperations = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnClearCart = new Guna.UI2.WinForms.Guna2Button();
            this.cbtnMinus = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbtnPlus = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblAdjust = new System.Windows.Forms.Label();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.gdvCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGrandTotal.SuspendLayout();
            this.pnlGridViewOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrandTotal
            // 
            this.pnlGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.pnlGrandTotal.BorderRadius = 10;
            this.pnlGrandTotal.BorderThickness = 2;
            this.pnlGrandTotal.Controls.Add(this.lblAmount);
            this.pnlGrandTotal.Controls.Add(this.lblGrandTotal);
            this.pnlGrandTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGrandTotal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGrandTotal.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlGrandTotal.FillColor3 = System.Drawing.Color.WhiteSmoke;
            this.pnlGrandTotal.FillColor4 = System.Drawing.Color.WhiteSmoke;
            this.pnlGrandTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlGrandTotal.Name = "pnlGrandTotal";
            this.pnlGrandTotal.Size = new System.Drawing.Size(1053, 100);
            this.pnlGrandTotal.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(225, 28);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(38, 40);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "0";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(28, 34);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(191, 33);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "Grand Total:";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridViewOperations
            // 
            this.pnlGridViewOperations.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewOperations.BorderRadius = 10;
            this.pnlGridViewOperations.Controls.Add(this.btnClearCart);
            this.pnlGridViewOperations.Controls.Add(this.cbtnMinus);
            this.pnlGridViewOperations.Controls.Add(this.cbtnPlus);
            this.pnlGridViewOperations.Controls.Add(this.lblAdjust);
            this.pnlGridViewOperations.Controls.Add(this.btnRemove);
            this.pnlGridViewOperations.Controls.Add(this.btnCheckOut);
            this.pnlGridViewOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGridViewOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridViewOperations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.Location = new System.Drawing.Point(785, 100);
            this.pnlGridViewOperations.Name = "pnlGridViewOperations";
            this.pnlGridViewOperations.Size = new System.Drawing.Size(268, 490);
            this.pnlGridViewOperations.TabIndex = 11;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Animated = true;
            this.btnClearCart.AnimatedGIF = true;
            this.btnClearCart.AutoRoundedCorners = true;
            this.btnClearCart.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCart.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClearCart.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnClearCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCart.FillColor = System.Drawing.Color.Blue;
            this.btnClearCart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClearCart.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClearCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearCart.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnClearCart.Location = new System.Drawing.Point(50, 299);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(158, 45);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // cbtnMinus
            // 
            this.cbtnMinus.Animated = true;
            this.cbtnMinus.AnimatedGIF = true;
            this.cbtnMinus.BackColor = System.Drawing.Color.Transparent;
            this.cbtnMinus.BorderThickness = 1;
            this.cbtnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cbtnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cbtnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbtnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cbtnMinus.FillColor = System.Drawing.Color.Transparent;
            this.cbtnMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtnMinus.ForeColor = System.Drawing.Color.Transparent;
            this.cbtnMinus.Image = ((System.Drawing.Image)(resources.GetObject("cbtnMinus.Image")));
            this.cbtnMinus.Location = new System.Drawing.Point(153, 93);
            this.cbtnMinus.Name = "cbtnMinus";
            this.cbtnMinus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnMinus.Size = new System.Drawing.Size(39, 37);
            this.cbtnMinus.TabIndex = 6;
            this.cbtnMinus.Click += new System.EventHandler(this.cbtnMinus_Click);
            // 
            // cbtnPlus
            // 
            this.cbtnPlus.Animated = true;
            this.cbtnPlus.AnimatedGIF = true;
            this.cbtnPlus.BackColor = System.Drawing.Color.Transparent;
            this.cbtnPlus.BorderThickness = 1;
            this.cbtnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cbtnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cbtnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbtnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cbtnPlus.FillColor = System.Drawing.Color.Transparent;
            this.cbtnPlus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtnPlus.ForeColor = System.Drawing.Color.Transparent;
            this.cbtnPlus.Image = ((System.Drawing.Image)(resources.GetObject("cbtnPlus.Image")));
            this.cbtnPlus.Location = new System.Drawing.Point(61, 93);
            this.cbtnPlus.Name = "cbtnPlus";
            this.cbtnPlus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnPlus.Size = new System.Drawing.Size(39, 37);
            this.cbtnPlus.TabIndex = 5;
            this.cbtnPlus.Click += new System.EventHandler(this.cbtnPlus_Click);
            // 
            // lblAdjust
            // 
            this.lblAdjust.AutoSize = true;
            this.lblAdjust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblAdjust.Location = new System.Drawing.Point(47, 73);
            this.lblAdjust.Name = "lblAdjust";
            this.lblAdjust.Size = new System.Drawing.Size(168, 17);
            this.lblAdjust.TabIndex = 4;
            this.lblAdjust.Text = "Increase      Decrease";
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // gdvCart
            // 
            this.gdvCart.AllowUserToAddRows = false;
            this.gdvCart.AllowUserToDeleteRows = false;
            this.gdvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gdvCart.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdvCart.ColumnHeadersHeight = 15;
            this.gdvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.price,
            this.quantity,
            this.total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvCart.DefaultCellStyle = dataGridViewCellStyle7;
            this.gdvCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.gdvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvCart.Location = new System.Drawing.Point(0, 100);
            this.gdvCart.Name = "gdvCart";
            this.gdvCart.ReadOnly = true;
            this.gdvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 70;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // ucCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdvCart);
            this.Controls.Add(this.pnlGridViewOperations);
            this.Controls.Add(this.pnlGrandTotal);
            this.Name = "ucCart";
            this.Size = new System.Drawing.Size(1053, 590);
            this.pnlGrandTotal.ResumeLayout(false);
            this.pnlGrandTotal.PerformLayout();
            this.pnlGridViewOperations.ResumeLayout(false);
            this.pnlGridViewOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlGrandTotal;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGridViewOperations;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        internal Guna.UI2.WinForms.Guna2DataGridView gdvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label lblAdjust;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnPlus;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnMinus;
        private Guna.UI2.WinForms.Guna2Button btnClearCart;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}
