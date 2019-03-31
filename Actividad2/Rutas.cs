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
    public partial class Rutas : Form
    {
        int selected;
        public Rutas(int selected)
        {
            InitializeComponent();
            this.selected = selected;
            this.select(selected);
        }

        public int Selected
        {
            get { return this.selected; }
        }

        private void select(int selected)
        {
            if (selected < this.Choices.Controls.Count)
            {
                RadioButton rbtn = (RadioButton)(this.Choices.Controls[selected]);
                rbtn.ForeColor = Color.FromArgb(8, 138, 158);
                rbtn.Checked = true;
            }
        }

        private void RutasCloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void op_kruskal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton new_selected = (RadioButton)sender,
                        prev = (RadioButton)(this.Choices.Controls[this.selected]);
            if(new_selected != prev)
            {
                prev.Checked = false;
                prev.ForeColor = Color.FromArgb(78, 159, 8);
                new_selected.ForeColor = Color.FromArgb(8, 138, 158);
                new_selected.Checked = true;
                this.selected = this.Choices.Controls.IndexOf(new_selected);
            }
        }
    }
}
