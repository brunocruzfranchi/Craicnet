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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_UsuarioNuevo = new System.Windows.Forms.TextBox();
            this.radio_Admin = new System.Windows.Forms.RadioButton();
            this.radio_Cliente = new System.Windows.Forms.RadioButton();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_verificacion = new System.Windows.Forms.TextBox();
            this.txt_ContraseñaNueva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStrip_Inicio = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.StatusStrip_Inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Usuario.Location = new System.Drawing.Point(264, 136);
            this.label_Usuario.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(86, 39);
            this.label_Usuario.TabIndex = 1;
            this.label_Usuario.Text = "DNI:";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Contraseña.Location = new System.Drawing.Point(264, 210);
            this.label_Contraseña.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(202, 39);
            this.label_Contraseña.TabIndex = 2;
            this.label_Contraseña.Text = "Contraseña:";
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(877, 305);
            this.btn_iniciar_sesion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(389, 98);
            this.btn_iniciar_sesion.TabIndex = 5;
            this.btn_iniciar_sesion.Text = "Iniciar Sesión";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = true;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            this.btn_iniciar_sesion.MouseLeave += new System.EventHandler(this.btn_iniciar_sesion_MouseLeave);
            this.btn_iniciar_sesion.MouseHover += new System.EventHandler(this.btn_iniciar_sesion_MouseHover);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(555, 136);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(705, 38);
            this.txt_usuario.TabIndex = 6;
            this.txt_usuario.MouseLeave += new System.EventHandler(this.txt_usuario_MouseLeave);
            this.txt_usuario.MouseHover += new System.EventHandler(this.txt_usuario_MouseHover);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(555, 210);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(705, 38);
            this.txt_contraseña.TabIndex = 7;
            this.txt_contraseña.MouseLeave += new System.EventHandler(this.txt_contraseña_MouseLeave);
            this.txt_contraseña.MouseHover += new System.EventHandler(this.txt_contraseña_MouseHover);
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.Panel2.Controls.Add(this.txt_usuario);
            this.splitContainer1.Panel2.Controls.Add(this.txt_contraseña);
            this.splitContainer1.Panel2.Controls.Add(this.label_Usuario);
            this.splitContainer1.Panel2.Controls.Add(this.label_Contraseña);
            this.splitContainer1.Panel2.Controls.Add(this.btn_iniciar_sesion);
            this.splitContainer1.Size = new System.Drawing.Size(1733, 1333);
            this.splitContainer1.SplitterDistance = 786;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1733, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.splitContainer2.Panel2.Controls.Add(this.txt_UsuarioNuevo);
            this.splitContainer2.Panel2.Controls.Add(this.radio_Admin);
            this.splitContainer2.Panel2.Controls.Add(this.radio_Cliente);
            this.splitContainer2.Panel2.Controls.Add(this.btn_registrar);
            this.splitContainer2.Panel2.Controls.Add(this.txt_verificacion);
            this.splitContainer2.Panel2.Controls.Add(this.txt_ContraseñaNueva);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(2912, 1333);
            this.splitContainer2.SplitterDistance = 1733;
            this.splitContainer2.SplitterWidth = 11;
            this.splitContainer2.TabIndex = 9;
            // 
            // txt_UsuarioNuevo
            // 
            this.txt_UsuarioNuevo.Location = new System.Drawing.Point(392, 527);
            this.txt_UsuarioNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UsuarioNuevo.Name = "txt_UsuarioNuevo";
            this.txt_UsuarioNuevo.Size = new System.Drawing.Size(495, 38);
            this.txt_UsuarioNuevo.TabIndex = 17;
            // 
            // radio_Admin
            // 
            this.radio_Admin.AutoSize = true;
            this.radio_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Admin.Location = new System.Drawing.Point(533, 391);
            this.radio_Admin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radio_Admin.Name = "radio_Admin";
            this.radio_Admin.Size = new System.Drawing.Size(255, 42);
            this.radio_Admin.TabIndex = 16;
            this.radio_Admin.Text = "Administrador";
            this.radio_Admin.UseVisualStyleBackColor = true;
            this.radio_Admin.CheckedChanged += new System.EventHandler(this.radio_Admin_CheckedChanged);
            // 
            // radio_Cliente
            // 
            this.radio_Cliente.AutoSize = true;
            this.radio_Cliente.Checked = true;
            this.radio_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Cliente.Location = new System.Drawing.Point(248, 391);
            this.radio_Cliente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radio_Cliente.Name = "radio_Cliente";
            this.radio_Cliente.Size = new System.Drawing.Size(155, 42);
            this.radio_Cliente.TabIndex = 15;
            this.radio_Cliente.TabStop = true;
            this.radio_Cliente.Text = "Cliente";
            this.radio_Cliente.UseVisualStyleBackColor = true;
            this.radio_Cliente.CheckedChanged += new System.EventHandler(this.radio_Cliente_CheckedChanged);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_registrar.Location = new System.Drawing.Point(144, 937);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(744, 107);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "Registrate";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_verificacion
            // 
            this.txt_verificacion.Enabled = false;
            this.txt_verificacion.Location = new System.Drawing.Point(392, 680);
            this.txt_verificacion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_verificacion.Name = "txt_verificacion";
            this.txt_verificacion.PasswordChar = '*';
            this.txt_verificacion.Size = new System.Drawing.Size(495, 38);
            this.txt_verificacion.TabIndex = 13;
            // 
            // txt_ContraseñaNueva
            // 
            this.txt_ContraseñaNueva.Location = new System.Drawing.Point(392, 603);
            this.txt_ContraseñaNueva.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_ContraseñaNueva.Name = "txt_ContraseñaNueva";
            this.txt_ContraseñaNueva.PasswordChar = '*';
            this.txt_ContraseñaNueva.Size = new System.Drawing.Size(495, 38);
            this.txt_ContraseñaNueva.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(136, 677);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Verificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(136, 525);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "DNI:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(136, 599);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(131, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear tu cuenta de Craicnet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // StatusStrip_Inicio
            // 
            this.StatusStrip_Inicio.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.StatusStrip_Inicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.StatusStrip_Inicio.Location = new System.Drawing.Point(0, 1311);
            this.StatusStrip_Inicio.Name = "StatusStrip_Inicio";
            this.StatusStrip_Inicio.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.StatusStrip_Inicio.Size = new System.Drawing.Size(2912, 22);
            this.StatusStrip_Inicio.TabIndex = 10;
            this.StatusStrip_Inicio.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2912, 1333);
            this.Controls.Add(this.StatusStrip_Inicio);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Inicio";
            this.Text = "Craicnet";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.StatusStrip_Inicio.ResumeLayout(false);
            this.StatusStrip_Inicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.Button btn_iniciar_sesion;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_verificacion;
        private System.Windows.Forms.TextBox txt_ContraseñaNueva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusStrip_Inicio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radio_Admin;
        private System.Windows.Forms.RadioButton radio_Cliente;
        private System.Windows.Forms.TextBox txt_UsuarioNuevo;
    }
}

