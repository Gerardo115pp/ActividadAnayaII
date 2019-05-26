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
    public partial class PresaOptions : Form
    {
        Dictionary<string, int> presa;
        int LenCircs;

        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public PresaOptions(string name,Dictionary<string,int> pairs,int LenCircs)
        {
            InitializeComponent();
            this.Title.Text = name;
            presa = pairs;
            this.LenCircs = LenCircs;
            this.OrigenUpDown.Value = presa["origen"];
            this.DestinoUpDown.Value = presa["destino"];
            this.OrigenUpDown.Maximum = LenCircs-1;
            this.DestinoUpDown.Maximum = LenCircs-1;
        }

        private void OrigenUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.presa["origen"] = (int)this.OrigenUpDown.Value;
        }

        private void DestinoUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.presa["destino"] = (int)this.DestinoUpDown.Value;
        }

        #region <frontend>
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
        #endregion </frontend>

    }
}
