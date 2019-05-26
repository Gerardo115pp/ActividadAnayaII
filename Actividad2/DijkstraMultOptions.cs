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
    public partial class DijkstraMultOptions : Form
    {
        int presas = 0;
        int depredadoras = 0;
        int CircsLen;

        List<Dictionary<string,int>> list_presas;

        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public DijkstraMultOptions(int Max)
        {
            InitializeComponent();
            this.CircsLen = Max;
            this.PresasUpDown.Maximum = Max;
            this.DepredadoraUpDown.Maximum = Max;
            this.list_presas = new List<Dictionary<string, int>>();
        }

        public List<Dictionary<string,int>> Presas
        {
            get { return this.list_presas; }
        }

        public int Depredadoras
        {
            get { return this.depredadoras; }
        }

        #region <script> 

        private void PresasUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (this.PresasUpDown.Value+this.DepredadoraUpDown.Value > this.CircsLen)
            {
                this.DepredadoraUpDown.Value--;
            }

            if (this.PresasUpDown.Value > this.PresasListView.Items.Count)
            {
                Dictionary<string, int> presa = new Dictionary<string, int>();
                presa["origen"] = 0;
                presa["destino"] = 0;
                this.list_presas.Add(presa);
                this.PresasListView.Items.Add($"Presa {this.PresasListView.Items.Count}");
            }
            else
            {
                this.list_presas.RemoveAt(this.PresasListView.Items.Count - 1);
                this.PresasListView.Items.RemoveAt(this.PresasListView.Items.Count - 1);
            }
        }

        private void DepredadoraUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.depredadoras = (int)this.DepredadoraUpDown.Value;
            if (this.PresasUpDown.Value + this.DepredadoraUpDown.Value > this.CircsLen)
            {
                this.PresasUpDown.Value--;
            }
        }
        
        private void PresasListView_ItemActivate(object sender, EventArgs e)
        {
            if (this.PresasListView.SelectedItems.Count > 0)
            {
                int selected_index = this.PresasListView.SelectedItems[0].Index;
                Dictionary<string, int> elemento = this.list_presas[selected_index];
                PresaOptions presaOptions = new PresaOptions($"PRESA {selected_index}", elemento, this.CircsLen);
                presaOptions.ShowDialog();
            }
        }

        #endregion </script>

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

        private void PresasListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
