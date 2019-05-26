namespace Actividad2
{
    partial class PresaOptions
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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MainCloseBTN = new System.Windows.Forms.Button();
            this.DestinoLBL = new System.Windows.Forms.Label();
            this.DestinoUpDown = new System.Windows.Forms.NumericUpDown();
            this.BornLBL = new System.Windows.Forms.Label();
            this.OrigenUpDown = new System.Windows.Forms.NumericUpDown();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrigenUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ControlPanel.Controls.Add(this.Title);
            this.ControlPanel.Controls.Add(this.MainCloseBTN);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(496, 41);
            this.ControlPanel.TabIndex = 4;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Russian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.Title.Location = new System.Drawing.Point(207, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(94, 27);
            this.Title.TabIndex = 3;
            this.Title.Text = "PRESA 0 ";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseUp);
            // 
            // MainCloseBTN
            // 
            this.MainCloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MainCloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MainCloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainCloseBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(7)))));
            this.MainCloseBTN.FlatAppearance.BorderSize = 2;
            this.MainCloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.MainCloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.MainCloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainCloseBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCloseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(7)))));
            this.MainCloseBTN.Location = new System.Drawing.Point(428, 0);
            this.MainCloseBTN.Name = "MainCloseBTN";
            this.MainCloseBTN.Size = new System.Drawing.Size(68, 41);
            this.MainCloseBTN.TabIndex = 0;
            this.MainCloseBTN.Text = "X";
            this.MainCloseBTN.UseVisualStyleBackColor = false;
            // 
            // DestinoLBL
            // 
            this.DestinoLBL.AutoSize = true;
            this.DestinoLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestinoLBL.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinoLBL.Location = new System.Drawing.Point(176, 126);
            this.DestinoLBL.Name = "DestinoLBL";
            this.DestinoLBL.Size = new System.Drawing.Size(87, 24);
            this.DestinoLBL.TabIndex = 14;
            this.DestinoLBL.Text = "DESTINO";
            // 
            // DestinoUpDown
            // 
            this.DestinoUpDown.AutoSize = true;
            this.DestinoUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DestinoUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DestinoUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinoUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.DestinoUpDown.Location = new System.Drawing.Point(269, 126);
            this.DestinoUpDown.Name = "DestinoUpDown";
            this.DestinoUpDown.Size = new System.Drawing.Size(56, 30);
            this.DestinoUpDown.TabIndex = 13;
            this.DestinoUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DestinoUpDown.ValueChanged += new System.EventHandler(this.DestinoUpDown_ValueChanged);
            // 
            // BornLBL
            // 
            this.BornLBL.AutoSize = true;
            this.BornLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BornLBL.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornLBL.Location = new System.Drawing.Point(187, 71);
            this.BornLBL.Name = "BornLBL";
            this.BornLBL.Size = new System.Drawing.Size(76, 24);
            this.BornLBL.TabIndex = 12;
            this.BornLBL.Text = "ORIGEN";
            // 
            // OrigenUpDown
            // 
            this.OrigenUpDown.AutoSize = true;
            this.OrigenUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OrigenUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrigenUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrigenUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.OrigenUpDown.Location = new System.Drawing.Point(269, 65);
            this.OrigenUpDown.Name = "OrigenUpDown";
            this.OrigenUpDown.Size = new System.Drawing.Size(56, 30);
            this.OrigenUpDown.TabIndex = 11;
            this.OrigenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrigenUpDown.ValueChanged += new System.EventHandler(this.OrigenUpDown_ValueChanged);
            // 
            // PresaOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(496, 212);
            this.Controls.Add(this.DestinoLBL);
            this.Controls.Add(this.DestinoUpDown);
            this.Controls.Add(this.BornLBL);
            this.Controls.Add(this.OrigenUpDown);
            this.Controls.Add(this.ControlPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresaOptions";
            this.Text = "PresaOptions";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrigenUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MainCloseBTN;
        private System.Windows.Forms.Label DestinoLBL;
        private System.Windows.Forms.NumericUpDown DestinoUpDown;
        private System.Windows.Forms.Label BornLBL;
        private System.Windows.Forms.NumericUpDown OrigenUpDown;
    }
}