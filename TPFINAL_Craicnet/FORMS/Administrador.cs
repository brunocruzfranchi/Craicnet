using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TPFINAL_Craicnet
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_peliculas.Visible = true;
            groupbox_agregar.Visible = false;
            gbox_promocion.Visible = true;
        }

        private void agregarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_peliculas.Visible = true;
            groupbox_agregar.Visible = true;
            gbox_promocion.Visible = false;
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            //new Importar().importarExcel(grid_peliculas, "Hoja1");
            var source = new BindingSource();

            List<cPelicula> lista_peliculas = new List<cPelicula>();

            lista_peliculas = new Importar().ReadCSV("C:\\Users\\bruno\\Desktop\\Craicnet-Craicnet\\Craicnet-Craicnet\\Craicnet-Craicnet\\Peliculas-CSV.csv");

            source.DataSource = lista_peliculas;

            grid_peliculas.DataSource = source;

        }

        private void grid_peliculas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach(DataGridViewCell selectedCell in grid_peliculas.SelectedCells)
            {
                cell = selectedCell;
                break;
            } 
            if(cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_pelicula_promo.Text = row.Cells[0].Value.ToString();
                txt_precio_promo.Text = row.Cells[3].Value.ToString();
                txt_director_promo.Text = row.Cells[1].Value.ToString();
                txt_genero_promo.Text = row.Cells[2].Value.ToString();
                txt_año_promo.Text = row.Cells[5].Value.ToString();
            }

        } ///ESTO ES PARA SELECCIONAR Y LUEGO EDITAR EL NOMBRE O LO QUE SEA

        private void button1_Click(object sender, EventArgs e)
        {
           /*
            //Agregar las Filas al DataRow y asignar el valor correspondiente. 
            DataTable aux = new DataTable();
            aux = grid_peliculas.DataSource as DataTable;

            DataRow datarow;
            datarow = aux.NewRow(); //Con esto le indica que es una nueva fila.

            datarow["Nombre"] = txt_pelicula.Text;
            datarow["Actores"] = txt_actores.Text;
            datarow["Genero"] = txt_genero.Text;
            datarow["Año"] = txt_año.Text;
            datarow["Director"] = txt_director.Text;

            //Esto se encargará de agregar la fila.
            aux.Rows.Add(datarow);
            */
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void grid_peliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
