using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CubicSplineApp
{
    public partial class MainWindow : Form
    {
        private PointsInputForm dataInputForm = new PointsInputForm();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private Series UpdateChartSeries(string name, Data.Point[] points)
        {
            Series series = chart.Series.FindByName(name);
            series.Points.Clear();
            foreach (var p in points)
            {
                series.Points.AddXY(p.getX(), p.getY());
            }
            return series;
        }
        private void DataEnterEditMenuItem_Click(object sender, EventArgs e)
        {

            if (dataInputForm.ShowDialog(this) == DialogResult.OK)
            {
                Data.Point[] points = dataInputForm.GetPoints();

                UpdateChartSeries("points", points);

                Data.CubicSpline spline = new Data.CubicSpline(points);
                Data.Point[] splinePoints = spline.GetPoints();
                UpdateChartSeries("spline", splinePoints);

            }
        }
    }
}
