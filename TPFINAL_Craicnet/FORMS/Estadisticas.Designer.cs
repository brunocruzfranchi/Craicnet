namespace TPFINAL_Craicnet.FORMS
{
    partial class Estadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.combo_alq = new System.Windows.Forms.ComboBox();
            this.chart_alq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_cmp = new System.Windows.Forms.ComboBox();
            this.btn_cmp = new System.Windows.Forms.Button();
            this.combo_vistos = new System.Windows.Forms.ComboBox();
            this.chart_vistos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_alq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vistos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.combo_alq);
            this.splitContainer1.Panel1.Controls.Add(this.chart_alq);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.combo_cmp);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cmp);
            this.splitContainer1.Panel2.Controls.Add(this.combo_vistos);
            this.splitContainer1.Panel2.Controls.Add(this.chart_vistos);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(2880, 1413);
            this.splitContainer1.SplitterDistance = 1410;
            this.splitContainer1.TabIndex = 0;
            // 
            // combo_alq
            // 
            this.combo_alq.FormattingEnabled = true;
            this.combo_alq.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.combo_alq.Location = new System.Drawing.Point(76, 191);
            this.combo_alq.Name = "combo_alq";
            this.combo_alq.Size = new System.Drawing.Size(454, 39);
            this.combo_alq.TabIndex = 4;
            this.combo_alq.Text = "Periodo";
            this.combo_alq.SelectedValueChanged += new System.EventHandler(this.combo_alq_SelectedValueChanged);
            // 
            // chart_alq
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_alq.ChartAreas.Add(chartArea1);
            this.chart_alq.Location = new System.Drawing.Point(58, 320);
            this.chart_alq.Name = "chart_alq";
            this.chart_alq.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Alq_mes";
            this.chart_alq.Series.Add(series1);
            this.chart_alq.Size = new System.Drawing.Size(1205, 871);
            this.chart_alq.TabIndex = 3;
            this.chart_alq.Text = "chart1";
            this.chart_alq.Click += new System.EventHandler(this.chart_alq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peliculas Alquiladas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 1311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comparar rendimiento ordenamiento";
            // 
            // combo_cmp
            // 
            this.combo_cmp.FormattingEnabled = true;
            this.combo_cmp.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.combo_cmp.Location = new System.Drawing.Point(680, 1304);
            this.combo_cmp.Name = "combo_cmp";
            this.combo_cmp.Size = new System.Drawing.Size(341, 39);
            this.combo_cmp.TabIndex = 6;
            this.combo_cmp.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btn_cmp
            // 
            this.btn_cmp.Location = new System.Drawing.Point(1113, 1289);
            this.btn_cmp.Name = "btn_cmp";
            this.btn_cmp.Size = new System.Drawing.Size(259, 61);
            this.btn_cmp.TabIndex = 5;
            this.btn_cmp.Text = "Comparar";
            this.btn_cmp.UseVisualStyleBackColor = true;
            this.btn_cmp.Click += new System.EventHandler(this.btn_cmp_Click);
            // 
            // combo_vistos
            // 
            this.combo_vistos.FormattingEnabled = true;
            this.combo_vistos.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.combo_vistos.Location = new System.Drawing.Point(88, 191);
            this.combo_vistos.Name = "combo_vistos";
            this.combo_vistos.Size = new System.Drawing.Size(454, 39);
            this.combo_vistos.TabIndex = 4;
            this.combo_vistos.Text = "Periodo";
            this.combo_vistos.SelectedIndexChanged += new System.EventHandler(this.combo_anual_SelectedIndexChanged);
            this.combo_vistos.SelectedValueChanged += new System.EventHandler(this.combo_anual_SelectedValueChanged);
            // 
            // chart_vistos
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_vistos.ChartAreas.Add(chartArea2);
            this.chart_vistos.Location = new System.Drawing.Point(58, 320);
            this.chart_vistos.Name = "chart_vistos";
            this.chart_vistos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Vistos";
            this.chart_vistos.Series.Add(series2);
            this.chart_vistos.Size = new System.Drawing.Size(1352, 871);
            this.chart_vistos.TabIndex = 3;
            this.chart_vistos.Text = "chart2";
            this.chart_vistos.Click += new System.EventHandler(this.chart_vistos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peliculas Vistas";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2880, 1413);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_alq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vistos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_alq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_vistos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_alq;
        private System.Windows.Forms.ComboBox combo_vistos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_cmp;
        private System.Windows.Forms.Button btn_cmp;
    }
}