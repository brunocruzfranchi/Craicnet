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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid_peliculas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox_agregar = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_director = new System.Windows.Forms.TextBox();
            this.txt_actores = new System.Windows.Forms.TextBox();
            this.txt_pelicula = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbox_promocion = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).BeginInit();
            this.groupbox_agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.agregarEliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarEliminarToolStripMenuItem.Text = "Agregar/Eliminar";
            this.agregarEliminarToolStripMenuItem.Click += new System.EventHandler(this.agregarEliminarToolStripMenuItem_Click);
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            this.promocionesToolStripMenuItem.Click += new System.EventHandler(this.promocionesToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // grid_peliculas
            // 
            this.grid_peliculas.AllowUserToAddRows = false;
            this.grid_peliculas.AllowUserToDeleteRows = false;
            this.grid_peliculas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Director,
            this.Precio,
            this.Genero,
            this.Año,
            this.Puntaje,
            this.Actor,
            this.Sinopsis});
            this.grid_peliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_peliculas.Location = new System.Drawing.Point(0, 0);
            this.grid_peliculas.Name = "grid_peliculas";
            this.grid_peliculas.ReadOnly = true;
            this.grid_peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_peliculas.Size = new System.Drawing.Size(651, 498);
            this.grid_peliculas.TabIndex = 0;
            this.grid_peliculas.SelectionChanged += new System.EventHandler(this.grid_peliculas_SelectionChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 25F;
            this.Nombre.HeaderText = "Pelicula";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Director.DataPropertyName = "Director";
            this.Director.FillWeight = 18F;
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 10F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genero.DataPropertyName = "Genero";
            this.Genero.FillWeight = 10F;
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Año.DataPropertyName = "Año";
            this.Año.FillWeight = 10F;
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puntaje.DataPropertyName = "Puntaje";
            this.Puntaje.FillWeight = 15F;
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // Actor
            // 
            this.Actor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Actor.DataPropertyName = "Actores";
            this.Actor.FillWeight = 25F;
            this.Actor.HeaderText = "Actor/Actriz Principal";
            this.Actor.Name = "Actor";
            this.Actor.ReadOnly = true;
            // 
            // Sinopsis
            // 
            this.Sinopsis.DataPropertyName = "Sinopsis";
            this.Sinopsis.HeaderText = "Sinopsis";
            this.Sinopsis.Name = "Sinopsis";
            this.Sinopsis.ReadOnly = true;
            this.Sinopsis.Visible = false;
            // 
            // groupbox_agregar
            // 
            this.groupbox_agregar.AutoSize = true;
            this.groupbox_agregar.Controls.Add(this.button2);
            this.groupbox_agregar.Controls.Add(this.label11);
            this.groupbox_agregar.Controls.Add(this.label12);
            this.groupbox_agregar.Controls.Add(this.label13);
            this.groupbox_agregar.Controls.Add(this.label14);
            this.groupbox_agregar.Controls.Add(this.label15);
            this.groupbox_agregar.Controls.Add(this.button1);
            this.groupbox_agregar.Controls.Add(this.txt_año);
            this.groupbox_agregar.Controls.Add(this.txt_genero);
            this.groupbox_agregar.Controls.Add(this.txt_director);
            this.groupbox_agregar.Controls.Add(this.txt_actores);
            this.groupbox_agregar.Controls.Add(this.txt_pelicula);
            this.groupbox_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbox_agregar.Location = new System.Drawing.Point(0, 0);
            this.groupbox_agregar.Name = "groupbox_agregar";
            this.groupbox_agregar.Size = new System.Drawing.Size(377, 498);
            this.groupbox_agregar.TabIndex = 0;
            this.groupbox_agregar.TabStop = false;
            this.groupbox_agregar.Text = "Agregar/Eliminar";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(199, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(46, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Actores";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(69, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Año";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(46, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Genero";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(44, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Director";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(45, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Pelicula";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(118, 187);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(175, 20);
            this.txt_año.TabIndex = 9;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(118, 154);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(175, 20);
            this.txt_genero.TabIndex = 8;
            // 
            // txt_director
            // 
            this.txt_director.Location = new System.Drawing.Point(118, 121);
            this.txt_director.Name = "txt_director";
            this.txt_director.Size = new System.Drawing.Size(175, 20);
            this.txt_director.TabIndex = 7;
            // 
            // txt_actores
            // 
            this.txt_actores.Location = new System.Drawing.Point(118, 88);
            this.txt_actores.Name = "txt_actores";
            this.txt_actores.Size = new System.Drawing.Size(175, 20);
            this.txt_actores.TabIndex = 6;
            // 
            // txt_pelicula
            // 
            this.txt_pelicula.Location = new System.Drawing.Point(118, 55);
            this.txt_pelicula.Name = "txt_pelicula";
            this.txt_pelicula.Size = new System.Drawing.Size(175, 20);
            this.txt_pelicula.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grid_peliculas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbox_promocion);
            this.splitContainer1.Panel2.Controls.Add(this.groupbox_agregar);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 498);
            this.splitContainer1.SplitterDistance = 651;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbox_promocion
            // 
            this.gbox_promocion.AutoSize = true;
            this.gbox_promocion.Controls.Add(this.button3);
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
            this.gbox_promocion.Size = new System.Drawing.Size(377, 498);
            this.gbox_promocion.TabIndex = 1;
            this.gbox_promocion.TabStop = false;
            this.gbox_promocion.Text = "Promoción";
            this.gbox_promocion.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(49, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Poner en promoción";
            this.button3.UseVisualStyleBackColor = true;
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
            this.gbox_agregar.Controls.Add(this.splitContainer1);
            this.gbox_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_agregar.Location = new System.Drawing.Point(0, 24);
            this.gbox_agregar.Name = "gbox_agregar";
            this.gbox_agregar.Size = new System.Drawing.Size(1038, 517);
            this.gbox_agregar.TabIndex = 2;
            this.gbox_agregar.TabStop = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 541);
            this.Controls.Add(this.gbox_agregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).EndInit();
            this.groupbox_agregar.ResumeLayout(false);
            this.groupbox_agregar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView grid_peliculas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbox_agregar;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.TextBox txt_actores;
        private System.Windows.Forms.TextBox txt_pelicula;
        public System.Windows.Forms.GroupBox groupbox_agregar;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinopsis;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}