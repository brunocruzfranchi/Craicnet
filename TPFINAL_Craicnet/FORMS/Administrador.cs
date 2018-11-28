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
using TPFINAL_Craicnet.FORMS;
using TPFINAL_Craicnet.CLASES;
using CsvHelper;
using System.IO;

namespace TPFINAL_Craicnet
{
    public partial class Administrador : Form
    {
        /*
         * TODO: Cambiar todos las actualizaciones de los grid y las listas, por las nuevas funciones
         *       VER COMO GUARDAR LA FOKING LISTAS EN UN CSV
         *       Ver si la interfaz esta bien hecha, y que se la pueda usar bien 
         *       Poner muchos MessageBox indicando problemas o algo por el estilo, tipo un throw exception
         *       Ver que tal le va a Juli en la parte de Estadisticas.
         *       Ver si el flujo de la informacion, listas, etc, esta bien hecha
         *          - Esto lo puedo hacer mañana directamente en el xCode de la mac
         *       Arreglar la parte de Promociones: ç
         *              No se esta poniendo en 0 los textbox del group box 
         *       
         * */

        //Propiedades

        public cUsuario Admin_Activo;

        //Cliente Form 

        public Administrador()
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 700;
            this.CenterToScreen();
        }

        /*public Administrador(cUsuario admin, List<cPelicula> lista, DataTable table, List<cPromo> promociones, DataTable table_promo)
        {
            InitializeComponent();

            lista_peliculas = Inicio.lista_peliculas;
            peliculas = table;
            lista_promociones = promociones;
            peliculas_promo = table_promo;

            Admin_Activo = admin;
            this.Width = 1200;
            this.Height = 700;
            this.CenterToScreen();
        }*/

        public Administrador(cUsuario admin)
        {
            InitializeComponent();
            Admin_Activo = admin;
            this.Width = 1200;
            this.Height = 700;
            this.CenterToScreen();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            grid_peliculas.DataSource = Inicio.peliculas;
            Grid_promociones.DataSource = Inicio.promociones;
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

                    private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        Estadisticas estadisticas = new Estadisticas(Inicio.lista_peliculas);
                        cPelicula.Actualizar(Inicio.lista_peliculas);
                        estadisticas.Show(this);
                    }

        //DataGrid Funciones

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
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Nombre).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Nombre).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "PrecioColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Precio).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Precio).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "PuntajeColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Puntaje).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Puntaje).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "GeneroColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Genero).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Genero).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "AñoColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Año).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Año).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "DirectorColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Director).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Director).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    break;
                                }
                            case "ActoresColumn":
                                {
                                    if (sortOrder == SortOrder.Ascending)
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Actores).ToList());
                                        grid_peliculas.DataSource = peliculas;
                                    }
                                    else
                                    {
                                        peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Actores).ToList());
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
                        txt_descuento.Enabled = false;
                        dateTimePicker_fecha_limite.Enabled = false;
                        DataGridViewCell cell = null;

                        foreach(DataGridViewCell selectedCell in grid_peliculas.SelectedCells)
                        {
                            cell = selectedCell;
                            break;
                        } 

                        if(cell != null)
                        {
                            DataGridViewRow row_pelicula = cell.OwningRow;

                            cPelicula aux = Inicio.lista_peliculas.Find(x => x.Nombre.Equals(row_pelicula.Cells[0].Value.ToString()));
                            
                            if (radio_editar.Checked == true|| radio_eliminar.Checked == true)
                            {
                                txt_pelicula.Text = aux.Nombre.ToString();
                                txt_director.Text = aux.Director.ToString();
                                txt_precio.Text = aux.Precio.ToString();
                                txt_genero.Text = aux.Genero.ToString();
                                txt_año.Text = aux.Año.ToString();
                                txt_actores.Text = aux.Actores.ToString();
                                txt_sinopsis.Text = aux.Sinopsis.ToString();                            
                            }else{

                            txt_pelicula_promo.Text = aux.Nombre.ToString();
                            txt_director_promo.Text = aux.Director.ToString();
                            txt_precio_promo.Text = aux.Precio.ToString();
                            txt_genero_promo.Text = aux.Genero.ToString();
                            txt_año_promo.Text = aux.Año.ToString();

                            }
                        }
                    }

                    private void Grid_promociones_SelectionChanged(object sender, EventArgs e)
                    {
                        txt_descuento.Enabled = true;
                        dateTimePicker_fecha_limite.Enabled = true;
                        DataGridViewCell cell = null;

                        foreach (DataGridViewCell selectedCell in Grid_promociones.SelectedCells)
                        {
                            cell = selectedCell;
                            break;
                        }

                        if (cell != null)
                        {
                            DataGridViewRow row_promociones = cell.OwningRow;

                            if (radio_editar.Checked == true || radio_eliminar.Checked == true)
                            {
                                cPromo aux = Inicio.lista_promociones.Find(x => x.Nombre.Equals(row_promociones.Cells[0].Value.ToString()));
                                txt_pelicula.Text = aux.Nombre.ToString(); ;
                                txt_director.Text = aux.Director.ToString();
                                txt_precio.Text = aux.Precio.ToString();
                                txt_genero.Text = aux.Genero.ToString();
                                txt_año.Text = aux.Año.ToString();
                                txt_actores.Text = aux.Actores.ToString();
                                txt_sinopsis.Text = aux.Sinopsis.ToString();
                                txt_descuento.Text = aux.Porcentaje_Descuento.ToString();
                                dateTimePicker_fecha_limite.Value = aux.Fecha_limite;

                            }
                        }
                    }

        //Buttons 

                    private void btn_promocion_Click(object sender, EventArgs e)
                    {
                        cPelicula peli_aux = Inicio.lista_peliculas.Find(x => x.Nombre.Contains(txt_pelicula_promo.Text));
                        cPromo promo_aux = new cPromo(peli_aux, txt_descuento_promo.Text.ToString(), fecha_limiteDateTimePicker.Value.Date.ToString());
                        Inicio.lista_peliculas.Remove(peli_aux);
                        Inicio.lista_promociones.Add(promo_aux);
                        UpdateGridPelicula();
                        UpdateGridPromociones();
                    }

                    private void btn_Agregar_Click(object sender, EventArgs e)
                    {
                        cPelicula peli_aux = new cPelicula(txt_pelicula.Text.ToString(), txt_actores.Text.ToString(), double.Parse(txt_precio.Text.ToString()), txt_director.Text.ToString(), txt_genero.Text.ToString(), txt_año.Text.ToString(), txt_sinopsis.Text.ToString());

                        Inicio.lista_peliculas.Add(peli_aux);

                        UpdateGridPelicula();
                    }

                    private void btn_eliminar_Click(object sender, EventArgs e)
                    {
                        cPelicula eliminar = Inicio.lista_peliculas.Find(x => x.Nombre.Contains(txt_pelicula.Text));
                        if (Inicio.lista_peliculas.Remove(eliminar))
                            MessageBox.Show("La pelicula " + eliminar.Nombre + " ha sido eliminada correctamente.");
                        else
                            MessageBox.Show("La pelicula no ha sido eliminada");

                        UpdateGridPelicula();

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
                        txt_sinopsis.Enabled = false;

                        btn_Agregar.Enabled = false;
                        btn_eliminar.Enabled = true;
                        btn_editar.Enabled = false;
                    }

                    private void button1_Click(object sender, EventArgs e)
                    {
                       
                        using (var sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\hola.csv"))
                        {

                            var writer = new CsvWriter(sw);

                            writer.WriteHeader(typeof(cPromo));

                            foreach (cPromo s in cPromoBindingSource.DataSource as List<cPromo>)
                            {
                                writer.WriteRecord(s);
                            }

                        }
                    }

        public void btn_editar_Click(object sender, EventArgs e)
                    {
                         /**
                          * TODO: 
                          *      Promociones: Ver que al afectar el precio de la pelicula en la lista de promociones, 
                          *                   tambien se vea afectada la lista comun. Pero seria mejor que no esten en la lista de peliculas comun
                          *                   ya que se deben estar en la parte de promociones. LESTO
                          *                   Comprobar que al cambiar el precio, este se vea afectado por el descuento existente. 
                          *                   Hacer un txt de decuento para que si el administrador desee cambiar el descuento q lo pueda hacer
                          *                   
                          *                   
                          *      Comunes: Ver que se actualicen bien.
                          * 
                          * */


                        if (MessageBox.Show("Esta seguro que quiere editar esta pelicula?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if(tabControl1.SelectedTab.Text == "Peliculas") {
                                                                                
                            var peli = Inicio.lista_peliculas.Find(x => x.Nombre.Contains(ObtenerNombre(sender,e, "Peliculas")));
                            
                            if(peli != null)
                            {
                                peli.Nombre = txt_pelicula.Text.ToString();
                                peli.Director = txt_director.Text.ToString();
                                peli.Precio = Int32.Parse(txt_precio.Text.ToString());
                                peli.Genero = txt_genero.Text.ToString();
                                peli.Año = txt_año.Text.ToString();
                                peli.Actores = txt_actores.Text.ToString();
                                peli.Sinopsis = txt_sinopsis.Text.ToString();
                            }

                            UpdateGridPelicula();

                            }
                               
                            if (tabControl1.SelectedTab.Text == "Promociones") {

                            var peli = Inicio.lista_promociones.Find(x => x.Nombre.Contains(ObtenerNombre(sender,e, "Promociones")));
                            
                            if(peli != null)
                            {
                                peli.Nombre = txt_pelicula.Text.ToString();
                                peli.Director = txt_director.Text.ToString();
                                peli.Precio = Int32.Parse(txt_precio.Text.ToString());
                                peli.Genero = txt_genero.Text.ToString();
                                peli.Año = txt_año.Text.ToString();
                                peli.Actores = txt_actores.Text.ToString();
                                peli.Sinopsis = txt_sinopsis.Text.ToString();
                                peli.Fecha_limite = dateTimePicker_fecha_limite.Value.Date;
                            }
                            peli.Update_datos();
                            UpdateGridPromociones();
                           
                            }
                                
                        }
                        else
                        {
                            MessageBox.Show("No se ha realizado el cambio");
                        }
                    }

                    public string ObtenerNombre(object sender, EventArgs e, string grid) {

                        string nombre;

                        DataGridViewCell cell = null;

                        if (grid == "Peliculas") { 
                     
                        cPelicula aux = new cPelicula();

                        foreach (DataGridViewCell selectedCell in grid_peliculas.SelectedCells)
                        {
                            cell = selectedCell;
                            break;
                        }

                        if (cell != null)
                        {
                            DataGridViewRow row_pelicula = cell.OwningRow;

                            aux = Inicio.lista_peliculas.Find(x => x.Nombre.Equals(row_pelicula.Cells[0].Value.ToString()));

                        }

                        nombre = aux.Nombre;

                            return nombre;
                        }

                        if (grid == "Promociones")
                        {

                            cPromo aux = new cPromo();

                            foreach (DataGridViewCell selectedCell in Grid_promociones.SelectedCells)
                            {
                                cell = selectedCell;
                                break;
                            }

                            if (cell != null)
                            {
                                DataGridViewRow row_pelicula = cell.OwningRow;

                                aux = Inicio.lista_promociones.Find(x => x.Nombre.Equals(row_pelicula.Cells[0].Value.ToString()));

                            }

                            nombre = aux.Nombre;

                            return nombre;
                        }

                        MessageBox.Show("No se ha podido encontrar la Pelicula seleccionada");

                        return " ";
                    }

                    public void UpdateGridPelicula()
                    {
                        Inicio.peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas);

                        grid_peliculas.DataSource = Inicio.peliculas;
                    }

                    public void UpdateGridPromociones()
                    {
                        Inicio.promociones = Inicio.ToDataTable<cPromo>(Inicio.lista_promociones);

                        Grid_promociones.DataSource = Inicio.promociones;
                    }

                    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
                    {
            
                        if (tabControl1.SelectedTab == tabControl1.TabPages["Peliculas"]) { 

                                txt_descuento.Enabled = false;
                                dateTimePicker_fecha_limite.Enabled = false;

                        }

                        if (tabControl1.SelectedTab == tabControl1.TabPages["Promociones"]) { 
                            if (radio_editar.Checked == true)
                            {
                                txt_descuento.Enabled = true;
                                dateTimePicker_fecha_limite.Enabled = true;
                            }
                        }
                    }
    }
}
