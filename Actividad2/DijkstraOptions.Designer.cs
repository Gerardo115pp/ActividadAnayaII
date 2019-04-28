namespace Actividad2
{
    partial class DijkstraOptions
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
            this.BornUpDown = new System.Windows.Forms.NumericUpDown();
            this.BornLBL = new System.Windows.Forms.Label();
            this.DepredadorasLBL = new System.Windows.Forms.Label();
            this.DepredadoraUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinoUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkBTN = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BornUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepredadoraUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoUpDown)).BeginInit();
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
            this.ControlPanel.Size = new System.Drawing.Size(499, 41);
            this.ControlPanel.TabIndex = 2;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Russian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(183, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(143, 27);
            this.Title.TabIndex = 3;
            this.Title.Text = "D I J K S T R A";
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
            this.MainCloseBTN.Location = new System.Drawing.Point(431, 0);
            this.MainCloseBTN.Name = "MainCloseBTN";
            this.MainCloseBTN.Size = new System.Drawing.Size(68, 41);
            this.MainCloseBTN.TabIndex = 0;
            this.MainCloseBTN.Text = "X";
            this.MainCloseBTN.UseVisualStyleBackColor = false;
            // 
            // BornUpDown
            // 
            this.BornUpDown.AutoSize = true;
            this.BornUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BornUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BornUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.BornUpDown.Location = new System.Drawing.Point(277, 72);
            this.BornUpDown.Name = "BornUpDown";
            this.BornUpDown.Size = new System.Drawing.Size(56, 30);
            this.BornUpDown.TabIndex = 3;
            this.BornUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BornUpDown.ValueChanged += new System.EventHandler(this.dataChange);
            // 
            // BornLBL
            // 
            this.BornLBL.AutoSize = true;
            this.BornLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BornLBL.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornLBL.Location = new System.Drawing.Point(151, 72);
            this.BornLBL.Name = "BornLBL";
            this.BornLBL.Size = new System.Drawing.Size(120, 24);
            this.BornLBL.TabIndex = 4;
            this.BornLBL.Text = "NACIMIENTO";
            // 
            // DepredadorasLBL
            // 
            this.DepredadorasLBL.AutoSize = true;
            this.DepredadorasLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepredadorasLBL.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepredadorasLBL.Location = new System.Drawing.Point(129, 133);
            this.DepredadorasLBL.Name = "DepredadorasLBL";
            this.DepredadorasLBL.Size = new System.Drawing.Size(142, 24);
            this.DepredadorasLBL.TabIndex = 6;
            this.DepredadorasLBL.Text = "DEPREDADORAS";
            // 
            // DepredadoraUpDown
            // 
            this.DepredadoraUpDown.AutoSize = true;
            this.DepredadoraUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DepredadoraUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepredadoraUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepredadoraUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.DepredadoraUpDown.Location = new System.Drawing.Point(277, 133);
            this.DepredadoraUpDown.Name = "DepredadoraUpDown";
            this.DepredadoraUpDown.Size = new System.Drawing.Size(56, 30);
            this.DepredadoraUpDown.TabIndex = 5;
            this.DepredadoraUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepredadoraUpDown.ValueChanged += new System.EventHandler(this.dataChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "DESTINO";
            // 
            // DestinoUpDown
            // 
            this.DestinoUpDown.AutoSize = true;
            this.DestinoUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DestinoUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DestinoUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinoUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.DestinoUpDown.Location = new System.Drawing.Point(277, 194);
            this.DestinoUpDown.Name = "DestinoUpDown";
            this.DestinoUpDown.Size = new System.Drawing.Size(56, 30);
            this.DestinoUpDown.TabIndex = 7;
            this.DestinoUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DestinoUpDown.ValueChanged += new System.EventHandler(this.dataChange);
            // 
            // OkBTN
            // 
            this.OkBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBTN.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.OkBTN.Location = new System.Drawing.Point(241, 244);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(44, 39);
            this.OkBTN.TabIndex = 9;
            this.OkBTN.Text = "OK";
            this.OkBTN.UseVisualStyleBackColor = true;
            // 
            // DijkstraOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(499, 307);
            this.Controls.Add(this.OkBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinoUpDown);
            this.Controls.Add(this.DepredadorasLBL);
            this.Controls.Add(this.DepredadoraUpDown);
            this.Controls.Add(this.BornLBL);
            this.Controls.Add(this.BornUpDown);
            this.Controls.Add(this.ControlPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DijkstraOptions";
            this.Text = "DijkstraOptions";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BornUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepredadoraUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MainCloseBTN;
        private System.Windows.Forms.NumericUpDown BornUpDown;
        private System.Windows.Forms.Label BornLBL;
        private System.Windows.Forms.Label DepredadorasLBL;
        private System.Windows.Forms.NumericUpDown DepredadoraUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DestinoUpDown;
        private System.Windows.Forms.Button OkBTN;
    }
}