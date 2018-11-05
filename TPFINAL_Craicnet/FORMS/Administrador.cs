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
using System.Reflection;

namespace TPFINAL_Craicnet
{
    public partial class Administrador : Form
    {
        //Propiedades

        List<cPelicula> lista_peliculas = new List<cPelicula>();

        //Cliente Form 

        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            /*
            var source = new BindingSource();

            lista_peliculas = new Importar().ReadCSV("C:\\Users\\bruno\\Desktop\\Craicnet-Craicnet\\Craicnet-Craicnet\\Craicnet-Craicnet\\Peliculas-CSV.csv");

            source.DataSource = lista_peliculas;

            grid_peliculas.DataSource = source;
            */

            lista_peliculas = new Importar().ReadCSV("C:\\Users\\bruno\\Desktop\\Craicnet-Craicnet\\Craicnet-Craicnet\\Craicnet-Craicnet\\Peliculas-CSV.csv");

            DataTable peliculas = new DataTable();

            peliculas = ToDataTable<cPelicula>(lista_peliculas);

            /* BindingSource bs = new BindingSource         No me sirvio usar esto porque sigo teniendo el mismo problema de Binding
             {                                              
                 DataSource = lista_peliculas
             };*/

            grid_peliculas.DataSource = peliculas;
        }

        //Menu Strip

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

                    private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        this.Owner.Show();
                        this.Close();
                    }

        //DataGrid Funciones

                    /// <summary>
        /// ToDataTable me ayuda a convertir lo que una variable list
        /// a una DataTable. Esto me ayuda para poder facilitarme hacer las 
        /// funciones de Ordenar, Agregar , etc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
                    public static DataTable ToDataTable<T>(List<T> items)
                    {
                        DataTable dataTable = new DataTable(typeof(T).Name);

                        //Get all the properties
                        PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                        foreach (PropertyInfo prop in Props)
                        {
                            //Defining type of data column gives proper data table 
                            var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                            //Setting column names as Property names
                            dataTable.Columns.Add(prop.Name, type);
                        }
                        foreach (T item in items)
                        {
                            var values = new object[Props.Length];
                            for (int i = 0; i < Props.Length; i++)
                            {
                                //inserting property values to datatable rows
                                values[i] = Props[i].GetValue(item, null);
                            }
                            dataTable.Rows.Add(values);
                        }
                        //put a breakpoint here and check datatable
                        return dataTable;
                    }

                    /// <summary>
                    /// Esta funcion me permite hacer que aparezca los iconos de 
                    /// flechas en el header de las columnas y con esto hacer el
                    /// tipo de orden segun la flecha. 
                    /// </summary>
                    /// <param name="sender"></param>
                    /// <param name="e"></param>
                    private void grid_peliculas_cliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
                    {
                        DataGridView grid = (DataGridView)sender;
                        SortOrder so = SortOrder.None;

                        //Elijo el tipo de orden que quiero

                        if (grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
                        {
                            so = SortOrder.Descending;
                        }
                        else
                        {
                            so = SortOrder.Ascending;
                        }

                        Sort(grid.Columns[e.ColumnIndex].Name, so); //Envio a mi funcion la flecha que aparece en el header junto con la columna seleccionada

                        grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;  //Envio que tipo de flecha deberia aparecer 
                    }

                    /// <summary>
                    /// Ahora en la funcion Sort lo que pasa es que al haberme mandado el nombre de la columna y el tipo de orden que quiero
                    /// Tengo que ordenar la lista que estoy usando, en este caso, seria la lista Lista_Peliculas.
                    /// Y una vez ordenada la lista, hago el mismo procedimiento que arriba
                    /// </summary>
                    /// <param name="column"></param>
                    /// <param name="sortOrder"></param>
                    private void Sort(string column, SortOrder sortOrder)
                    {
                        DataTable peliculas = new DataTable();

                        switch (column)
                        {
                            case "NombreColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Nombre).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Nombre).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "PrecioColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Precio).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Precio).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "PuntajeColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Puntaje).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Puntaje).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "GeneroColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Genero).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Genero).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "AñoColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Año).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Año).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "DirectorColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Director).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Director).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "ActoresColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderBy(x => x.Actores).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = ToDataTable<cPelicula>(lista_peliculas.OrderByDescending(x => x.Actores).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                        }
                    }
                    
                    /// <summary>
                    /// Esto me permite que aparezca los datos de la pelicula en
                    /// un textbox para que le cliente vea los datos de dicha
                    /// pelicula.
                    /// </summary>
                    /// <param name="sender"></param>
                    /// <param name="e"></param>
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
                            txt_director_promo.Text = row.Cells[1].Value.ToString();
                            txt_precio_promo.Text = row.Cells[2].Value.ToString();
                            txt_genero_promo.Text = row.Cells[4].Value.ToString();
                            txt_año_promo.Text = row.Cells[5].Value.ToString();
                        }
                    }

        //Buttons 

        private void button1_Click(object sender, EventArgs e)
        {
           
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
            
        }

        private void btn_promocion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
