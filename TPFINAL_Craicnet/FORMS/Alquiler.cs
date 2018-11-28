using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFINAL_Craicnet.CLASES;
namespace TPFINAL_Craicnet.FORMS
    
{
    public partial class Alquiler : Form
    {
        public cPelicula Pelicula_Alquilada;
        public cUsuario Cliente_que_alquila;
       
        public Alquiler()
        {
            InitializeComponent();
            this.Width = 165*4;
            this.Height = 70*4;
            this.CenterToScreen();
        }
        public Alquiler(cPelicula peli, cUsuario cliente)
        {
            bool EsPromo = false;
            InitializeComponent();
            this.Width = 165*4;
            this.Height = 70*4;
            this.CenterToScreen();
            this.Pelicula_Alquilada = peli;
            this.Cliente_que_alquila = cliente;
            txt_Nombre.Text = Pelicula_Alquilada.Nombre;
            foreach (cPromo promo in Inicio.lista_promociones)
            {
                if (promo.Pelicula == Pelicula_Alquilada)
                {
                    txt_Precio.Text = promo.Precio_descuento.ToString();
                    EsPromo = true;
                }
            }
            if(!EsPromo)
                txt_Precio.Text = Pelicula_Alquilada.Precio.ToString();
            txt_n_dias.Text = DateTime.Compare( dateTimePicker1.Value, DateTime.Today).ToString();
            txt_PrecioTotal.Text = (int.Parse(txt_n_dias.Text) * float.Parse(txt_Precio.Text)).ToString();
        }
        public Alquiler(cPromo peli, cUsuario cliente)
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 700;
            this.CenterToScreen();
            this.Pelicula_Alquilada = peli.Pelicula;
            this.Cliente_que_alquila = cliente;
            txt_Nombre.Text = Pelicula_Alquilada.Nombre;
            txt_Precio.Text = peli.PrecioPromo_String();
            txt_n_dias.Text = DateTime.Compare(dateTimePicker1.Value, DateTime.Today).ToString();
            txt_PrecioTotal.Text = (int.Parse(txt_n_dias.Text) * float.Parse(txt_Precio.Text)).ToString();
        
    }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Pelicula_Alquilada.Fecha_Dev = dateTimePicker1.Value.Date;
            Cliente_que_alquila.peliculas_alquiladas.Add(Pelicula_Alquilada);
            Pelicula_Alquilada.Alq_Anio++;
            Pelicula_Alquilada.Alq_Mes++;
            MessageBox.Show("Pelicula alquilada");
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            

           // n_dias = int.Parse(dateTimePicker1.Value.Subtract(DateTime.Today).ToString());
           //  while(!aux_date.Equals(dateTimePicker1.Value))
           // {
           //   aux_date.AddDays(1);
           // n_dias++;
           //}
            txt_n_dias.Clear();
            txt_n_dias.Text = (dateTimePicker1.Value - DateTime.Today).Days.ToString();
            txt_PrecioTotal.Text = ((dateTimePicker1.Value - DateTime.Today).Days * int.Parse(txt_Precio.Text)).ToString();
            

        }

        private void Alquiler_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
