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
            this.showNewton = new System.Windows.Forms.CheckBox();
            this.showLeastSquares = new System.Windows.Forms.CheckBox();
            this.showLagrange = new System.Windows.Forms.CheckBox();
            this.leastSquaresOrderSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Manual_menu_item.Size = new System.Drawing.Size(164, 22);
            this.Manual_menu_item.Text = "Enter Points";
            this.Manual_menu_item.Click += new System.EventHandler(this.Manual_menu_item_Click);
            // 
            // enterPolynomialToolStripMenuItem
            // 
            this.enterPolynomialToolStripMenuItem.Name = "enterPolynomialToolStripMenuItem";
            this.enterPolynomialToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
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
            series2.Name = "Lagrange";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Purple;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.LegendText = "f\'(x)";
            series3.Name = "Newton";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.LegendText = "f\'\'(x)";
            series4.Name = "leastSquares";
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
            // showNewton
            // 
            this.showNewton.AutoSize = true;
            this.showNewton.Location = new System.Drawing.Point(949, 88);
            this.showNewton.Name = "showNewton";
            this.showNewton.Size = new System.Drawing.Size(93, 17);
            this.showNewton.TabIndex = 10;
            this.showNewton.Text = "Show Newton";
            this.showNewton.UseVisualStyleBackColor = true;
            this.showNewton.CheckedChanged += new System.EventHandler(this.showNewton_CheckedChanged);
            // 
            // showLeastSquares
            // 
            this.showLeastSquares.AutoSize = true;
            this.showLeastSquares.Location = new System.Drawing.Point(949, 111);
            this.showLeastSquares.Name = "showLeastSquares";
            this.showLeastSquares.Size = new System.Drawing.Size(124, 17);
            this.showLeastSquares.TabIndex = 10;
            this.showLeastSquares.Text = "Show Least Squares";
            this.showLeastSquares.UseVisualStyleBackColor = true;
            this.showLeastSquares.CheckedChanged += new System.EventHandler(this.showLeastSquares_CheckedChanged);
            // 
            // showLagrange
            // 
            this.showLagrange.AutoSize = true;
            this.showLagrange.Location = new System.Drawing.Point(949, 65);
            this.showLagrange.Name = "showLagrange";
            this.showLagrange.Size = new System.Drawing.Size(101, 17);
            this.showLagrange.TabIndex = 10;
            this.showLagrange.Text = "Show Lagrange";
            this.showLagrange.UseVisualStyleBackColor = true;
            this.showLagrange.CheckedChanged += new System.EventHandler(this.showLagrange_CheckedChanged);
            // 
            // leastSquaresOrderSelection
            // 
            this.leastSquaresOrderSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leastSquaresOrderSelection.FormattingEnabled = true;
            this.leastSquaresOrderSelection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.leastSquaresOrderSelection.Location = new System.Drawing.Point(949, 175);
            this.leastSquaresOrderSelection.Name = "leastSquaresOrderSelection";
            this.leastSquaresOrderSelection.Size = new System.Drawing.Size(63, 21);
            this.leastSquaresOrderSelection.TabIndex = 11;
            this.leastSquaresOrderSelection.SelectedIndexChanged += new System.EventHandler(this.leastSquaresOrderSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(946, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Least Squares Poly order";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leastSquaresOrderSelection);
            this.Controls.Add(this.showLeastSquares);
            this.Controls.Add(this.showLagrange);
            this.Controls.Add(this.showNewton);
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
        private System.Windows.Forms.CheckBox showLagrange;
        private System.Windows.Forms.CheckBox showNewton;
        private System.Windows.Forms.CheckBox showLeastSquares;
        private System.Windows.Forms.ComboBox leastSquaresOrderSelection;
        private System.Windows.Forms.Label label1;
    }
}

