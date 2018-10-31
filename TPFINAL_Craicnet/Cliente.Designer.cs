namespace TPFINAL_Craicnet
{
    partial class Cliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.split_alquilar = new System.Windows.Forms.SplitContainer();
            this.gbox_alquilar = new System.Windows.Forms.GroupBox();
            this.gbox_cliente = new System.Windows.Forms.GroupBox();
            this.split_graficos = new System.Windows.Forms.SplitContainer();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_alquilar)).BeginInit();
            this.split_alquilar.Panel2.SuspendLayout();
            this.split_alquilar.SuspendLayout();
            this.gbox_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_graficos)).BeginInit();
            this.split_graficos.Panel1.SuspendLayout();
            this.split_graficos.Panel2.SuspendLayout();
            this.split_graficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promosToolStripMenuItem,
            this.alquilerToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // promosToolStripMenuItem
            // 
            this.promosToolStripMenuItem.Name = "promosToolStripMenuItem";
            this.promosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promosToolStripMenuItem.Text = "Promociones";
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
            this.alquilerToolStripMenuItem.Click += new System.EventHandler(this.alquilerToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // split_alquilar
            // 
            this.split_alquilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_alquilar.Location = new System.Drawing.Point(3, 16);
            this.split_alquilar.Name = "split_alquilar";
            // 
            // split_alquilar.Panel2
            // 
            this.split_alquilar.Panel2.Controls.Add(this.gbox_alquilar);
            this.split_alquilar.Size = new System.Drawing.Size(811, 0);
            this.split_alquilar.SplitterDistance = 432;
            this.split_alquilar.TabIndex = 0;
            // 
            // gbox_alquilar
            // 
            this.gbox_alquilar.AutoSize = true;
            this.gbox_alquilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_alquilar.Location = new System.Drawing.Point(0, 0);
            this.gbox_alquilar.Name = "gbox_alquilar";
            this.gbox_alquilar.Size = new System.Drawing.Size(280, 0);
            this.gbox_alquilar.TabIndex = 0;
            this.gbox_alquilar.TabStop = false;
            this.gbox_alquilar.Text = "Alquilar";
            // 
            // gbox_cliente
            // 
            this.gbox_cliente.AutoSize = true;
            this.gbox_cliente.Controls.Add(this.split_alquilar);
            this.gbox_cliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbox_cliente.Location = new System.Drawing.Point(0, 509);
            this.gbox_cliente.Name = "gbox_cliente";
            this.gbox_cliente.Size = new System.Drawing.Size(817, 19);
            this.gbox_cliente.TabIndex = 1;
            this.gbox_cliente.TabStop = false;
            // 
            // split_graficos
            // 
            this.split_graficos.Location = new System.Drawing.Point(85, 61);
            this.split_graficos.Margin = new System.Windows.Forms.Padding(1);
            this.split_graficos.Name = "split_graficos";
            // 
            // split_graficos.Panel1
            // 
            this.split_graficos.Panel1.Controls.Add(this.radioButton2);
            this.split_graficos.Panel1.Controls.Add(this.radioButton1);
            this.split_graficos.Panel1.Controls.Add(this.chart1);
            // 
            // split_graficos.Panel2
            // 
            this.split_graficos.Panel2.Controls.Add(this.radioButton4);
            this.split_graficos.Panel2.Controls.Add(this.radioButton3);
            this.split_graficos.Panel2.Controls.Add(this.chart2);
            this.split_graficos.Size = new System.Drawing.Size(722, 402);
            this.split_graficos.SplitterDistance = 345;
            this.split_graficos.SplitterWidth = 2;
            this.split_graficos.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(71, 122);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(71, 82);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 181);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(294, 208);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(89, 122);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(1);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(89, 82);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(1);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(49, 181);
            this.chart2.Margin = new System.Windows.Forms.Padding(1);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(290, 200);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 528);
            this.Controls.Add(this.split_graficos);
            this.Controls.Add(this.gbox_cliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.split_alquilar.Panel2.ResumeLayout(false);
            this.split_alquilar.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_alquilar)).EndInit();
            this.split_alquilar.ResumeLayout(false);
            this.gbox_cliente.ResumeLayout(false);
            this.split_graficos.Panel1.ResumeLayout(false);
            this.split_graficos.Panel1.PerformLayout();
            this.split_graficos.Panel2.ResumeLayout(false);
            this.split_graficos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_graficos)).EndInit();
            this.split_graficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.SplitContainer split_alquilar;
        private System.Windows.Forms.GroupBox gbox_alquilar;
        private System.Windows.Forms.GroupBox gbox_cliente;
        private System.Windows.Forms.SplitContainer split_graficos;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolStripMenuItem promosToolStripMenuItem;
    }
}