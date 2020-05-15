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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Manual_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPolynomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showPolynomial = new System.Windows.Forms.CheckBox();
            this.showFirstDerivative = new System.Windows.Forms.CheckBox();
            this.showSecondDerivative = new System.Windows.Forms.CheckBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1219, 24);
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
            this.chart1.Size = new System.Drawing.Size(902, 506);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // checkBox1
            // 
            this.showPolynomial.AutoSize = true;
            this.showPolynomial.Location = new System.Drawing.Point(987, 42);
            this.showPolynomial.Name = "checkBox1";
            this.showPolynomial.Size = new System.Drawing.Size(105, 17);
            this.showPolynomial.TabIndex = 9;
            this.showPolynomial.Text = "Show polynomial";
            this.showPolynomial.UseVisualStyleBackColor = true;
            this.showPolynomial.CheckedChanged += new System.EventHandler(this.showPolynomial_CheckedChanged);
            // 
            // showFirstDerivative
            // 
            this.showFirstDerivative.AutoSize = true;
            this.showFirstDerivative.Location = new System.Drawing.Point(987, 65);
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
            this.showSecondDerivative.Location = new System.Drawing.Point(987, 88);
            this.showSecondDerivative.Name = "showSecondDerivative";
            this.showSecondDerivative.Size = new System.Drawing.Size(74, 17);
            this.showSecondDerivative.TabIndex = 10;
            this.showSecondDerivative.Text = "Show f\'\'(x)";
            this.showSecondDerivative.UseVisualStyleBackColor = true;
            this.showSecondDerivative.CheckedChanged += new System.EventHandler(this.showSecondDerivative_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 601);
            this.Controls.Add(this.showSecondDerivative);
            this.Controls.Add(this.showFirstDerivative);
            this.Controls.Add(this.showPolynomial);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
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
        private System.Windows.Forms.CheckBox showFirstDerivative;
        private System.Windows.Forms.CheckBox showSecondDerivative;
    }
}

