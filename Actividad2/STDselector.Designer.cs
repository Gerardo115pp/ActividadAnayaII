namespace Actividad2
{
    partial class STDselector
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
            this.ControlesChange = new System.Windows.Forms.Panel();
            this.CantLBL = new System.Windows.Forms.Label();
            this.ControlsCancel = new System.Windows.Forms.Button();
            this.CantUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ControlesChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlesChange
            // 
            this.ControlesChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ControlesChange.Controls.Add(this.CantLBL);
            this.ControlesChange.Controls.Add(this.ControlsCancel);
            this.ControlesChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlesChange.Location = new System.Drawing.Point(0, 0);
            this.ControlesChange.Name = "ControlesChange";
            this.ControlesChange.Size = new System.Drawing.Size(315, 35);
            this.ControlesChange.TabIndex = 1;
            this.ControlesChange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseDown);
            this.ControlesChange.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseMove);
            this.ControlesChange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlesChange_MouseUp);
            // 
            // CantLBL
            // 
            this.CantLBL.AutoSize = true;
            this.CantLBL.Font = new System.Drawing.Font("Russian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.CantLBL.Location = new System.Drawing.Point(44, 8);
            this.CantLBL.Name = "CantLBL";
            this.CantLBL.Size = new System.Drawing.Size(108, 18);
            this.CantLBL.TabIndex = 1;
            this.CantLBL.Text = "C a n t i d a d";
            // 
            // ControlsCancel
            // 
            this.ControlsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ControlsCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlsCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.ControlsCancel.FlatAppearance.BorderSize = 2;
            this.ControlsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlsCancel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlsCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(150)))), ((int)(((byte)(7)))));
            this.ControlsCancel.Location = new System.Drawing.Point(267, 0);
            this.ControlsCancel.Name = "ControlsCancel";
            this.ControlsCancel.Size = new System.Drawing.Size(48, 35);
            this.ControlsCancel.TabIndex = 0;
            this.ControlsCancel.Text = "X";
            this.ControlsCancel.UseVisualStyleBackColor = true;
            // 
            // CantUpDown
            // 
            this.CantUpDown.AutoSize = true;
            this.CantUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CantUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CantUpDown.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.CantUpDown.Location = new System.Drawing.Point(127, 99);
            this.CantUpDown.Name = "CantUpDown";
            this.CantUpDown.Size = new System.Drawing.Size(56, 30);
            this.CantUpDown.TabIndex = 4;
            this.CantUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantUpDown.ValueChanged += new System.EventHandler(this.dataChange);
            // 
            // OkBTN
            // 
            this.OkBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBTN.FlatAppearance.BorderSize = 0;
            this.OkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBTN.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.OkBTN.Location = new System.Drawing.Point(191, 153);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(44, 39);
            this.OkBTN.TabIndex = 3;
            this.OkBTN.Text = "OK";
            this.OkBTN.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.FlatAppearance.BorderSize = 0;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.CancelBTN.Location = new System.Drawing.Point(47, 153);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(79, 39);
            this.CancelBTN.TabIndex = 5;
            this.CancelBTN.Text = "Cancelar";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // STDselector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(315, 204);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.CantUpDown);
            this.Controls.Add(this.ControlesChange);
            this.Controls.Add(this.OkBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STDselector";
            this.Text = "STDselector";
            this.ControlesChange.ResumeLayout(false);
            this.ControlesChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlesChange;
        private System.Windows.Forms.Label CantLBL;
        private System.Windows.Forms.Button ControlsCancel;
        private System.Windows.Forms.NumericUpDown CantUpDown;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.Button CancelBTN;
    }
}