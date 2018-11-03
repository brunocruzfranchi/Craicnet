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
            split_usuario.Visible = false;

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbox_alquilar.Visible = false;
            split_alquilar.Visible = false;
            split_graficos.Visible = true;
            split_usuario.Visible = false;
        }

        private void gbox_graficos_Enter(object sender, EventArgs e)
        {

        }

        public void Cliente_Load(object sender, EventArgs e)
        {
            List<cPelicula> lista_peliculas = new List<cPelicula>();

            lista_peliculas = new Importar().ReadCSV("C:\\Users\\bruno\\Desktop\\Craicnet-Craicnet\\Craicnet-Craicnet\\Craicnet-Craicnet\\Peliculas-CSV.csv");

            grid_peliculas_cliente.DataSource = lista_peliculas;
        }

        private void grid_peliculas_cliente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in grid_peliculas_cliente.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_pelicula_cliente.Text = row.Cells[0].Value.ToString();
                txt_genero_cliente.Text = row.Cells[2].Value.ToString();
                txt_director_cliente.Text = row.Cells[1].Value.ToString();
                txt_precio_cliente.Text = row.Cells[3].Value.ToString();
                txt_año_cliente.Text = row.Cells[5].Value.ToString();
                txt_sinopsis.Text = row.Cells[7].Value.ToString();
            }
            
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void alquiladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbox_alquilar.Visible = false;
            split_alquilar.Visible = false;
            split_graficos.Visible = false;
            split_usuario.Visible = true;
            //Se tendrian que ver unicamente las que estan en promocion
        }

        private void combo_ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {
          /*  string column = grid_peliculas_cliente.Columns[0].HeaderText;
            grid_peliculas_cliente.Sort(grid_peliculas_cliente.Columns[0], ListSortDirection.Ascending);*/
        }
    }
}