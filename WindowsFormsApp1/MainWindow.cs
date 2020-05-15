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
        private EnterPolynomialForm polynomial = new EnterPolynomialForm();

        private string pName;
        OpenFileDialog openFileDialogue = new OpenFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Manual_menu_item_Click(object sender, EventArgs e)
        {

            if (inputDataForm.ShowDialog(this) == DialogResult.OK)
            {
                Data.Point[] points = inputDataForm.GetPoints();

                Series pointsSeries = chart1.Series.FindByName("points");
                if (pointsSeries != null)
                    chart1.Series.Remove(pointsSeries);
                pointsSeries = chart1.Series.Add("points");
                pointsSeries.ChartType = SeriesChartType.Point;
                foreach(var p in points)
                {
                    pointsSeries.Points.AddXY(p.getX(), p.getY());
                }

                Data.CubicSpline spline = new Data.CubicSpline(points);
                Series splineSeries = chart1.Series.FindByName("spline");                
                if (splineSeries != null)
                    chart1.Series.Remove(splineSeries);

                splineSeries = chart1.Series.Add("spline");
                splineSeries.ChartType = SeriesChartType.Spline;
                splineSeries.Points.Clear();
                foreach (var p in spline.getPoints())
                {
                    splineSeries.Points.AddXY(p.getX(), p.getY());
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pName != null)
                chart1.Series[pName].Enabled = checkBox1.Checked;

        }

        private void enterPolynomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (polynomial.ShowDialog(this) == DialogResult.OK)
            {

                Data.Polinomial p = polynomial.getPolynomial();
                if (pName != null)
                    chart1.Series.Remove(chart1.Series[pName]);
                pName = p.ToString();
                chart1.Series.Add(pName);
                chart1.Series[pName].ChartType = SeriesChartType.Spline;
                foreach (Data.Point point in p.getPoints(polynomial.rangeStart, polynomial.rangeEnd))
                {
                    chart1.Series[pName].Points.AddXY(point.getX(), point.getY());
                }
                checkBox1.Checked = true;
            }

        }
    }
}
