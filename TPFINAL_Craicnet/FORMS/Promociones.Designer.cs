namespace TPFINAL_Craicnet.FORMS
{
    partial class Promociones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Promociones_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_alquiler_promo = new System.Windows.Forms.Button();
            this.txt_NombrePromo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Promociones_Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(31, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(827, 625);
            this.dataGridView1.TabIndex = 0;
            // 
            // Promociones_Nombre
            // 
            this.Promociones_Nombre.HeaderText = "Nombre";
            this.Promociones_Nombre.Name = "Promociones_Nombre";
            this.Promociones_Nombre.ReadOnly = true;
            // 
            // btn_alquiler_promo
            // 
            this.btn_alquiler_promo.Location = new System.Drawing.Point(1090, 766);
            this.btn_alquiler_promo.Name = "btn_alquiler_promo";
            this.btn_alquiler_promo.Size = new System.Drawing.Size(401, 98);
            this.btn_alquiler_promo.TabIndex = 1;
            this.btn_alquiler_promo.Text = "button1";
            this.btn_alquiler_promo.UseVisualStyleBackColor = true;
            this.btn_alquiler_promo.Click += new System.EventHandler(this.btn_alquiler_promo_Click);
            // 
            // txt_NombrePromo
            // 
            this.txt_NombrePromo.Location = new System.Drawing.Point(1113, 135);
            this.txt_NombrePromo.Name = "txt_NombrePromo";
            this.txt_NombrePromo.Size = new System.Drawing.Size(100, 38);
            this.txt_NombrePromo.TabIndex = 2;
            // 
            // Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 968);
            this.Controls.Add(this.txt_NombrePromo);
            this.Controls.Add(this.btn_alquiler_promo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Promociones";
            this.Text = "Promociones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promociones_Nombre;
        private System.Windows.Forms.Button btn_alquiler_promo;
        private System.Windows.Forms.TextBox txt_NombrePromo;
    }
}