namespace CubicSplineApp
{
    partial class MainWindow
    {
        
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dataStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEnterEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(961, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dataStripMenuItem
            // 
            this.dataStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEnterEditMenuItem});
            this.dataStripMenuItem.Name = "dataStripMenuItem";
            this.dataStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dataStripMenuItem.Text = "Данные";
            // 
            // dataEnterEditMenuItem
            // 
            this.dataEnterEditMenuItem.Name = "dataEnterEditMenuItem";
            this.dataEnterEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.dataEnterEditMenuItem.Size = new System.Drawing.Size(233, 22);
            this.dataEnterEditMenuItem.Text = "Ввести/Редактировать";
            this.dataEnterEditMenuItem.Click += new System.EventHandler(this.DataEnterEditMenuItem_Click);
            // 
            // chart
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(23, 42);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.LegendText = "точки";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "points";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.CustomProperties = "LineTension=0.5";
            series2.Legend = "Legend1";
            series2.LegendText = "сплайн";
            series2.Name = "spline";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(902, 506);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 601);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Интерполятор";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dataStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEnterEditMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

