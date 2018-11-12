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
    public partial class Promociones : Form
    {
        public List<cPromo> lista_peliculas_promo;
        public cUsuario Alquilador;
        public Promociones()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
            this.CenterToScreen();
            lista_peliculas_promo = new List<cPromo>();
        }
        public Promociones(cUsuario c)
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
            this.CenterToScreen();
            lista_peliculas_promo = new List<cPromo>();
        }

        private void btn_alquiler_promo_Click(object sender, EventArgs e)
        {
            FORMS.Alquiler alquiler = new FORMS.Alquiler(lista_peliculas_promo.Find(x => x.Pelicula.Nombre.Contains(txt_NombrePromo.Text)), Alquilador);
            alquiler.Show(this);
        }
    }
}
