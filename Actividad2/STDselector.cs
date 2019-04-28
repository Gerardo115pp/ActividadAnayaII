using System;
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
    public partial class STDselector : Form
    {

        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        int valor = 1;
        public STDselector(string hero, int max)
        {
            InitializeComponent();
            this.CantLBL.Text = hero;
            this.CantUpDown.Maximum = max;
        }

        public int Valor
        {
            get { return this.valor; }
        }

        private void dataChange(object sender, EventArgs e)
        {
            this.valor = (int)this.CantUpDown.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
