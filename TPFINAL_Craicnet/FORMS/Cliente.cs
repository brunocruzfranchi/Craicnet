﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFINAL_Craicnet.FORMS;
using TPFINAL_Craicnet.CLASES;

namespace TPFINAL_Craicnet
{
    public partial class Cliente : Form
    {
        //Propiedades

        public cUsuario Cliente_Activo;

        //Cliente Form 

        public Cliente()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 1200;
            this.CenterToScreen();
            Cliente_Activo = null;
            txt_actor_cliente.ReadOnly = true;
            txt_anio_cliente.ReadOnly = true;
            txt_director_cliente.ReadOnly = true;
            txt_genero_cliente.ReadOnly = true;
            txt_pelicula_cliente.ReadOnly = true;
            txt_precio_cliente.ReadOnly = true;

            
        }

        public Cliente(cUsuario cliente)
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 1200;
            this.CenterToScreen();
            Cliente_Activo = cliente;
            txt_actor_cliente.ReadOnly = true;
            txt_anio_cliente.ReadOnly = true;
            txt_director_cliente.ReadOnly = true;
            txt_genero_cliente.ReadOnly = true;
            txt_pelicula_cliente.ReadOnly = true;
            txt_precio_cliente.ReadOnly = true;
            label3.Text = Cliente_Activo.Id;
            pict_like.BackColor = TransparencyKey;
          }

        public void Cliente_Load(object sender, EventArgs e)
        {
            grid_peliculas_cliente.DataSource = Inicio.peliculas;
            grid_promociones_cliente.DataSource = Inicio.promociones;
            DataTable data = new DataTable();
            data = Inicio.ToDataTable(Cliente_Activo.peliculas_alquiladas);
            grid_alq.DataSource = data;
            pict_like.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "like.png");
            label3.Hide();
            split_alquilar.BringToFront();
        }

        //Menu Strip

                private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    gbox_alquilar.Visible = true;
                    split_alquilar.Visible = true;                   
                    label3.Hide();
                }

                private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    gbox_alquilar.Visible = false;
                    split_alquilar.Visible = false;
                    label3.Hide();
                }

                private void alquiladasToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    gbox_alquilar.Visible = false;
                    split_alquilar.Visible = false;
                    label3.Show();
            //Se tendrian que ver unicamente las alquiladas

                    foreach (cPelicula peli in Cliente_Activo.peliculas_alquiladas)
                        if (peli.Pelicula_Vencida())
                             Cliente_Activo.peliculas_alquiladas.Remove(peli);
                                            
                  }

                private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    this.Owner.Show();
                    this.Close();
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
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Nombre).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                break;
                            }
                        case "PrecioColumn":
                            {
                                if (sortOrder == SortOrder.Ascending)
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Precio).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Precio).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                break;
                            }
                        case "PuntajeColumn":
                            {
                                if (sortOrder == SortOrder.Ascending)
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Puntaje).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Puntaje).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                break;
                            }
                        case "GeneroColumn":
                            {
                                if (sortOrder == SortOrder.Ascending)
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Genero).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Genero).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                break;
                            }
                        case "AñoColumn":
                            {
                                if (sortOrder == SortOrder.Ascending)
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Año).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Año).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                break;
                            }
                        case "DirectorColumn":
                            {
                                if (sortOrder == SortOrder.Ascending)
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Director).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Director).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                break;
                            }
                        case "ActoresColumn":
                            {
                                if (sortOrder == SortOrder.Ascending)
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderBy(x => x.Actores).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
                                }
                                else
                                {
                                    peliculas = Inicio.ToDataTable<cPelicula>(Inicio.lista_peliculas.OrderByDescending(x => x.Actores).ToList());
                                    grid_peliculas_cliente.DataSource = peliculas;
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
                private void grid_peliculas_cliente_SelectionChanged(object sender, EventArgs e)
                 {
                    DataGridViewCell cell = null;

                    foreach (DataGridViewCell selectedCell in grid_peliculas_cliente.SelectedCells)
                    {
                        cell = selectedCell;
                        break;
                    }

                    if (cell != null&& !rbtn_buscar.Checked)
                    {
                        DataGridViewRow row = cell.OwningRow;
                        txt_pelicula_cliente.Text = row.Cells[0].Value.ToString();
                        txt_director_cliente.Text = row.Cells[1].Value.ToString();
                        txt_precio_cliente.Text = row.Cells[2].Value.ToString();
                        txt_genero_cliente.Text = row.Cells[4].Value.ToString();
                        txt_anio_cliente.Text = row.Cells[5].Value.ToString();
                        txt_sinopsis.Text = row.Cells[7].Value.ToString();
                        txt_actor_cliente.Text = row.Cells[6].Value.ToString();
                       
                    }
            
                 }

                private void grid_promociones_cliente_SelectionChanged(object sender, EventArgs e)
                {
                    DataGridViewCell cell = null;

                    foreach (DataGridViewCell selectedCell in grid_promociones_cliente.SelectedCells)
                    {
                        cell = selectedCell;
                        break;
                    }

                    if (cell != null&& !rbtn_buscar.Checked)
                    {
                        DataGridViewRow row = cell.OwningRow;
                        txt_pelicula_cliente.Text = row.Cells[2].Value.ToString();
                        txt_director_cliente.Text = row.Cells[7].Value.ToString();
                        txt_precio_cliente.Text = row.Cells[5].Value.ToString();
                        txt_genero_cliente.Text = row.Cells[8].Value.ToString();
                        txt_anio_cliente.Text = row.Cells[9].Value.ToString();
                        txt_sinopsis.Text = row.Cells[7].Value.ToString();
                        txt_actor_cliente.Text = row.Cells[10].Value.ToString();
                txt_sinopsis.Text = row.Cells[11].Value.ToString();
            }

                }


        //Buttons 

        private void btn_alquilar_Click(object sender, EventArgs e)
            
        {
            cPelicula aux = null;
            if (tab_Peliculas.SelectedTab == tabp_peliculas)
            {
                aux = Inicio.lista_peliculas.Find(x => x.Nombre.Contains(txt_pelicula_cliente.Text));
                FORMS.Alquiler alquiler = new FORMS.Alquiler(aux, Cliente_Activo);
                cPelicula.Actualizar(Inicio.lista_peliculas);
                alquiler.Show(this);
            }
            if (tab_Peliculas.SelectedTab == tabp_promo)
            {
                aux = Inicio.lista_promociones.Find(x => x.Pelicula.Nombre.Contains(txt_pelicula_cliente.Text)).Pelicula;
                FORMS.Alquiler alquiler = new FORMS.Alquiler(aux, Cliente_Activo);
                cPelicula.Actualizar(Inicio.lista_peliculas);
                alquiler.Show(this);
            }

            grid_alq.DataSource = Cliente_Activo.peliculas_alquiladas;
            
           

        }

        private void gbox_alquilar_Enter(object sender, EventArgs e)
        {

        }

        private void gbox_cliente_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Promociones_Click(object sender, EventArgs e)
        {
            Promociones promociones = new Promociones(Cliente_Activo);
            promociones.Show(this);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (tab_Peliculas.SelectedTab == tabp_peliculas)
            {
                BindingList<cPelicula> filtered = new BindingList<cPelicula>(Inicio.lista_peliculas.Where(obj => (obj.Nombre.Contains(txt_pelicula_cliente.Text) &&
                                                                             obj.Actores.Contains(txt_actor_cliente.Text) &&
                                                                             obj.Precio.ToString().Contains(txt_precio_cliente.Text) &&
                                                                             obj.Director.Contains(txt_director_cliente.Text) &&
                                                                             obj.Año.Contains(txt_anio_cliente.Text) &&
                                                                             obj.Genero.Contains(txt_genero_cliente.Text))).ToList());
                grid_peliculas_cliente.DataSource = filtered;
                grid_peliculas_cliente.EndEdit();
                grid_peliculas_cliente.ResetBindings();

            }
            if (tab_Peliculas.SelectedTab == tabp_promo)
            {
                BindingList<cPromo> filtered = new BindingList<cPromo>(Inicio.lista_promociones.Where(obj => (obj.Nombre.Contains(txt_pelicula_cliente.Text) &&
                                                                             obj.Actores.Contains(txt_actor_cliente.Text) &&
                                                                             obj.Precio.ToString().Contains(txt_precio_cliente.Text) &&
                                                                             obj.Director.Contains(txt_director_cliente.Text) &&
                                                                             obj.Año.Contains(txt_anio_cliente.Text) &&
                                                                             obj.Genero.Contains(txt_genero_cliente.Text))).ToList());
                grid_promociones_cliente.DataSource = filtered;
                grid_promociones_cliente.EndEdit();
                grid_promociones_cliente.ResetBindings();
            }
            if (tab_Peliculas.SelectedTab == tabp_alq)
            {
                BindingList<cPelicula> filtered = new BindingList<cPelicula>(Cliente_Activo.peliculas_alquiladas.Where(obj => (obj.Nombre.Contains(txt_pelicula_cliente.Text) &&
                                                                             obj.Actores.Contains(txt_actor_cliente.Text) &&
                                                                             obj.Precio.ToString().Contains(txt_precio_cliente.Text) &&
                                                                             obj.Director.Contains(txt_director_cliente.Text) &&
                                                                             obj.Año.Contains(txt_anio_cliente.Text) &&
                                                                             obj.Genero.Contains(txt_genero_cliente.Text))).ToList());
                grid_alq.DataSource = filtered;
                grid_alq.EndEdit();
                grid_alq.ResetBindings();

            }

            /*   *if(!string.IsNullOrWhiteSpace(txt_pelicula_cliente.Text))
              filtered.Where(obj => obj.Nombre.Contains(txt_pelicula_cliente.Text)).ToList();
            if (!string.IsNullOrWhiteSpace(txt_actor_cliente.Text))
                filtered.Where(obj => obj.Actores.Contains(txt_actor_cliente.Text));
             if (!string.IsNullOrWhiteSpace(txt_precio_cliente.Text))
                 filtered.Where(obj => obj.Precio.ToString().Contains(txt_precio_cliente.Text));
             if (!string.IsNullOrWhiteSpace(txt_director_cliente.Text))
                 filtered.Where(obj => obj.Director.Contains(txt_director_cliente.Text));
             if (!string.IsNullOrWhiteSpace(txt_anio_cliente.Text))
                 filtered.Where(obj => obj.Año.Contains(txt_anio_cliente.Text));
             if (!string.IsNullOrWhiteSpace(txt_genero_cliente.Text))
                 filtered.Where(obj => obj.Genero.Contains(txt_genero_cliente.Text));*/

           
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            grid_peliculas_cliente.DataSource = Inicio.lista_peliculas;

        }

        private void rbtn_buscar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_buscar.Checked)
            {
                rbtn_Alquiler.Checked = false;
                btn_alquilar.Enabled = false;
                btn_Restaurar.Enabled = true;
                btn_Buscar.Enabled = true;
                txt_actor_cliente.ReadOnly = false;
                txt_actor_cliente.Clear();
                txt_anio_cliente.ReadOnly = !true;
                txt_director_cliente.ReadOnly = !true;
                txt_genero_cliente.ReadOnly = !true;
                txt_pelicula_cliente.ReadOnly = !true;
                txt_precio_cliente.ReadOnly = !true;
                txt_anio_cliente.Clear();
                txt_director_cliente.Clear();
                txt_genero_cliente.Clear();
                txt_pelicula_cliente.Clear();
                txt_precio_cliente.Clear();
            }
            else
            {
                rbtn_Alquiler.Checked = true;
                btn_alquilar.Enabled = true;
                btn_Restaurar.Enabled = !true;
                btn_Buscar.Enabled = !true;
                txt_actor_cliente.ReadOnly = true;
                txt_anio_cliente.ReadOnly = true;
                txt_director_cliente.ReadOnly = true;
                txt_genero_cliente.ReadOnly = true;
                txt_pelicula_cliente.ReadOnly = true;
                txt_precio_cliente.ReadOnly = true;
            }
        }

        private void btn_VerPelicula_Click(object sender, EventArgs e)
        {
            cPelicula.Actualizar(Inicio.lista_peliculas);
            cPelicula aux = null;
            aux =Cliente_Activo.peliculas_alquiladas.Find( x => x.Nombre.Contains(txt_peliculaver.Text));
            if (aux != null)
            {
                aux.Vistos_Anio++;
                aux.Vistos_Mes++;
                MessageBox.Show("Viendo " + aux.Nombre, "Craicnet - Ver Pelicula");
            }
            //sumar vistos pelicula seleccionada
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tab_Peliculas_Selected(object sender, TabControlEventArgs e)
        {
            if (tab_Peliculas.SelectedTab == tabp_peliculas )
            {
                label3.Hide();
                split_alquilar.Show();
                groupBox_cliente.Hide();
            }
            if (tab_Peliculas.SelectedTab == tabp_promo)
            {
                label3.Hide();
                cPromo.Actualizar_promociones();
                grid_promociones_cliente.EndEdit();
                grid_promociones_cliente.ResetBindings();
                split_alquilar.Show();
                groupBox_cliente.Hide();
            }
            if (tab_Peliculas.SelectedTab == tabp_alq)
            {
                // split_alquilar.Hide();
                label3.Show();
                Cliente_Activo.Actualizar_peliculas_alquiladas();
                grid_alq.EndEdit();
                grid_alq.ResetBindings();
                groupBox_cliente.Show();
                groupBox_cliente.BringToFront();
            }
        }

        private void tab_Peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grid_alq_SelectionChanged_1(object sender, EventArgs e)
        {
            

            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in grid_alq.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_peliculaver.Text = row.Cells[0].Value.ToString();

            }
        }

        private void pict_like_Click(object sender, EventArgs e)
        {
            
            cPelicula aux = null;
            aux = Cliente_Activo.peliculas_alquiladas.Find(x => x.Nombre.Contains(txt_peliculaver.Text));
            if (aux != null)
            {
                if (aux.Puntaje < 10)
                    aux.Puntaje++;
            }
            grid_alq.EndEdit();
            grid_alq.ResetBindings();

        }

        private void pic_unlike_Click(object sender, EventArgs e)
        {
            cPelicula aux = null;
            aux = Cliente_Activo.peliculas_alquiladas.Find(x => x.Nombre.Contains(txt_peliculaver.Text));
            if (aux != null)
            {
                if (aux.Puntaje > 1)
                    aux.Puntaje--;
            }
            grid_alq.EndEdit();
            grid_alq.ResetBindings();

        }
    }
}