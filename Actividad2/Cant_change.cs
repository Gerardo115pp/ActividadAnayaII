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
    public partial class Cant_change : Form
    {
        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        int max;
        public int cantidad;

        public Cant_change(int Max, int min = 1)
        {
            InitializeComponent();
            this.max = Max;
            CantUpDown.Minimum = (decimal)min;
        }

        public Cant_change(int Max,string lbl,int min=1)
        {
            InitializeComponent();
            this.max = Max;
            CantLBL.Text = lbl;
            CantUpDown.Minimum = (decimal)min;
        }

        private void ControlsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBTN_Click(object sender, EventArgs e)
        {
            cantidad = (Int32)CantUpDown.Value;
            this.Close();
        }

        private void Cant_change_Load(object sender, EventArgs e)
        {
            CantUpDown.Maximum = this.max;
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
