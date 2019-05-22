namespace Actividad2
{
    partial class Rutas
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
            this.Controls_panel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.RutasCloseBTN = new System.Windows.Forms.Button();
            this.Choices = new System.Windows.Forms.FlowLayoutPanel();
            this.Estandar = new System.Windows.Forms.RadioButton();
            this.op_kruskal = new System.Windows.Forms.RadioButton();
            this.op_prim = new System.Windows.Forms.RadioButton();
            this.DijkstraBTN = new System.Windows.Forms.RadioButton();
            this.arbolBSFbtn = new System.Windows.Forms.RadioButton();
            this.Controls_panel.SuspendLayout();
            this.Choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controls_panel
            // 
            this.Controls_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls_panel.Controls.Add(this.Title);
            this.Controls_panel.Controls.Add(this.RutasCloseBTN);
            this.Controls_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Controls_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.Controls_panel.Location = new System.Drawing.Point(0, 0);
            this.Controls_panel.Name = "Controls_panel";
            this.Controls_panel.Size = new System.Drawing.Size(577, 43);
            this.Controls_panel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Russian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(215, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(132, 27);
            this.Title.TabIndex = 4;
            this.Title.Text = "alg0ritm0s";
            // 
            // RutasCloseBTN
            // 
            this.RutasCloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.RutasCloseBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RutasCloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.RutasCloseBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(7)))));
            this.RutasCloseBTN.FlatAppearance.BorderSize = 2;
            this.RutasCloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.RutasCloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.RutasCloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RutasCloseBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutasCloseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(7)))));
            this.RutasCloseBTN.Location = new System.Drawing.Point(509, 0);
            this.RutasCloseBTN.Name = "RutasCloseBTN";
            this.RutasCloseBTN.Size = new System.Drawing.Size(68, 43);
            this.RutasCloseBTN.TabIndex = 1;
            this.RutasCloseBTN.Text = "X";
            this.RutasCloseBTN.UseVisualStyleBackColor = false;
            this.RutasCloseBTN.Click += new System.EventHandler(this.RutasCloseBTN_Click);
            // 
            // Choices
            // 
            this.Choices.AutoSize = true;
            this.Choices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Choices.Controls.Add(this.Estandar);
            this.Choices.Controls.Add(this.op_kruskal);
            this.Choices.Controls.Add(this.op_prim);
            this.Choices.Controls.Add(this.DijkstraBTN);
            this.Choices.Controls.Add(this.arbolBSFbtn);
            this.Choices.Font = new System.Drawing.Font("Fatherland Faker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choices.Location = new System.Drawing.Point(55, 110);
            this.Choices.Name = "Choices";
            this.Choices.Size = new System.Drawing.Size(453, 39);
            this.Choices.TabIndex = 1;
            // 
            // Estandar
            // 
            this.Estandar.Appearance = System.Windows.Forms.Appearance.Button;
            this.Estandar.AutoSize = true;
            this.Estandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estandar.Font = new System.Drawing.Font("Russian Dollmaker", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estandar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(8)))));
            this.Estandar.Location = new System.Drawing.Point(3, 3);
            this.Estandar.Name = "Estandar";
            this.Estandar.Size = new System.Drawing.Size(86, 33);
            this.Estandar.TabIndex = 1;
            this.Estandar.TabStop = true;
            this.Estandar.Text = "Random";
            this.Estandar.UseVisualStyleBackColor = false;
            this.Estandar.CheckedChanged += new System.EventHandler(this.op_kruskal_CheckedChanged);
            // 
            // op_kruskal
            // 
            this.op_kruskal.Appearance = System.Windows.Forms.Appearance.Button;
            this.op_kruskal.AutoSize = true;
            this.op_kruskal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.op_kruskal.Font = new System.Drawing.Font("Russian Dollmaker", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_kruskal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(8)))));
            this.op_kruskal.Location = new System.Drawing.Point(95, 3);
            this.op_kruskal.Name = "op_kruskal";
            this.op_kruskal.Size = new System.Drawing.Size(86, 33);
            this.op_kruskal.TabIndex = 0;
            this.op_kruskal.TabStop = true;
            this.op_kruskal.Text = "Kruskal";
            this.op_kruskal.UseVisualStyleBackColor = false;
            this.op_kruskal.CheckedChanged += new System.EventHandler(this.op_kruskal_CheckedChanged);
            // 
            // op_prim
            // 
            this.op_prim.Appearance = System.Windows.Forms.Appearance.Button;
            this.op_prim.AutoSize = true;
            this.op_prim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.op_prim.Font = new System.Drawing.Font("Russian Dollmaker", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_prim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(8)))));
            this.op_prim.Location = new System.Drawing.Point(187, 3);
            this.op_prim.Name = "op_prim";
            this.op_prim.Size = new System.Drawing.Size(61, 33);
            this.op_prim.TabIndex = 2;
            this.op_prim.TabStop = true;
            this.op_prim.Text = "prim";
            this.op_prim.UseVisualStyleBackColor = false;
            this.op_prim.CheckedChanged += new System.EventHandler(this.op_kruskal_CheckedChanged);
            // 
            // DijkstraBTN
            // 
            this.DijkstraBTN.Appearance = System.Windows.Forms.Appearance.Button;
            this.DijkstraBTN.AutoSize = true;
            this.DijkstraBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DijkstraBTN.Font = new System.Drawing.Font("Russian Dollmaker", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DijkstraBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(8)))));
            this.DijkstraBTN.Location = new System.Drawing.Point(254, 3);
            this.DijkstraBTN.Name = "DijkstraBTN";
            this.DijkstraBTN.Size = new System.Drawing.Size(92, 33);
            this.DijkstraBTN.TabIndex = 3;
            this.DijkstraBTN.TabStop = true;
            this.DijkstraBTN.Text = "Dijkstra";
            this.DijkstraBTN.UseVisualStyleBackColor = false;
            this.DijkstraBTN.CheckedChanged += new System.EventHandler(this.op_kruskal_CheckedChanged);
            // 
            // arbolBSFbtn
            // 
            this.arbolBSFbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.arbolBSFbtn.AutoSize = true;
            this.arbolBSFbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.arbolBSFbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arbolBSFbtn.Font = new System.Drawing.Font("Russian Dollmaker", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arbolBSFbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(8)))));
            this.arbolBSFbtn.Location = new System.Drawing.Point(352, 3);
            this.arbolBSFbtn.Name = "arbolBSFbtn";
            this.arbolBSFbtn.Size = new System.Drawing.Size(98, 33);
            this.arbolBSFbtn.TabIndex = 4;
            this.arbolBSFbtn.TabStop = true;
            this.arbolBSFbtn.Text = "ARBOL BSF";
            this.arbolBSFbtn.UseVisualStyleBackColor = false;
            this.arbolBSFbtn.CheckedChanged += new System.EventHandler(this.op_kruskal_CheckedChanged);
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(577, 240);
            this.Controls.Add(this.Choices);
            this.Controls.Add(this.Controls_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rutas";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Rutas_Load);
            this.Controls_panel.ResumeLayout(false);
            this.Controls_panel.PerformLayout();
            this.Choices.ResumeLayout(false);
            this.Choices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Controls_panel;
        private System.Windows.Forms.Button RutasCloseBTN;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel Choices;
        private System.Windows.Forms.RadioButton op_kruskal;
        private System.Windows.Forms.RadioButton Estandar;
        private System.Windows.Forms.RadioButton op_prim;
        private System.Windows.Forms.RadioButton DijkstraBTN;
        private System.Windows.Forms.RadioButton arbolBSFbtn;
    }
}