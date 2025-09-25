﻿namespace SiliconSource
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.gunaEmployeeDashboard = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMoto = new System.Windows.Forms.Label();
            this.lblSiliconSource = new System.Windows.Forms.Label();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnCart = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBody = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlHeading = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gunaSeperator = new Guna.UI2.WinForms.Guna2Separator();
            this.lblRole = new System.Windows.Forms.Label();
            this.pbEmployee = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaEmployeeDashboard
            // 
            this.gunaEmployeeDashboard.AnimateWindow = true;
            this.gunaEmployeeDashboard.BorderRadius = 10;
            this.gunaEmployeeDashboard.ContainerControl = this;
            this.gunaEmployeeDashboard.DockIndicatorTransparencyValue = 0.6D;
            this.gunaEmployeeDashboard.ResizeForm = false;
            this.gunaEmployeeDashboard.TransparentWhileDrag = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.lblMoto);
            this.pnlLogo.Controls.Add(this.lblSiliconSource);
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlLogo.Location = new System.Drawing.Point(10, 28);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 190);
            this.pnlLogo.TabIndex = 3;
            // 
            // lblMoto
            // 
            this.lblMoto.AutoSize = true;
            this.lblMoto.BackColor = System.Drawing.Color.Transparent;
            this.lblMoto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoto.ForeColor = System.Drawing.Color.Black;
            this.lblMoto.Location = new System.Drawing.Point(20, 153);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(154, 34);
            this.lblMoto.TabIndex = 5;
            this.lblMoto.Text = "One Stop\r\nElectronics Solution\r\n";
            // 
            // lblSiliconSource
            // 
            this.lblSiliconSource.AutoSize = true;
            this.lblSiliconSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSiliconSource.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiliconSource.ForeColor = System.Drawing.Color.Black;
            this.lblSiliconSource.Location = new System.Drawing.Point(19, 111);
            this.lblSiliconSource.Name = "lblSiliconSource";
            this.lblSiliconSource.Size = new System.Drawing.Size(158, 24);
            this.lblSiliconSource.TabIndex = 3;
            this.lblSiliconSource.Text = "Silicon Source";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BorderRadius = 10;
            this.pbLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.ErrorImage")));
            this.pbLogo.FillColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(46, 8);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 99);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            this.pbLogo.UseTransparentBackground = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderRadius = 10;
            this.pnlMenu.BorderThickness = 1;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.rbtnCart);
            this.pnlMenu.Controls.Add(this.rbtnInventory);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.Location = new System.Drawing.Point(10, 10);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 700);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AnimatedGIF = true;
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnLogout.Location = new System.Drawing.Point(9, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // rbtnCart
            // 
            this.rbtnCart.Animated = true;
            this.rbtnCart.AnimatedGIF = true;
            this.rbtnCart.AutoRoundedCorners = true;
            this.rbtnCart.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCart.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnCart.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbtnCart.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.rbtnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rbtnCart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCart.ForeColor = System.Drawing.Color.White;
            this.rbtnCart.HoverState.FillColor = System.Drawing.Color.White;
            this.rbtnCart.HoverState.ForeColor = System.Drawing.Color.Black;
            this.rbtnCart.Image = ((System.Drawing.Image)(resources.GetObject("rbtnCart.Image")));
            this.rbtnCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rbtnCart.ImageOffset = new System.Drawing.Point(20, 0);
            this.rbtnCart.Location = new System.Drawing.Point(9, 415);
            this.rbtnCart.Name = "rbtnCart";
            this.rbtnCart.Size = new System.Drawing.Size(180, 45);
            this.rbtnCart.TabIndex = 2;
            this.rbtnCart.Text = "Cart";
            // 
            // rbtnInventory
            // 
            this.rbtnInventory.Animated = true;
            this.rbtnInventory.AnimatedGIF = true;
            this.rbtnInventory.AutoRoundedCorners = true;
            this.rbtnInventory.BackColor = System.Drawing.Color.Transparent;
            this.rbtnInventory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnInventory.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbtnInventory.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.rbtnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rbtnInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInventory.ForeColor = System.Drawing.Color.White;
            this.rbtnInventory.HoverState.FillColor = System.Drawing.Color.White;
            this.rbtnInventory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.rbtnInventory.Image = ((System.Drawing.Image)(resources.GetObject("rbtnInventory.Image")));
            this.rbtnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rbtnInventory.ImageOffset = new System.Drawing.Point(20, 0);
            this.rbtnInventory.Location = new System.Drawing.Point(9, 350);
            this.rbtnInventory.Name = "rbtnInventory";
            this.rbtnInventory.Size = new System.Drawing.Size(180, 45);
            this.rbtnInventory.TabIndex = 2;
            this.rbtnInventory.Text = "Inventory";
            this.rbtnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rbtnInventory.TextOffset = new System.Drawing.Point(-12, 0);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBody.BorderRadius = 10;
            this.pnlBody.BorderThickness = 1;
            this.pnlBody.Controls.Add(this.pnlGrid);
            this.pnlBody.Controls.Add(this.pnlHeading);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.FillColor = System.Drawing.Color.White;
            this.pnlBody.FillColor2 = System.Drawing.Color.White;
            this.pnlBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBody.Location = new System.Drawing.Point(210, 10);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnlBody.Size = new System.Drawing.Size(1060, 700);
            this.pnlBody.TabIndex = 4;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(2, 100);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1056, 600);
            this.pnlGrid.TabIndex = 2;
            // 
            // pnlHeading
            // 
            this.pnlHeading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pnlHeading.BorderRadius = 10;
            this.pnlHeading.BorderThickness = 2;
            this.pnlHeading.Controls.Add(this.gunaSeperator);
            this.pnlHeading.Controls.Add(this.lblRole);
            this.pnlHeading.Controls.Add(this.pbEmployee);
            this.pnlHeading.Controls.Add(this.lblName);
            this.pnlHeading.Controls.Add(this.lblTitle);
            this.pnlHeading.Controls.Add(this.btnExit);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeading.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlHeading.FillColor3 = System.Drawing.Color.WhiteSmoke;
            this.pnlHeading.FillColor4 = System.Drawing.Color.WhiteSmoke;
            this.pnlHeading.Location = new System.Drawing.Point(2, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Padding = new System.Windows.Forms.Padding(10);
            this.pnlHeading.Size = new System.Drawing.Size(1056, 100);
            this.pnlHeading.TabIndex = 1;
            // 
            // gunaSeperator
            // 
            this.gunaSeperator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.gunaSeperator.Location = new System.Drawing.Point(815, 82);
            this.gunaSeperator.Name = "gunaSeperator";
            this.gunaSeperator.Size = new System.Drawing.Size(130, 10);
            this.gunaSeperator.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblRole.Location = new System.Drawing.Point(886, 66);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 14);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Employee";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pbEmployee.BorderRadius = 10;
            this.pbEmployee.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbEmployee.ErrorImage")));
            this.pbEmployee.FillColor = System.Drawing.Color.Transparent;
            this.pbEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployee.Image")));
            this.pbEmployee.ImageRotate = 0F;
            this.pbEmployee.Location = new System.Drawing.Point(807, 30);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(73, 50);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmployee.TabIndex = 5;
            this.pbEmployee.TabStop = false;
            this.pbEmployee.UseTransparentBackground = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(885, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Alex";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExit.Location = new System.Drawing.Point(1007, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeDashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gunaEmployeeDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.Label lblSiliconSource;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button rbtnCart;
        private Guna.UI2.WinForms.Guna2Button rbtnInventory;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBody;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlHeading;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2PictureBox pbEmployee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlGrid;
        private Guna.UI2.WinForms.Guna2Separator gunaSeperator;
    }
}