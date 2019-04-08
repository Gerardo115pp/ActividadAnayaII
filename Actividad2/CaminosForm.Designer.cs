namespace Actividad2
{
    partial class CaminosForm
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
            this.PictureCaminos = new System.Windows.Forms.PictureBox();
            this.AgentesLista = new System.Windows.Forms.ListBox();
            this.TituloAgentes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TituloAristas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AristasList = new System.Windows.Forms.ListBox();
            this.DistLBL = new System.Windows.Forms.Label();
            this.VisitadosLBL = new System.Windows.Forms.Label();
            this.VerticiesCB = new System.Windows.Forms.ComboBox();
            this.Controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCaminos)).BeginInit();
            this.TituloAgentes.SuspendLayout();
            this.TituloAristas.SuspendLayout();
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
            this.Controles.Size = new System.Drawing.Size(890, 53);
            this.Controles.TabIndex = 0;
            this.Controles.Paint += new System.Windows.Forms.PaintEventHandler(this.Controles_Paint);
            this.Controles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseDown);
            this.Controles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseMove);
            this.Controles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russian", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(384, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "C A M I N O S";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.CloseBTN.FlatAppearance.BorderSize = 2;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(130)))), ((int)(((byte)(10)))));
            this.CloseBTN.Location = new System.Drawing.Point(824, 0);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(66, 53);
            this.CloseBTN.TabIndex = 0;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // PictureCaminos
            // 
            this.PictureCaminos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.PictureCaminos.Location = new System.Drawing.Point(31, 73);
            this.PictureCaminos.Name = "PictureCaminos";
            this.PictureCaminos.Size = new System.Drawing.Size(554, 387);
            this.PictureCaminos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureCaminos.TabIndex = 1;
            this.PictureCaminos.TabStop = false;
            // 
            // AgentesLista
            // 
            this.AgentesLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.AgentesLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgentesLista.Font = new System.Drawing.Font("Russian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentesLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.AgentesLista.FormattingEnabled = true;
            this.AgentesLista.ItemHeight = 17;
            this.AgentesLista.Location = new System.Drawing.Point(630, 320);
            this.AgentesLista.Name = "AgentesLista";
            this.AgentesLista.Size = new System.Drawing.Size(228, 136);
            this.AgentesLista.TabIndex = 2;
            this.AgentesLista.SelectedIndexChanged += new System.EventHandler(this.AgentesLista_SelectedIndexChanged);
            // 
            // TituloAgentes
            // 
            this.TituloAgentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TituloAgentes.Controls.Add(this.label2);
            this.TituloAgentes.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloAgentes.Location = new System.Drawing.Point(630, 289);
            this.TituloAgentes.Name = "TituloAgentes";
            this.TituloAgentes.Size = new System.Drawing.Size(228, 28);
            this.TituloAgentes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.label2.Location = new System.Drawing.Point(88, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "AGENTES";
            // 
            // TituloAristas
            // 
            this.TituloAristas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TituloAristas.Controls.Add(this.label3);
            this.TituloAristas.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloAristas.Location = new System.Drawing.Point(630, 73);
            this.TituloAristas.Name = "TituloAristas";
            this.TituloAristas.Size = new System.Drawing.Size(225, 28);
            this.TituloAristas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(88, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "CAMINO";
            // 
            // AristasList
            // 
            this.AristasList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.AristasList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AristasList.Font = new System.Drawing.Font("Open Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AristasList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.AristasList.FormattingEnabled = true;
            this.AristasList.ItemHeight = 20;
            this.AristasList.Location = new System.Drawing.Point(630, 99);
            this.AristasList.Name = "AristasList";
            this.AristasList.Size = new System.Drawing.Size(225, 100);
            this.AristasList.TabIndex = 5;
            // 
            // DistLBL
            // 
            this.DistLBL.AutoSize = true;
            this.DistLBL.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.DistLBL.Location = new System.Drawing.Point(626, 210);
            this.DistLBL.Name = "DistLBL";
            this.DistLBL.Size = new System.Drawing.Size(149, 22);
            this.DistLBL.TabIndex = 6;
            this.DistLBL.Text = "Distancia: None";
            // 
            // VisitadosLBL
            // 
            this.VisitadosLBL.AutoSize = true;
            this.VisitadosLBL.Font = new System.Drawing.Font("Russian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitadosLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.VisitadosLBL.Location = new System.Drawing.Point(626, 236);
            this.VisitadosLBL.Name = "VisitadosLBL";
            this.VisitadosLBL.Size = new System.Drawing.Size(119, 22);
            this.VisitadosLBL.TabIndex = 7;
            this.VisitadosLBL.Text = "Visito: None";
            // 
            // VerticiesCB
            // 
            this.VerticiesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.VerticiesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerticiesCB.Font = new System.Drawing.Font("Russian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerticiesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.VerticiesCB.FormattingEnabled = true;
            this.VerticiesCB.Location = new System.Drawing.Point(630, 262);
            this.VerticiesCB.Name = "VerticiesCB";
            this.VerticiesCB.Size = new System.Drawing.Size(225, 23);
            this.VerticiesCB.TabIndex = 8;
            // 
            // CaminosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(890, 494);
            this.Controls.Add(this.VerticiesCB);
            this.Controls.Add(this.VisitadosLBL);
            this.Controls.Add(this.DistLBL);
            this.Controls.Add(this.AristasList);
            this.Controls.Add(this.TituloAristas);
            this.Controls.Add(this.TituloAgentes);
            this.Controls.Add(this.AgentesLista);
            this.Controls.Add(this.PictureCaminos);
            this.Controls.Add(this.Controles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CaminosForm";
            this.Text = "CaminosForm";
            this.Load += new System.EventHandler(this.CaminosForm_Load);
            this.Controles.ResumeLayout(false);
            this.Controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCaminos)).EndInit();
            this.TituloAgentes.ResumeLayout(false);
            this.TituloAgentes.PerformLayout();
            this.TituloAristas.ResumeLayout(false);
            this.TituloAristas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Controles;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureCaminos;
        private System.Windows.Forms.ListBox AgentesLista;
        private System.Windows.Forms.Panel TituloAgentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel TituloAristas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AristasList;
        private System.Windows.Forms.Label DistLBL;
        private System.Windows.Forms.Label VisitadosLBL;
        private System.Windows.Forms.ComboBox VerticiesCB;
    }
}