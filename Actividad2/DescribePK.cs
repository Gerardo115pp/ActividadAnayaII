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
    public partial class DescribePK : Form
    {
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;
        double ptotal, ktotal;

        public DescribePK(List<Arista> PrimArs, List<Arista> KruskalArs)
        {
            InitializeComponent();
            PrimArs.ForEach((x) => { this.PrimList.Items.Add(x); ptotal += x.GetDist(); });
            KruskalArs.ForEach((x) => { this.KruskalLista.Items.Add(x); ktotal += x.GetDist(); });
            Tkruskal.Text += $"{ktotal}";
            Tprim.Text += $"{ptotal}";
        }

        private void Controles_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Controles_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Controles_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
