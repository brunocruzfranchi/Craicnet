namespace TPFINAL_Craicnet
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.label_Tipo = new System.Windows.Forms.Label();
            this.cbox_tipo = new System.Windows.Forms.ComboBox();
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1624, 724);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Usuario.Location = new System.Drawing.Point(317, 105);
            this.label_Usuario.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(144, 39);
            this.label_Usuario.TabIndex = 1;
            this.label_Usuario.Text = "Usuario:";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Contraseña.Location = new System.Drawing.Point(317, 179);
            this.label_Contraseña.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(202, 39);
            this.label_Contraseña.TabIndex = 2;
            this.label_Contraseña.Text = "Contraseña:";
            // 
            // label_Tipo
            // 
            this.label_Tipo.AutoSize = true;
            this.label_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Tipo.Location = new System.Drawing.Point(317, 296);
            this.label_Tipo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Tipo.Name = "label_Tipo";
            this.label_Tipo.Size = new System.Drawing.Size(93, 39);
            this.label_Tipo.TabIndex = 3;
            this.label_Tipo.Text = "Tipo:";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.FormattingEnabled = true;
            this.cbox_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.cbox_tipo.Location = new System.Drawing.Point(488, 300);
            this.cbox_tipo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(380, 39);
            this.cbox_tipo.TabIndex = 4;
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(931, 274);
            this.btn_iniciar_sesion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(389, 98);
            this.btn_iniciar_sesion.TabIndex = 5;
            this.btn_iniciar_sesion.Text = "Iniciar Sesión";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = true;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(608, 105);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(705, 38);
            this.txt_usuario.TabIndex = 6;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(608, 179);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(705, 38);
            this.txt_contraseña.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_usuario);
            this.splitContainer1.Panel2.Controls.Add(this.txt_contraseña);
            this.splitContainer1.Panel2.Controls.Add(this.label_Usuario);
            this.splitContainer1.Panel2.Controls.Add(this.label_Contraseña);
            this.splitContainer1.Panel2.Controls.Add(this.btn_iniciar_sesion);
            this.splitContainer1.Panel2.Controls.Add(this.label_Tipo);
            this.splitContainer1.Panel2.Controls.Add(this.cbox_tipo);
            this.splitContainer1.Size = new System.Drawing.Size(1624, 1216);
            this.splitContainer1.SplitterDistance = 724;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 8;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1216);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.Label label_Tipo;
        private System.Windows.Forms.ComboBox cbox_tipo;
        private System.Windows.Forms.Button btn_iniciar_sesion;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

