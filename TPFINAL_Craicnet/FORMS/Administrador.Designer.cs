namespace TPFINAL_Craicnet
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupbox_agregar = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.radio_editar = new System.Windows.Forms.RadioButton();
            this.txt_sinopsis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_eliminar = new System.Windows.Forms.RadioButton();
            this.radio_agregar = new System.Windows.Forms.RadioButton();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_director = new System.Windows.Forms.TextBox();
            this.txt_actores = new System.Windows.Forms.TextBox();
            this.txt_pelicula = new System.Windows.Forms.TextBox();
            this.split_promo = new System.Windows.Forms.SplitContainer();
            this.grid_peliculas = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActoresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPeliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbox_promocion = new System.Windows.Forms.GroupBox();
            this.btn_promocion = new System.Windows.Forms.Button();
            this.txt_año_promo = new System.Windows.Forms.TextBox();
            this.txt_genero_promo = new System.Windows.Forms.TextBox();
            this.txt_precio_promo = new System.Windows.Forms.TextBox();
            this.txt_director_promo = new System.Windows.Forms.TextBox();
            this.txt_pelicula_promo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbox_agregar = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupbox_agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_promo)).BeginInit();
            this.split_promo.Panel1.SuspendLayout();
            this.split_promo.Panel2.SuspendLayout();
            this.split_promo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPeliculaBindingSource)).BeginInit();
            this.gbox_promocion.SuspendLayout();
            this.gbox_agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEliminarToolStripMenuItem,
            this.promocionesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // agregarEliminarToolStripMenuItem
            // 
            this.agregarEliminarToolStripMenuItem.Name = "agregarEliminarToolStripMenuItem";
            this.agregarEliminarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agregarEliminarToolStripMenuItem.Text = "Agregar/Eliminar";
            this.agregarEliminarToolStripMenuItem.Click += new System.EventHandler(this.agregarEliminarToolStripMenuItem_Click);
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            this.promocionesToolStripMenuItem.Click += new System.EventHandler(this.promocionesToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // groupbox_agregar
            // 
            this.groupbox_agregar.AutoSize = true;
            this.groupbox_agregar.Controls.Add(this.btn_editar);
            this.groupbox_agregar.Controls.Add(this.radio_editar);
            this.groupbox_agregar.Controls.Add(this.txt_sinopsis);
            this.groupbox_agregar.Controls.Add(this.label2);
            this.groupbox_agregar.Controls.Add(this.txt_precio);
            this.groupbox_agregar.Controls.Add(this.label1);
            this.groupbox_agregar.Controls.Add(this.radio_eliminar);
            this.groupbox_agregar.Controls.Add(this.radio_agregar);
            this.groupbox_agregar.Controls.Add(this.btn_eliminar);
            this.groupbox_agregar.Controls.Add(this.label11);
            this.groupbox_agregar.Controls.Add(this.label12);
            this.groupbox_agregar.Controls.Add(this.label13);
            this.groupbox_agregar.Controls.Add(this.label14);
            this.groupbox_agregar.Controls.Add(this.label15);
            this.groupbox_agregar.Controls.Add(this.btn_Agregar);
            this.groupbox_agregar.Controls.Add(this.txt_año);
            this.groupbox_agregar.Controls.Add(this.txt_genero);
            this.groupbox_agregar.Controls.Add(this.txt_director);
            this.groupbox_agregar.Controls.Add(this.txt_actores);
            this.groupbox_agregar.Controls.Add(this.txt_pelicula);
            this.groupbox_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbox_agregar.Location = new System.Drawing.Point(0, 0);
            this.groupbox_agregar.Name = "groupbox_agregar";
            this.groupbox_agregar.Size = new System.Drawing.Size(377, 536);
            this.groupbox_agregar.TabIndex = 0;
            this.groupbox_agregar.TabStop = false;
            this.groupbox_agregar.Text = "Agregar/Eliminar";
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_editar.Location = new System.Drawing.Point(147, 454);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(88, 40);
            this.btn_editar.TabIndex = 24;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // radio_editar
            // 
            this.radio_editar.AutoSize = true;
            this.radio_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_editar.Location = new System.Drawing.Point(158, 38);
            this.radio_editar.Name = "radio_editar";
            this.radio_editar.Size = new System.Drawing.Size(63, 21);
            this.radio_editar.TabIndex = 23;
            this.radio_editar.Text = "Editar";
            this.radio_editar.UseVisualStyleBackColor = true;
            this.radio_editar.CheckedChanged += new System.EventHandler(this.radio_editar_CheckedChanged);
            // 
            // txt_sinopsis
            // 
            this.txt_sinopsis.Location = new System.Drawing.Point(135, 307);
            this.txt_sinopsis.Multiline = true;
            this.txt_sinopsis.Name = "txt_sinopsis";
            this.txt_sinopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sinopsis.Size = new System.Drawing.Size(176, 95);
            this.txt_sinopsis.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(57, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sinopsis";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(135, 168);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(175, 20);
            this.txt_precio.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(68, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Precio";
            // 
            // radio_eliminar
            // 
            this.radio_eliminar.AutoSize = true;
            this.radio_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_eliminar.Location = new System.Drawing.Point(247, 38);
            this.radio_eliminar.Name = "radio_eliminar";
            this.radio_eliminar.Size = new System.Drawing.Size(76, 21);
            this.radio_eliminar.TabIndex = 18;
            this.radio_eliminar.Text = "Eliminar";
            this.radio_eliminar.UseVisualStyleBackColor = true;
            this.radio_eliminar.CheckedChanged += new System.EventHandler(this.radio_eliminar_CheckedChanged);
            // 
            // radio_agregar
            // 
            this.radio_agregar.AutoSize = true;
            this.radio_agregar.Checked = true;
            this.radio_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_agregar.Location = new System.Drawing.Point(55, 38);
            this.radio_agregar.Name = "radio_agregar";
            this.radio_agregar.Size = new System.Drawing.Size(77, 21);
            this.radio_agregar.TabIndex = 17;
            this.radio_agregar.TabStop = true;
            this.radio_agregar.Text = "Agregar";
            this.radio_agregar.UseVisualStyleBackColor = true;
            this.radio_agregar.CheckedChanged += new System.EventHandler(this.radio_agregar_CheckedChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(248, 454);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(88, 40);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(60, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Actores";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(83, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Año";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(60, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Genero";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(58, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Director";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(59, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Pelicula";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(46, 454);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(88, 40);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(135, 239);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(175, 20);
            this.txt_año.TabIndex = 9;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(135, 202);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(175, 20);
            this.txt_genero.TabIndex = 8;
            // 
            // txt_director
            // 
            this.txt_director.Location = new System.Drawing.Point(135, 136);
            this.txt_director.Name = "txt_director";
            this.txt_director.Size = new System.Drawing.Size(175, 20);
            this.txt_director.TabIndex = 7;
            // 
            // txt_actores
            // 
            this.txt_actores.Location = new System.Drawing.Point(135, 272);
            this.txt_actores.Name = "txt_actores";
            this.txt_actores.Size = new System.Drawing.Size(175, 20);
            this.txt_actores.TabIndex = 6;
            // 
            // txt_pelicula
            // 
            this.txt_pelicula.Location = new System.Drawing.Point(135, 100);
            this.txt_pelicula.Name = "txt_pelicula";
            this.txt_pelicula.Size = new System.Drawing.Size(175, 20);
            this.txt_pelicula.TabIndex = 5;
            // 
            // split_promo
            // 
            this.split_promo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_promo.Location = new System.Drawing.Point(3, 16);
            this.split_promo.Name = "split_promo";
            // 
            // split_promo.Panel1
            // 
            this.split_promo.Panel1.Controls.Add(this.grid_peliculas);
            // 
            // split_promo.Panel2
            // 
            this.split_promo.Panel2.Controls.Add(this.groupbox_agregar);
            this.split_promo.Panel2.Controls.Add(this.gbox_promocion);
            this.split_promo.Size = new System.Drawing.Size(1032, 536);
            this.split_promo.SplitterDistance = 651;
            this.split_promo.TabIndex = 1;
            // 
            // grid_peliculas
            // 
            this.grid_peliculas.AllowUserToAddRows = false;
            this.grid_peliculas.AllowUserToDeleteRows = false;
            this.grid_peliculas.AutoGenerateColumns = false;
            this.grid_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.DirectorColumn,
            this.PrecioColumn,
            this.PuntajeColumn,
            this.GeneroColumn,
            this.añoColumn,
            this.ActoresColumn,
            this.sinopsisDataGridViewTextBoxColumn});
            this.grid_peliculas.DataSource = this.cPeliculaBindingSource;
            this.grid_peliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_peliculas.Location = new System.Drawing.Point(0, 0);
            this.grid_peliculas.Name = "grid_peliculas";
            this.grid_peliculas.ReadOnly = true;
            this.grid_peliculas.Size = new System.Drawing.Size(651, 536);
            this.grid_peliculas.TabIndex = 0;
            this.grid_peliculas.SelectionChanged += new System.EventHandler(this.grid_peliculas_SelectionChanged);
            // 
            // NombreColumn
            // 
            this.NombreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreColumn.DataPropertyName = "Nombre";
            this.NombreColumn.FillWeight = 20F;
            this.NombreColumn.HeaderText = "Peliculas";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // DirectorColumn
            // 
            this.DirectorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectorColumn.DataPropertyName = "Director";
            this.DirectorColumn.FillWeight = 15F;
            this.DirectorColumn.HeaderText = "Director";
            this.DirectorColumn.Name = "DirectorColumn";
            this.DirectorColumn.ReadOnly = true;
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioColumn.DataPropertyName = "Precio";
            this.PrecioColumn.FillWeight = 10F;
            this.PrecioColumn.HeaderText = "Precio";
            this.PrecioColumn.Name = "PrecioColumn";
            this.PrecioColumn.ReadOnly = true;
            // 
            // PuntajeColumn
            // 
            this.PuntajeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuntajeColumn.DataPropertyName = "Puntaje";
            this.PuntajeColumn.FillWeight = 13F;
            this.PuntajeColumn.HeaderText = "Me Gusta";
            this.PuntajeColumn.Name = "PuntajeColumn";
            this.PuntajeColumn.ReadOnly = true;
            // 
            // GeneroColumn
            // 
            this.GeneroColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GeneroColumn.DataPropertyName = "Genero";
            this.GeneroColumn.FillWeight = 15F;
            this.GeneroColumn.HeaderText = "Genero";
            this.GeneroColumn.Name = "GeneroColumn";
            this.GeneroColumn.ReadOnly = true;
            // 
            // añoColumn
            // 
            this.añoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.añoColumn.DataPropertyName = "Año";
            this.añoColumn.FillWeight = 10F;
            this.añoColumn.HeaderText = "Año";
            this.añoColumn.Name = "añoColumn";
            this.añoColumn.ReadOnly = true;
            // 
            // ActoresColumn
            // 
            this.ActoresColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActoresColumn.DataPropertyName = "Actores";
            this.ActoresColumn.FillWeight = 18F;
            this.ActoresColumn.HeaderText = "Actores";
            this.ActoresColumn.Name = "ActoresColumn";
            this.ActoresColumn.ReadOnly = true;
            // 
            // sinopsisDataGridViewTextBoxColumn
            // 
            this.sinopsisDataGridViewTextBoxColumn.DataPropertyName = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.Name = "sinopsisDataGridViewTextBoxColumn";
            this.sinopsisDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinopsisDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPeliculaBindingSource
            // 
            this.cPeliculaBindingSource.DataSource = typeof(TPFINAL_Craicnet.cPelicula);
            // 
            // gbox_promocion
            // 
            this.gbox_promocion.AutoSize = true;
            this.gbox_promocion.Controls.Add(this.btn_promocion);
            this.gbox_promocion.Controls.Add(this.txt_año_promo);
            this.gbox_promocion.Controls.Add(this.txt_genero_promo);
            this.gbox_promocion.Controls.Add(this.txt_precio_promo);
            this.gbox_promocion.Controls.Add(this.txt_director_promo);
            this.gbox_promocion.Controls.Add(this.txt_pelicula_promo);
            this.gbox_promocion.Controls.Add(this.label10);
            this.gbox_promocion.Controls.Add(this.label6);
            this.gbox_promocion.Controls.Add(this.label7);
            this.gbox_promocion.Controls.Add(this.label8);
            this.gbox_promocion.Controls.Add(this.label9);
            this.gbox_promocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_promocion.Location = new System.Drawing.Point(0, 0);
            this.gbox_promocion.Name = "gbox_promocion";
            this.gbox_promocion.Size = new System.Drawing.Size(377, 536);
            this.gbox_promocion.TabIndex = 1;
            this.gbox_promocion.TabStop = false;
            this.gbox_promocion.Text = "Promoción";
            this.gbox_promocion.Visible = false;
            // 
            // btn_promocion
            // 
            this.btn_promocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_promocion.Location = new System.Drawing.Point(49, 307);
            this.btn_promocion.Name = "btn_promocion";
            this.btn_promocion.Size = new System.Drawing.Size(285, 35);
            this.btn_promocion.TabIndex = 15;
            this.btn_promocion.Text = "Poner en promoción";
            this.btn_promocion.UseVisualStyleBackColor = true;
            this.btn_promocion.Click += new System.EventHandler(this.btn_promocion_Click);
            // 
            // txt_año_promo
            // 
            this.txt_año_promo.Enabled = false;
            this.txt_año_promo.Location = new System.Drawing.Point(123, 260);
            this.txt_año_promo.Name = "txt_año_promo";
            this.txt_año_promo.Size = new System.Drawing.Size(188, 20);
            this.txt_año_promo.TabIndex = 14;
            // 
            // txt_genero_promo
            // 
            this.txt_genero_promo.Enabled = false;
            this.txt_genero_promo.Location = new System.Drawing.Point(123, 227);
            this.txt_genero_promo.Name = "txt_genero_promo";
            this.txt_genero_promo.Size = new System.Drawing.Size(188, 20);
            this.txt_genero_promo.TabIndex = 13;
            // 
            // txt_precio_promo
            // 
            this.txt_precio_promo.Location = new System.Drawing.Point(123, 194);
            this.txt_precio_promo.Name = "txt_precio_promo";
            this.txt_precio_promo.Size = new System.Drawing.Size(188, 20);
            this.txt_precio_promo.TabIndex = 12;
            // 
            // txt_director_promo
            // 
            this.txt_director_promo.Enabled = false;
            this.txt_director_promo.Location = new System.Drawing.Point(123, 161);
            this.txt_director_promo.Name = "txt_director_promo";
            this.txt_director_promo.Size = new System.Drawing.Size(188, 20);
            this.txt_director_promo.TabIndex = 11;
            // 
            // txt_pelicula_promo
            // 
            this.txt_pelicula_promo.Enabled = false;
            this.txt_pelicula_promo.Location = new System.Drawing.Point(123, 128);
            this.txt_pelicula_promo.Name = "txt_pelicula_promo";
            this.txt_pelicula_promo.Size = new System.Drawing.Size(188, 20);
            this.txt_pelicula_promo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(56, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(71, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(50, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Genero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(46, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Director";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(47, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Pelicula";
            // 
            // gbox_agregar
            // 
            this.gbox_agregar.AutoSize = true;
            this.gbox_agregar.Controls.Add(this.split_promo);
            this.gbox_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_agregar.Location = new System.Drawing.Point(0, 24);
            this.gbox_agregar.Name = "gbox_agregar";
            this.gbox_agregar.Size = new System.Drawing.Size(1038, 555);
            this.gbox_agregar.TabIndex = 2;
            this.gbox_agregar.TabStop = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 579);
            this.Controls.Add(this.gbox_agregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupbox_agregar.ResumeLayout(false);
            this.groupbox_agregar.PerformLayout();
            this.split_promo.Panel1.ResumeLayout(false);
            this.split_promo.Panel2.ResumeLayout(false);
            this.split_promo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_promo)).EndInit();
            this.split_promo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPeliculaBindingSource)).EndInit();
            this.gbox_promocion.ResumeLayout(false);
            this.gbox_promocion.PerformLayout();
            this.gbox_agregar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer split_promo;
        private System.Windows.Forms.GroupBox gbox_agregar;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.TextBox txt_actores;
        private System.Windows.Forms.TextBox txt_pelicula;
        public System.Windows.Forms.GroupBox groupbox_agregar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.GroupBox gbox_promocion;
        private System.Windows.Forms.TextBox txt_año_promo;
        private System.Windows.Forms.TextBox txt_genero_promo;
        private System.Windows.Forms.TextBox txt_precio_promo;
        private System.Windows.Forms.TextBox txt_director_promo;
        private System.Windows.Forms.TextBox txt_pelicula_promo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_promocion;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.DataGridView grid_peliculas;
        private System.Windows.Forms.BindingSource cPeliculaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActoresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radio_eliminar;
        private System.Windows.Forms.RadioButton radio_agregar;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.RadioButton radio_editar;
        private System.Windows.Forms.TextBox txt_sinopsis;
        private System.Windows.Forms.Label label2;
    }
}