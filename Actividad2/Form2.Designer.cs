namespace Actividad2
{
    partial class Arbol_From
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
            this.Arbol_Controls = new System.Windows.Forms.Panel();
            this.CloseArbolBTN = new System.Windows.Forms.Button();
            this.Arbolbody = new System.Windows.Forms.Panel();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.ArbolLABEL = new System.Windows.Forms.Label();
            this.Arbol_Controls.SuspendLayout();
            this.Arbolbody.SuspendLayout();
            this.SuspendLayout();
            // 
            // Arbol_Controls
            // 
            this.Arbol_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Arbol_Controls.Controls.Add(this.ArbolLABEL);
            this.Arbol_Controls.Controls.Add(this.CloseArbolBTN);
            this.Arbol_Controls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arbol_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.Arbol_Controls.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arbol_Controls.Location = new System.Drawing.Point(0, 0);
            this.Arbol_Controls.Name = "Arbol_Controls";
            this.Arbol_Controls.Size = new System.Drawing.Size(529, 55);
            this.Arbol_Controls.TabIndex = 0;
            this.Arbol_Controls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arbol_Controls_MouseDown);
            this.Arbol_Controls.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Arbol_Controls_MouseMove);
            this.Arbol_Controls.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Arbol_Controls_MouseUp);
            // 
            // CloseArbolBTN
            // 
            this.CloseArbolBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseArbolBTN.FlatAppearance.BorderSize = 0;
            this.CloseArbolBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CloseArbolBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseArbolBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseArbolBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.CloseArbolBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(7)))));
            this.CloseArbolBTN.Location = new System.Drawing.Point(460, 0);
            this.CloseArbolBTN.Name = "CloseArbolBTN";
            this.CloseArbolBTN.Size = new System.Drawing.Size(69, 55);
            this.CloseArbolBTN.TabIndex = 0;
            this.CloseArbolBTN.Text = "X";
            this.CloseArbolBTN.UseVisualStyleBackColor = true;
            this.CloseArbolBTN.Click += new System.EventHandler(this.CloseArbolBTN_Click);
            // 
            // Arbolbody
            // 
            this.Arbolbody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Arbolbody.Controls.Add(this.TreeView);
            this.Arbolbody.Location = new System.Drawing.Point(12, 41);
            this.Arbolbody.Name = "Arbolbody";
            this.Arbolbody.Size = new System.Drawing.Size(505, 397);
            this.Arbolbody.TabIndex = 1;
            // 
            // TreeView
            // 
            this.TreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeView.Font = new System.Drawing.Font("Fatherland Faker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.TreeView.Location = new System.Drawing.Point(80, 63);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(336, 331);
            this.TreeView.TabIndex = 0;
            // 
            // ArbolLABEL
            // 
            this.ArbolLABEL.AutoSize = true;
            this.ArbolLABEL.Font = new System.Drawing.Font("Russian", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArbolLABEL.Location = new System.Drawing.Point(207, 9);
            this.ArbolLABEL.Name = "ArbolLABEL";
            this.ArbolLABEL.Size = new System.Drawing.Size(95, 35);
            this.ArbolLABEL.TabIndex = 1;
            this.ArbolLABEL.Text = "Arbol";
            // 
            // Arbol_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.Arbol_Controls);
            this.Controls.Add(this.Arbolbody);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(529, 450);
            this.MinimumSize = new System.Drawing.Size(529, 450);
            this.Name = "Arbol_From";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.Text = "Arbol";
            this.Arbol_Controls.ResumeLayout(false);
            this.Arbol_Controls.PerformLayout();
            this.Arbolbody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Arbol_Controls;
        private System.Windows.Forms.Button CloseArbolBTN;
        private System.Windows.Forms.Panel Arbolbody;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Label ArbolLABEL;
    }
}