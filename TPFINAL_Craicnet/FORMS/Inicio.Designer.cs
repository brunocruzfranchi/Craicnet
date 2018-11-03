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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 332);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Usuario.Location = new System.Drawing.Point(99, 57);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(61, 17);
            this.label_Usuario.TabIndex = 1;
            this.label_Usuario.Text = "Usuario:";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Contraseña.Location = new System.Drawing.Point(99, 88);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(85, 17);
            this.label_Contraseña.TabIndex = 2;
            this.label_Contraseña.Text = "Contraseña:";
            // 
            // label_Tipo
            // 
            this.label_Tipo.AutoSize = true;
            this.label_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Tipo.Location = new System.Drawing.Point(99, 137);
            this.label_Tipo.Name = "label_Tipo";
            this.label_Tipo.Size = new System.Drawing.Size(40, 17);
            this.label_Tipo.TabIndex = 3;
            this.label_Tipo.Text = "Tipo:";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.FormattingEnabled = true;
            this.cbox_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.cbox_tipo.Location = new System.Drawing.Point(163, 139);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(145, 21);
            this.cbox_tipo.TabIndex = 4;
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(329, 128);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(146, 41);
            this.btn_iniciar_sesion.TabIndex = 5;
            this.btn_iniciar_sesion.Text = "Iniciar Sesión";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = true;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(208, 57);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(267, 20);
            this.txt_usuario.TabIndex = 6;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(208, 88);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(267, 20);
            this.txt_contraseña.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.txt_usuario);
            this.splitContainer1.Panel2.Controls.Add(this.txt_contraseña);
            this.splitContainer1.Panel2.Controls.Add(this.label_Usuario);
            this.splitContainer1.Panel2.Controls.Add(this.label_Contraseña);
            this.splitContainer1.Panel2.Controls.Add(this.btn_iniciar_sesion);
            this.splitContainer1.Panel2.Controls.Add(this.label_Tipo);
            this.splitContainer1.Panel2.Controls.Add(this.cbox_tipo);
            this.splitContainer1.Size = new System.Drawing.Size(574, 559);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.textBox3);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(960, 559);
            this.splitContainer2.SplitterDistance = 574;
            this.splitContainer2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(54, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registrate!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(51, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Verificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(51, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(51, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(40, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear tu cuenta de Craicnet";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 559);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

