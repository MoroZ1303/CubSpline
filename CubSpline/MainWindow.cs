using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        private PointsInputForm inputDataForm = new PointsInputForm();
        OpenFileDialog openFileDialogue = new OpenFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private Series updateChartSeries(string name, Data.Point[] points)
        {
            Series series = chart.Series.FindByName(name);
            series.Points.Clear();
            foreach (var p in points)
            {
                series.Points.AddXY(p.getX(), p.getY());
            }
            return series;
        }
        private void EnterEditMenuItem_Click(object sender, EventArgs e)
        {

            if (inputDataForm.ShowDialog(this) == DialogResult.OK)
            {
                Data.Point[] points = inputDataForm.GetPoints();

                updateChartSeries("points", points);

                Data.CubicSpline spline = new Data.CubicSpline(points);
                Data.Point[] splinePoints = spline.getPoints();
                updateChartSeries("spline", splinePoints);

            }
        }
    }
}
