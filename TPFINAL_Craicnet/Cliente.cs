using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL_Craicnet
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbox_alquilar.Visible = true;
            split_alquilar.Visible = true;
            split_graficos.Visible = false;

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbox_alquilar.Visible = false;
            split_alquilar.Visible = false;
            split_graficos.Visible = true;
        }

        private void gbox_graficos_Enter(object sender, EventArgs e)
        {

        }
    }
}
