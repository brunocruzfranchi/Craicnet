using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.Timer;

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
            
            
            
        }

        private void chart_alq_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_anual_alq_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void combo_alq_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if (combo_alq.SelectedItem.ToString()=="Anual")
            {
                
               lista_peliculas = cPelicula.QuickSort_AlqAnio(lista_peliculas);
                chart_alq.Series["Alq_mes"].Points.Clear();
                
                for (int i = 0; i < N_CHART; i++)
                {
                    chart_alq.Series["Alq_mes"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Alq_Anio);
                    /* x.Add(lista_peliculas[i].Nombre);
                     y.Add(lista_peliculas[i].Alq_Anio);*/
                }
                // chart_alq.Series["Alq_mes"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Alq_Mes);
                //chart_alq.Series["Alq_mes"].Points.AddXY(x,y);
                chart_alq.Titles.Clear();
                chart_alq.Titles.Add("Alquiler Anual");
            }
            else
            {
                lista_peliculas = cPelicula.QuickSort_AlqMes(lista_peliculas);
                chart_alq.Series["Alq_mes"].Points.Clear();
                for (int i = 0; i < N_CHART; i++)
                           chart_alq.Series["Alq_mes"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Alq_Mes);
                //list_aux_alq.Add(lista_peliculas[i]);
                chart_alq.Titles.Clear();
                chart_alq.Titles.Add("Alquiler Mensual");
            }
        }

        private void combo_anual_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_vistos.SelectedItem.ToString() == "Anual")
            {
                lista_peliculas = cPelicula.BubbleSort_VistAño(lista_peliculas);
                chart_vistos.Series["Vistos"].Points.Clear();

                for (int i = 0; i < N_CHART; i++)
                {
                    chart_vistos.Series["Vistos"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Vistos_Anio);
                   
                }
                
                chart_vistos.Titles.Clear();
                chart_vistos.Titles.Add("Vistos Anual");
            }
            else
            {
                lista_peliculas = cPelicula.BubbleSort_VistMes(lista_peliculas);
                chart_vistos.Series["Vistos"].Points.Clear();
                for (int i = 0; i < N_CHART; i++)
                    chart_vistos.Series["Vistos"].Points.AddXY(lista_peliculas[i].Nombre, lista_peliculas[i].Vistos_Mes);
                
                chart_vistos.Titles.Clear();
                chart_vistos.Titles.Add("Vistos Mensual");
            }


        }

        private void combo_anual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart_vistos_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cmp_Click(object sender, EventArgs e)
        {
            Timer bubble = new Timer();
            Timer quick = new Timer();

            if(combo_cmp.SelectedItem.ToString()=="Anual")
                {
                bubble.Start();
                lista_peliculas = cPelicula.BubbleSort_VistMes(lista_peliculas);
                bubble.Stop();
                quick.Start();
                lista_peliculas = cPelicula.QuickSort_AlqMes(lista_peliculas); //chequear quicksort
                quick.Stop();
            }
            else
            {
                bubble.Start();
                lista_peliculas = cPelicula.BubbleSort_VistAño(lista_peliculas);
                bubble.Stop();
                quick.Start();
                lista_peliculas = cPelicula.QuickSort_AlqAnio(lista_peliculas);
                quick.Stop();
            }

            MessageBox.Show(bubble.Interval.ToString(), quick.Interval.ToString()); //!!!! mirar bien como imprimir bien
            bubble.Dispose();
            quick.Dispose();
        }
    }
}
