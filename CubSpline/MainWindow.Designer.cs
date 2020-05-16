namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Manual_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPolynomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showPolynomial = new System.Windows.Forms.CheckBox();
            this.showFirstDerivative = new System.Windows.Forms.CheckBox();
            this.showSecondDerivative = new System.Windows.Forms.CheckBox();
            this.showSpline = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Manual_menu_item,
            this.enterPolynomialToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Data";
            // 
            // Manual_menu_item
            // 
            this.Manual_menu_item.Name = "Manual_menu_item";
            this.Manual_menu_item.Size = new System.Drawing.Size(180, 22);
            this.Manual_menu_item.Text = "Enter Points";
            this.Manual_menu_item.Click += new System.EventHandler(this.Manual_menu_item_Click);
            // 
            // enterPolynomialToolStripMenuItem
            // 
            this.enterPolynomialToolStripMenuItem.Name = "enterPolynomialToolStripMenuItem";
            this.enterPolynomialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enterPolynomialToolStripMenuItem.Text = "Enter Polynomial";
            this.enterPolynomialToolStripMenuItem.Click += new System.EventHandler(this.enterPolynomialToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 42);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.LegendText = "points";
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
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.LegendText = "spline";
            series2.Name = "spline";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Purple;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.LegendText = "f\'(x)";
            series3.Name = "firstDerivative";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.LegendText = "f\'\'(x)";
            series4.Name = "secondDerivative";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Teal;
            series5.Enabled = false;
            series5.Legend = "Legend1";
            series5.MarkerSize = 10;
            series5.Name = "polynomial";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(902, 506);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // showPolynomial
            // 
            this.showPolynomial.AutoSize = true;
            this.showPolynomial.Location = new System.Drawing.Point(949, 42);
            this.showPolynomial.Name = "showPolynomial";
            this.showPolynomial.Size = new System.Drawing.Size(105, 17);
            this.showPolynomial.TabIndex = 9;
            this.showPolynomial.Text = "Show polynomial";
            this.showPolynomial.UseVisualStyleBackColor = true;
            this.showPolynomial.CheckedChanged += new System.EventHandler(this.showPolynomial_CheckedChanged);
            // 
            // showFirstDerivative
            // 
            this.showFirstDerivative.AutoSize = true;
            this.showFirstDerivative.Location = new System.Drawing.Point(949, 88);
            this.showFirstDerivative.Name = "showFirstDerivative";
            this.showFirstDerivative.Size = new System.Drawing.Size(72, 17);
            this.showFirstDerivative.TabIndex = 10;
            this.showFirstDerivative.Text = "Show f\'(x)";
            this.showFirstDerivative.UseVisualStyleBackColor = true;
            this.showFirstDerivative.CheckedChanged += new System.EventHandler(this.showFirstDerivative_CheckedChanged);
            // 
            // showSecondDerivative
            // 
            this.showSecondDerivative.AutoSize = true;
            this.showSecondDerivative.Location = new System.Drawing.Point(949, 111);
            this.showSecondDerivative.Name = "showSecondDerivative";
            this.showSecondDerivative.Size = new System.Drawing.Size(74, 17);
            this.showSecondDerivative.TabIndex = 10;
            this.showSecondDerivative.Text = "Show f\'\'(x)";
            this.showSecondDerivative.UseVisualStyleBackColor = true;
            this.showSecondDerivative.CheckedChanged += new System.EventHandler(this.showSecondDerivative_CheckedChanged);
            // 
            // showSpline
            // 
            this.showSpline.AutoSize = true;
            this.showSpline.Location = new System.Drawing.Point(949, 65);
            this.showSpline.Name = "showSpline";
            this.showSpline.Size = new System.Drawing.Size(83, 17);
            this.showSpline.TabIndex = 10;
            this.showSpline.Text = "Show spline";
            this.showSpline.UseVisualStyleBackColor = true;
            this.showSpline.CheckedChanged += new System.EventHandler(this.showSpline_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 601);
            this.Controls.Add(this.showSecondDerivative);
            this.Controls.Add(this.showSpline);
            this.Controls.Add(this.showFirstDerivative);
            this.Controls.Add(this.showPolynomial);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Cubic Spline";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Manual_menu_item;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem enterPolynomialToolStripMenuItem;
        private System.Windows.Forms.CheckBox showPolynomial;
        private System.Windows.Forms.CheckBox showSpline;
        private System.Windows.Forms.CheckBox showFirstDerivative;
        private System.Windows.Forms.CheckBox showSecondDerivative;
    }
}

