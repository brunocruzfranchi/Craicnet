using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL_Craicnet.FORMS
{
    public partial class Estadisticas : Form
    {
        public List<cPelicula> lista_peliculas;

        public Estadisticas()
        {
            InitializeComponent();
            lista_peliculas = new List<cPelicula>();
        }
        public Estadisticas(List<cPelicula> lista)
        {
            InitializeComponent();
            lista_peliculas = lista;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
