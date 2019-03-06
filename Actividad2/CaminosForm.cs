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
    public partial class CaminosForm : Form
    {
        private Bitmap Original, Editable;
        private List<Agente> agentes;
        private int best;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;

        public CaminosForm(Bitmap imagen, List<Agente> agentes)
        {
            InitializeComponent();
            this.Original = (Bitmap)imagen;
            this.Editable = (Bitmap)imagen.Clone();
            this.agentes = agentes;
        }

        #region <Comportamiento>

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

        #endregion

        #region <Script>

        private void calc_best()
        {
            Agente mx = this.agentes[0];
            foreach(Agente a in this.agentes)
            {
                if (mx.visitados < a.visitados)
                {
                    mx = a;
                }
                else if (mx.visitados == a.visitados)
                {
                    mx = (mx.Distancia > a.Distancia) ? a : mx;
                }
            }
            mx.chose_one();
        }

        private void CaminosForm_Load(object sender, EventArgs e)
        {
            this.calc_best();
            foreach (Agente agent in this.agentes)
            {
                this.AgentesLista.Items.Add(agent);
            }
            this.PictureCaminos.Image = this.Editable;
            
        }

        private void AgentesLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AristasList.Items.Clear();
            this.VerticiesCB.Items.Clear();
            this.Editable = (Bitmap)this.Original.Clone();
            foreach (Arista arista in this.agentes[AgentesLista.SelectedIndex].GetHistorial())
            {
                arista.SetColors(Color.Purple, Editable, true);
                this.AristasList.Items.Add(arista);
            }
            foreach(vertice v in this.agentes[AgentesLista.SelectedIndex].GetVisitados())
            {
                this.VerticiesCB.Items.Add(v);
            }
            this.PictureCaminos.Image = Editable;
            this.DistLBL.Text = $"DISTANCIA: {agentes[AgentesLista.SelectedIndex].Distancia}";
            this.VisitadosLBL.Text = $"VISITO: {agentes[AgentesLista.SelectedIndex].visitados}";


        }
        #endregion;
    }
}
