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
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupbox_agregar = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbox_agregar = new System.Windows.Forms.GroupBox();
            this.gbox_promocion = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbox_agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEliminarToolStripMenuItem,
            this.promocionesToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
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
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Actor,
            this.Director,
            this.Genero,
            this.Año});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupbox_agregar
            // 
            this.groupbox_agregar.AutoSize = true;
            this.groupbox_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbox_agregar.Location = new System.Drawing.Point(0, 0);
            this.groupbox_agregar.Name = "groupbox_agregar";
            this.groupbox_agregar.Size = new System.Drawing.Size(300, 498);
            this.groupbox_agregar.TabIndex = 0;
            this.groupbox_agregar.TabStop = false;
            this.groupbox_agregar.Text = "Agregar/Eliminar";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbox_promocion);
            this.splitContainer1.Panel2.Controls.Add(this.groupbox_agregar);
            this.splitContainer1.Size = new System.Drawing.Size(834, 498);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbox_agregar
            // 
            this.gbox_agregar.AutoSize = true;
            this.gbox_agregar.Controls.Add(this.splitContainer1);
            this.gbox_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_agregar.Enabled = false;
            this.gbox_agregar.Location = new System.Drawing.Point(0, 24);
            this.gbox_agregar.Name = "gbox_agregar";
            this.gbox_agregar.Size = new System.Drawing.Size(840, 517);
            this.gbox_agregar.TabIndex = 2;
            this.gbox_agregar.TabStop = false;
            // 
            // gbox_promocion
            // 
            this.gbox_promocion.AutoSize = true;
            this.gbox_promocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_promocion.Location = new System.Drawing.Point(0, 0);
            this.gbox_promocion.Name = "gbox_promocion";
            this.gbox_promocion.Size = new System.Drawing.Size(300, 498);
            this.gbox_promocion.TabIndex = 1;
            this.gbox_promocion.TabStop = false;
            this.gbox_promocion.Text = "Promoción";
            this.gbox_promocion.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.FillWeight = 25F;
            this.Nombre.HeaderText = "Pelicula";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Actor
            // 
            this.Actor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Actor.FillWeight = 25F;
            this.Actor.HeaderText = "Actor/Actriz Principal";
            this.Actor.Name = "Actor";
            this.Actor.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 541);
            this.Controls.Add(this.gbox_agregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbox_agregar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupbox_agregar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbox_agregar;
        private System.Windows.Forms.GroupBox gbox_promocion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
    }
}