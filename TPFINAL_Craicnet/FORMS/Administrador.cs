﻿using System;
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
            //System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);        
            lista_peliculas = new Importar().ReadCSV(AppDomain.CurrentDomain.BaseDirectory + "\\Peliculas-CSV.csv");

            DataTable peliculas = new DataTable();

            peliculas = ToDataTable<cPelicula>(lista_peliculas);

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
                            if (radio_editar.Checked == true|| radio_eliminar.Checked == true)
                            {
                                txt_pelicula.Text = row.Cells[0].Value.ToString();
                                txt_director.Text = row.Cells[1].Value.ToString();
                                txt_precio.Text = row.Cells[2].Value.ToString();
                                txt_genero.Text = row.Cells[4].Value.ToString();
                                txt_año.Text = row.Cells[5].Value.ToString();
                                txt_actores.Text = row.Cells[6].Value.ToString();
                                txt_sinopsis.Text = row.Cells[7].Value.ToString();
                            }else{
                            txt_pelicula_promo.Text = row.Cells[0].Value.ToString();
                            txt_director_promo.Text = row.Cells[1].Value.ToString();
                            txt_precio_promo.Text = row.Cells[2].Value.ToString();
                            txt_genero_promo.Text = row.Cells[4].Value.ToString();
                            txt_año_promo.Text = row.Cells[5].Value.ToString();
                            }
                        }
                    }

        //Buttons 

                    private void btn_promocion_Click(object sender, EventArgs e)
                    {
            
                    }

                    private void btn_Agregar_Click(object sender, EventArgs e)
                    {
                        /*
                        //Agregar las filas al DataRow y asignar el valor correspondiente. 
                        DataTable aux = new DataTable();
                        aux = grid_peliculas.DataSource as DataTable;

                        DataRow datarow;
                        datarow = aux.NewRow(); //Agrega una nueva linea a la Data Table 

                        datarow["Nombre"] = txt_pelicula.Text;
                        datarow["Director"] = txt_director.Text;
                        datarow["Precio"] = txt_precio.Text;
                        datarow["Genero"] = txt_genero.Text;
                        datarow["Año"] = txt_año.Text;
                        datarow["Actores"] = txt_actores.Text;

                        cPelicula peli_aux = new cPelicula(txt_pelicula.Text.ToString(), txt_actores.Text.ToString(), double.Parse(txt_precio.Text.ToString()), txt_director.Text.ToString(), txt_genero.Text.ToString(), txt_año.Text.ToString(), txt_sinopsis.Text.ToString());

                        lista_peliculas.Add(peli_aux);

                        //Esto se encargará de agregar la fila.
                        */

                        DataTable peliculas = new DataTable();

                        cPelicula peli_aux = new cPelicula(txt_pelicula.Text.ToString(), txt_actores.Text.ToString(), double.Parse(txt_precio.Text.ToString()), txt_director.Text.ToString(), txt_genero.Text.ToString(), txt_año.Text.ToString(), txt_sinopsis.Text.ToString());

                        lista_peliculas.Add(peli_aux);

                        peliculas = ToDataTable<cPelicula>(lista_peliculas);

                        grid_peliculas.DataSource = peliculas;



                        //TODO: Ver como puedo mejorar la parte de agregado
                        //      Esto lo puedo hacer creandome una peli_aux, le agrego los datos, lo guardo en mi lista
                        //      Y luego puedo actualizar la DataGrid o dejarlo como estaba;
                        //      Puedo agregar para que salga un mensaje diciendo:  Pelicula Agreaga y los datos o algo parecido
                    }

                    private void btn_eliminar_Click(object sender, EventArgs e)
                    {

                    }

                    private void radio_agregar_CheckedChanged(object sender, EventArgs e)
                    {
                        txt_pelicula.Enabled = true;
                        txt_director.Enabled = true;
                        txt_precio.Enabled = true;
                        txt_genero.Enabled = true;
                        txt_año.Enabled = true;
                        txt_actores.Enabled = true;
                        txt_sinopsis.Enabled = true;

                        btn_Agregar.Enabled = true;
                        btn_eliminar.Enabled = false;
                        btn_editar.Enabled = false;

                        txt_pelicula.Text = "";
                        txt_director.Text = "";
                        txt_precio.Text = "";
                        txt_genero.Text = "";
                        txt_año.Text = "";
                        txt_actores.Text = "";
                        txt_sinopsis.Text = "";
                    }

                    private void radio_editar_CheckedChanged(object sender, EventArgs e)
                    {
                        txt_pelicula.Enabled = true;
                        txt_director.Enabled = true;
                        txt_precio.Enabled = true;
                        txt_genero.Enabled = true;
                        txt_año.Enabled = true;
                        txt_actores.Enabled = true;
                        txt_sinopsis.Enabled = true;

                        btn_Agregar.Enabled = false;
                        btn_eliminar.Enabled = false;
                        btn_editar.Enabled = true;
                    }

                    private void radio_eliminar_CheckedChanged(object sender, EventArgs e)
                    {
                        txt_pelicula.Enabled = false;
                        txt_director.Enabled = false;
                        txt_precio.Enabled = false;
                        txt_genero.Enabled = false;
                        txt_año.Enabled = false;
                        txt_actores.Enabled = false;
                        txt_sinopsis.Enabled = true;

                        btn_Agregar.Enabled = false;
                        btn_eliminar.Enabled = true;
                        btn_editar.Enabled = false;
                    }

    }
}