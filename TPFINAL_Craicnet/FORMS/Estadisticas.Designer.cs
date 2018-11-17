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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart_alq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_anual_alq = new System.Windows.Forms.RadioButton();
            this.rbtn_mensual_alq = new System.Windows.Forms.RadioButton();
            this.chart_vistos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_anual_vist = new System.Windows.Forms.RadioButton();
            this.rbtn_mensual_vist = new System.Windows.Forms.RadioButton();
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
            this.splitContainer1.Panel1.Controls.Add(this.chart_alq);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.rbtn_anual_alq);
            this.splitContainer1.Panel1.Controls.Add(this.rbtn_mensual_alq);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart_vistos);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.rbtn_anual_vist);
            this.splitContainer1.Panel2.Controls.Add(this.rbtn_mensual_vist);
            this.splitContainer1.Size = new System.Drawing.Size(1889, 1126);
            this.splitContainer1.SplitterDistance = 925;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart_alq
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_alq.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_alq.Legends.Add(legend1);
            this.chart_alq.Location = new System.Drawing.Point(114, 395);
            this.chart_alq.Name = "chart_alq";
            this.chart_alq.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Alq_mes";
            this.chart_alq.Series.Add(series1);
            this.chart_alq.Size = new System.Drawing.Size(695, 622);
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
            // rbtn_anual_alq
            // 
            this.rbtn_anual_alq.AutoSize = true;
            this.rbtn_anual_alq.Location = new System.Drawing.Point(525, 169);
            this.rbtn_anual_alq.Name = "rbtn_anual_alq";
            this.rbtn_anual_alq.Size = new System.Drawing.Size(126, 36);
            this.rbtn_anual_alq.TabIndex = 1;
            this.rbtn_anual_alq.TabStop = true;
            this.rbtn_anual_alq.Text = "Anual";
            this.rbtn_anual_alq.UseVisualStyleBackColor = true;
            // 
            // rbtn_mensual_alq
            // 
            this.rbtn_mensual_alq.AutoSize = true;
            this.rbtn_mensual_alq.Location = new System.Drawing.Point(114, 169);
            this.rbtn_mensual_alq.Name = "rbtn_mensual_alq";
            this.rbtn_mensual_alq.Size = new System.Drawing.Size(160, 36);
            this.rbtn_mensual_alq.TabIndex = 0;
            this.rbtn_mensual_alq.TabStop = true;
            this.rbtn_mensual_alq.Text = "Mensual";
            this.rbtn_mensual_alq.UseVisualStyleBackColor = true;
            this.rbtn_mensual_alq.CheckedChanged += new System.EventHandler(this.rbtn_mensual_alq_CheckedChanged);
            // 
            // chart_vistos
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_vistos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_vistos.Legends.Add(legend2);
            this.chart_vistos.Location = new System.Drawing.Point(88, 409);
            this.chart_vistos.Name = "chart_vistos";
            this.chart_vistos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_vistos.Series.Add(series2);
            this.chart_vistos.Size = new System.Drawing.Size(684, 622);
            this.chart_vistos.TabIndex = 3;
            this.chart_vistos.Text = "chart2";
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
            // rbtn_anual_vist
            // 
            this.rbtn_anual_vist.AutoSize = true;
            this.rbtn_anual_vist.Location = new System.Drawing.Point(598, 169);
            this.rbtn_anual_vist.Name = "rbtn_anual_vist";
            this.rbtn_anual_vist.Size = new System.Drawing.Size(126, 36);
            this.rbtn_anual_vist.TabIndex = 1;
            this.rbtn_anual_vist.TabStop = true;
            this.rbtn_anual_vist.Text = "Anual";
            this.rbtn_anual_vist.UseVisualStyleBackColor = true;
            // 
            // rbtn_mensual_vist
            // 
            this.rbtn_mensual_vist.AutoSize = true;
            this.rbtn_mensual_vist.Location = new System.Drawing.Point(178, 169);
            this.rbtn_mensual_vist.Name = "rbtn_mensual_vist";
            this.rbtn_mensual_vist.Size = new System.Drawing.Size(160, 36);
            this.rbtn_mensual_vist.TabIndex = 0;
            this.rbtn_mensual_vist.TabStop = true;
            this.rbtn_mensual_vist.Text = "Mensual";
            this.rbtn_mensual_vist.UseVisualStyleBackColor = true;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1889, 1126);
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
        private System.Windows.Forms.RadioButton rbtn_anual_alq;
        private System.Windows.Forms.RadioButton rbtn_mensual_alq;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_vistos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_anual_vist;
        private System.Windows.Forms.RadioButton rbtn_mensual_vist;
    }
}