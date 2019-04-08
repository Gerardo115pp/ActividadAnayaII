namespace Actividad2
{
    partial class DescribePK
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
            this.Controles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.KruskalLista = new System.Windows.Forms.ListBox();
            this.PrimList = new System.Windows.Forms.ListBox();
            this.TituloAgentes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tkruskal = new System.Windows.Forms.Label();
            this.Tprim = new System.Windows.Forms.Label();
            this.Controles.SuspendLayout();
            this.TituloAgentes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controles
            // 
            this.Controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controles.Controls.Add(this.label1);
            this.Controles.Controls.Add(this.CloseBTN);
            this.Controles.Dock = System.Windows.Forms.DockStyle.Top;
            this.Controles.Font = new System.Drawing.Font("Russian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controles.Location = new System.Drawing.Point(0, 0);
            this.Controles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(800, 53);
            this.Controles.TabIndex = 1;
            this.Controles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseDown);
            this.Controles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseMove);
            this.Controles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russian", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(294, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "D E S C R I P C I O N";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.CloseBTN.FlatAppearance.BorderSize = 2;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(130)))), ((int)(((byte)(10)))));
            this.CloseBTN.Location = new System.Drawing.Point(734, 0);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(66, 53);
            this.CloseBTN.TabIndex = 0;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // KruskalLista
            // 
            this.KruskalLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.KruskalLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KruskalLista.Font = new System.Drawing.Font("Russian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KruskalLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.KruskalLista.FormattingEnabled = true;
            this.KruskalLista.ItemHeight = 17;
            this.KruskalLista.Location = new System.Drawing.Point(112, 184);
            this.KruskalLista.Name = "KruskalLista";
            this.KruskalLista.Size = new System.Drawing.Size(228, 136);
            this.KruskalLista.TabIndex = 3;
            // 
            // PrimList
            // 
            this.PrimList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.PrimList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrimList.Font = new System.Drawing.Font("Russian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.PrimList.FormattingEnabled = true;
            this.PrimList.ItemHeight = 17;
            this.PrimList.Location = new System.Drawing.Point(450, 184);
            this.PrimList.Name = "PrimList";
            this.PrimList.Size = new System.Drawing.Size(228, 136);
            this.PrimList.TabIndex = 4;
            // 
            // TituloAgentes
            // 
            this.TituloAgentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TituloAgentes.Controls.Add(this.label2);
            this.TituloAgentes.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloAgentes.Location = new System.Drawing.Point(112, 154);
            this.TituloAgentes.Margin = new System.Windows.Forms.Padding(0);
            this.TituloAgentes.Name = "TituloAgentes";
            this.TituloAgentes.Size = new System.Drawing.Size(228, 28);
            this.TituloAgentes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.label2.Location = new System.Drawing.Point(88, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "KRUSKAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(450, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 28);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(88, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "PRIM";
            // 
            // Tkruskal
            // 
            this.Tkruskal.AutoSize = true;
            this.Tkruskal.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tkruskal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.Tkruskal.Location = new System.Drawing.Point(117, 339);
            this.Tkruskal.Name = "Tkruskal";
            this.Tkruskal.Size = new System.Drawing.Size(120, 18);
            this.Tkruskal.TabIndex = 1;
            this.Tkruskal.Text = "Total (KRUSKAL): ";
            // 
            // Tprim
            // 
            this.Tprim.AutoSize = true;
            this.Tprim.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tprim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.Tprim.Location = new System.Drawing.Point(459, 339);
            this.Tprim.Name = "Tprim";
            this.Tprim.Size = new System.Drawing.Size(93, 18);
            this.Tprim.TabIndex = 7;
            this.Tprim.Text = "Total (PRIM): ";
            // 
            // DescribePK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tprim);
            this.Controls.Add(this.Tkruskal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TituloAgentes);
            this.Controls.Add(this.PrimList);
            this.Controls.Add(this.KruskalLista);
            this.Controls.Add(this.Controles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescribePK";
            this.Text = "DescribePK";
            this.Controles.ResumeLayout(false);
            this.Controles.PerformLayout();
            this.TituloAgentes.ResumeLayout(false);
            this.TituloAgentes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Controles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.ListBox KruskalLista;
        private System.Windows.Forms.ListBox PrimList;
        private System.Windows.Forms.Panel TituloAgentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tkruskal;
        private System.Windows.Forms.Label Tprim;
    }
}