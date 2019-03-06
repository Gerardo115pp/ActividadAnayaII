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
        int max;
        public int cantidad;

        public Cant_change(int Max)
        {
            InitializeComponent();
            this.max = Max;
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
    }
}
