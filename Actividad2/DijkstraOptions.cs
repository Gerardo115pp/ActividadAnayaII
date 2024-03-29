﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class DijkstraOptions : Form
    {
        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        int BornVex = 0,
            Depredadoras = 0,
            destiny = 0;
        public DijkstraOptions(int cant_vexs)
        {
            InitializeComponent();
            this.BornUpDown.Maximum = cant_vexs;
            this.DepredadoraUpDown.Maximum = cant_vexs-1;
            this.DestinoUpDown.Maximum = cant_vexs;
            this.DestinoUpDown.Value = cant_vexs;
        }

        public int Born
        {
            get
            {
                return this.BornVex;
            }
        }

        public int Predators
        {
            get
            {
                return this.Depredadoras;
            }
        }

        public int Destiny
        {
            get
            {
                return this.destiny;
            }
        }

        private void dataChange(object sender,EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            if (target.Name == "BornUpDown")
            {
                this.BornVex = (int)target.Value;
            }
            else if (target.Name == "DepredadoraUpDown")
            {
                this.Depredadoras = (int)target.Value;
            }
            else if (target.Name == "DestinoUpDown")
            {
                this.destiny = (int)target.Value;
            }
        }


        private void ControlesChange_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void ControlesChange_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ControlesChange_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

    }
}
