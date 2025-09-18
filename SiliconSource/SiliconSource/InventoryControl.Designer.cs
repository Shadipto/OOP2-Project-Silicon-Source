namespace SiliconSource
{
    partial class InventoryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControl));
            this.pnlGridView = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGridView
            // 
            this.pnlGridView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridView.BorderRadius = 10;
            this.pnlGridView.BorderThickness = 2;
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGridView.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlGridView.FillColor3 = System.Drawing.Color.WhiteSmoke;
            this.pnlGridView.FillColor4 = System.Drawing.Color.WhiteSmoke;
            this.pnlGridView.Location = new System.Drawing.Point(0, 100);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGridView.Size = new System.Drawing.Size(1053, 490);
            this.pnlGridView.TabIndex = 8;
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
            this.pnlSearch.TabIndex = 7;
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
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.pnlSearch);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(1053, 590);
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlGridView;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSearch;
    }
}
