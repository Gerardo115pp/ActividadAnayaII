namespace Actividad2
{
    partial class DijkstraMultOptions
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
            this.DepredadorasLBL = new System.Windows.Forms.Label();
            this.DepredadoraUpDown = new System.Windows.Forms.NumericUpDown();
            this.BornLBL = new System.Windows.Forms.Label();
            this.PresasUpDown = new System.Windows.Forms.NumericUpDown();
            this.PresasListView = new System.Windows.Forms.ListView();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepredadoraUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresasUpDown)).BeginInit();
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
            this.ControlPanel.Size = new System.Drawing.Size(568, 41);
            this.ControlPanel.TabIndex = 3;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Russian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(114, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(304, 27);
            this.Title.TabIndex = 3;
            this.Title.Text = "D I J K S T R A      M U L T I P L E";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseUp);
            // 
            // MainCloseBTN
            // 
            this.MainCloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MainCloseBTN.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.MainCloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainCloseBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(7)))));
            this.MainCloseBTN.FlatAppearance.BorderSize = 2;
            this.MainCloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.MainCloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.MainCloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainCloseBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCloseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(7)))));
            this.MainCloseBTN.Location = new System.Drawing.Point(500, 0);
            this.MainCloseBTN.Name = "MainCloseBTN";
            this.MainCloseBTN.Size = new System.Drawing.Size(68, 41);
            this.MainCloseBTN.TabIndex = 0;
            this.MainCloseBTN.Text = "X";
            this.MainCloseBTN.UseVisualStyleBackColor = false;
            // 
            // DepredadorasLBL
            // 
            this.DepredadorasLBL.AutoSize = true;
            this.DepredadorasLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepredadorasLBL.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepredadorasLBL.Location = new System.Drawing.Point(126, 154);
            this.DepredadorasLBL.Name = "DepredadorasLBL";
            this.DepredadorasLBL.Size = new System.Drawing.Size(142, 24);
            this.DepredadorasLBL.TabIndex = 10;
            this.DepredadorasLBL.Text = "DEPREDADORAS";
            // 
            // DepredadoraUpDown
            // 
            this.DepredadoraUpDown.AutoSize = true;
            this.DepredadoraUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DepredadoraUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepredadoraUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepredadoraUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.DepredadoraUpDown.Location = new System.Drawing.Point(274, 154);
            this.DepredadoraUpDown.Name = "DepredadoraUpDown";
            this.DepredadoraUpDown.Size = new System.Drawing.Size(56, 30);
            this.DepredadoraUpDown.TabIndex = 9;
            this.DepredadoraUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepredadoraUpDown.ValueChanged += new System.EventHandler(this.DepredadoraUpDown_ValueChanged);
            this.DepredadoraUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PresasListView_KeyDown);
            // 
            // BornLBL
            // 
            this.BornLBL.AutoSize = true;
            this.BornLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BornLBL.Font = new System.Drawing.Font("Russian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornLBL.Location = new System.Drawing.Point(192, 99);
            this.BornLBL.Name = "BornLBL";
            this.BornLBL.Size = new System.Drawing.Size(76, 24);
            this.BornLBL.TabIndex = 8;
            this.BornLBL.Text = "PRESAS";
            // 
            // PresasUpDown
            // 
            this.PresasUpDown.AutoSize = true;
            this.PresasUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PresasUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PresasUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresasUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.PresasUpDown.Location = new System.Drawing.Point(274, 93);
            this.PresasUpDown.Name = "PresasUpDown";
            this.PresasUpDown.Size = new System.Drawing.Size(56, 30);
            this.PresasUpDown.TabIndex = 7;
            this.PresasUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PresasUpDown.ValueChanged += new System.EventHandler(this.PresasUpDown_ValueChanged);
            this.PresasUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PresasListView_KeyDown);
            // 
            // PresasListView
            // 
            this.PresasListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PresasListView.Font = new System.Drawing.Font("Russian", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresasListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.PresasListView.Location = new System.Drawing.Point(77, 201);
            this.PresasListView.Name = "PresasListView";
            this.PresasListView.Size = new System.Drawing.Size(410, 181);
            this.PresasListView.TabIndex = 11;
            this.PresasListView.UseCompatibleStateImageBehavior = false;
            this.PresasListView.ItemActivate += new System.EventHandler(this.PresasListView_ItemActivate);
            this.PresasListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PresasListView_KeyDown);
            // 
            // DijkstraMultOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.PresasListView);
            this.Controls.Add(this.DepredadorasLBL);
            this.Controls.Add(this.DepredadoraUpDown);
            this.Controls.Add(this.BornLBL);
            this.Controls.Add(this.PresasUpDown);
            this.Controls.Add(this.ControlPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DijkstraMultOptions";
            this.Text = "DijkstraMultOptions";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepredadoraUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresasUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MainCloseBTN;
        private System.Windows.Forms.Label DepredadorasLBL;
        private System.Windows.Forms.NumericUpDown DepredadoraUpDown;
        private System.Windows.Forms.Label BornLBL;
        private System.Windows.Forms.NumericUpDown PresasUpDown;
        private System.Windows.Forms.ListView PresasListView;
    }
}