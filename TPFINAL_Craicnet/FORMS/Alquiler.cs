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
            this.Width = 1000;
            this.Height = 700;
            this.CenterToScreen();
        }
        public Alquiler(cPelicula peli, cUsuario cliente)
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
            this.CenterToScreen();
            this.Pelicula_Alquilada = peli;
            this.Cliente_que_alquila = cliente;
            txt_Nombre.Text = Pelicula_Alquilada.Nombre;
            txt_Precio.Text = Pelicula_Alquilada.Precio.ToString();
        }
        public Alquiler(cPromo peli, cUsuario cliente)
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
            this.CenterToScreen();
            this.Pelicula_Alquilada = peli.Pelicula;
            this.Cliente_que_alquila = cliente;
            txt_Nombre.Text = Pelicula_Alquilada.Nombre;
            txt_Precio.Text = peli.PrecioPromo_String().ToString();
               
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            
            Cliente_que_alquila.peliculas_alquiladas.Add(Pelicula_Alquilada);
            MessageBox.Show("Pelicula alquilada");
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
