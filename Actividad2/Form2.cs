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
    public partial class Arbol_From : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Arbol_From(List<vertice> vertices)
        {
            InitializeComponent();
            this.Treefill(vertices);
        }

        private void Treefill(List<vertice> Arbol)
        {
            int h = 0;
            foreach(vertice v in Arbol)
            {
                TreeView.Nodes.Add(v.ToString());
                foreach(vertice child_v in v.GetVecinos().Keys)
                {
                    TreeView.Nodes[h].Nodes.Add($"{v.GetVecinos()[child_v]} -> {child_v}");
                }
                h++;
            }
        }

        private void Arbol_Controls_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Arbol_Controls_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Arbol_Controls_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void CloseArbolBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
