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
        public const int N_CHART= 5;
        public Estadisticas()
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 700;
            this.CenterToScreen();
            lista_peliculas = new List<cPelicula>();
        }
        public Estadisticas(List<cPelicula> lista)
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 700;
            this.CenterToScreen();
            lista_peliculas = lista;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtn_mensual_alq_CheckedChanged(object sender, EventArgs e)
        {
            lista_peliculas=cPelicula.Quicksort_AlqMes(lista_peliculas);
            for (int i = 0; i < N_CHART; i++)
            {
                //list_aux_alq.Add(lista_peliculas[i]);
                chart_alq.Series["Alq_mes"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Alq_Mes);
            }
            
            
            
        }

        private void chart_alq_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_anual_alq_CheckedChanged(object sender, EventArgs e)
        {
            lista_peliculas = cPelicula.Quicksort_AlqAño(lista_peliculas);
            for (int i = 0; i < N_CHART; i++)
            {
                //list_aux_alq.Add(lista_peliculas[i]);
                chart_alq.Series["Alq_mes"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Alq_Mes);
            }
        }
    }
}
