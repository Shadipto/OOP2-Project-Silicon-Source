namespace SiliconSource
{
    partial class ucEmployeeControlManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployeeControlManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlGridViewOperations = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.gdvEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch.SuspendLayout();
            this.pnlGridViewOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).BeginInit();
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
            // pnlGridViewOperations
            // 
            this.pnlGridViewOperations.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewOperations.BorderRadius = 10;
            this.pnlGridViewOperations.Controls.Add(this.btnPrint);
            this.pnlGridViewOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGridViewOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridViewOperations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlGridViewOperations.Location = new System.Drawing.Point(786, 100);
            this.pnlGridViewOperations.Name = "pnlGridViewOperations";
            this.pnlGridViewOperations.Size = new System.Drawing.Size(267, 490);
            this.pnlGridViewOperations.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.AnimatedGIF = true;
            this.btnPrint.AutoRoundedCorners = true;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPrint.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrint.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnPrint.Location = new System.Drawing.Point(50, 213);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(158, 45);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Details";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gdvEmployee
            // 
            this.gdvEmployee.AllowUserToAddRows = false;
            this.gdvEmployee.AllowUserToDeleteRows = false;
            this.gdvEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gdvEmployee.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdvEmployee.ColumnHeadersHeight = 15;
            this.gdvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.employeeName,
            this.role,
            this.salary});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvEmployee.DefaultCellStyle = dataGridViewCellStyle7;
            this.gdvEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.gdvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvEmployee.Location = new System.Drawing.Point(0, 100);
            this.gdvEmployee.Name = "gdvEmployee";
            this.gdvEmployee.ReadOnly = true;
            this.gdvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gdvEmployee.RowHeadersVisible = false;
            this.gdvEmployee.RowTemplate.Height = 25;
            this.gdvEmployee.Size = new System.Drawing.Size(786, 490);
            this.gdvEmployee.TabIndex = 12;
            this.gdvEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.gdvEmployee.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.gdvEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvEmployee.ThemeStyle.HeaderStyle.Height = 15;
            this.gdvEmployee.ThemeStyle.ReadOnly = true;
            this.gdvEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvEmployee.ThemeStyle.RowsStyle.Height = 25;
            this.gdvEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdvEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // employeeID
            // 
            this.employeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.employeeID.FillWeight = 126.9036F;
            this.employeeID.Frozen = true;
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeID.Width = 90;
            // 
            // employeeName
            // 
            this.employeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeName.FillWeight = 329.0299F;
            this.employeeName.HeaderText = "Employee Name";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.role.FillWeight = 14.68883F;
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.role.Width = 110;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salary.FillWeight = 14.68883F;
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salary.Width = 90;
            // 
            // ucEmployeeControlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdvEmployee);
            this.Controls.Add(this.pnlGridViewOperations);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ucEmployeeControlManager";
            this.Size = new System.Drawing.Size(1053, 590);
            this.pnlSearch.ResumeLayout(false);
            this.pnlGridViewOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSearch;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGridViewOperations;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        internal Guna.UI2.WinForms.Guna2DataGridView gdvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
