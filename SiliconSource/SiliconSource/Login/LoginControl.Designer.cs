namespace SiliconSource
{
    partial class LoginControl
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
            this.components = new System.ComponentModel.Container();
            this.pnlLoginTextbox = new Guna.UI2.WinForms.Guna2Panel();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlLoginTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginTextbox
            // 
            this.pnlLoginTextbox.BackColor = System.Drawing.Color.White;
            this.pnlLoginTextbox.Controls.Add(this.txtInfo);
            this.pnlLoginTextbox.Controls.Add(this.lblText);
            this.pnlLoginTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginTextbox.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginTextbox.Name = "pnlLoginTextbox";
            this.pnlLoginTextbox.Size = new System.Drawing.Size(349, 68);
            this.pnlLoginTextbox.TabIndex = 0;
            this.pnlLoginTextbox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLoginTextbox_Paint);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInfo.Location = new System.Drawing.Point(3, 39);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(333, 18);
            this.txtInfo.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblText.Location = new System.Drawing.Point(-1, 14);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(52, 17);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "label1";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.pnlLoginTextbox);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(349, 71);
            this.pnlLoginTextbox.ResumeLayout(false);
            this.pnlLoginTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLoginTextbox;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
