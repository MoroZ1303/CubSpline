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

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private Series updateChartSeries(string name, SeriesChartType type, Data.Point[] points)
        {
            Series series = chart1.Series.FindByName(name);
            if (series != null)
                chart1.Series.Remove(series);
            series = chart1.Series.Add(name);
            series.ChartType = type;
            foreach (var p in points)
            {
                series.Points.AddXY(p.getX(), p.getY());
            }
            return series;
        }
        private void Manual_menu_item_Click(object sender, EventArgs e)
        {

            if (inputDataForm.ShowDialog(this) == DialogResult.OK)
            {
                Data.Point[] points = inputDataForm.GetPoints();

                updateChartSeries("points", SeriesChartType.Point, points);

                Data.CubicSpline spline = new Data.CubicSpline(points);
                Data.Point[] splinePoints = spline.getPoints();
                updateChartSeries("spline", SeriesChartType.Spline, splinePoints);

                Data.FirstDerivative firstDerivative = new Data.FirstDerivative(spline.getPoints());
                updateChartSeries("f'(x)", SeriesChartType.Spline, firstDerivative.GetPoints());
                showFirstDerivative.Checked = true;

                Data.SecondDerivative secondDerivative = new Data.SecondDerivative(spline.getPoints());
                updateChartSeries("f''(x)", SeriesChartType.Spline, secondDerivative.GetPoints());
                showSecondDerivative.Checked = true;
                chart1.ChartAreas[0].AxisX.RoundAxisValues();

            }


        }

        private void showPolynomial_CheckedChanged(object sender, EventArgs e)
        {
            if (pName != null)
                chart1.Series[pName].Enabled = showPolynomial.Checked;
            else
                showPolynomial.Checked = false;

        }

        private void enterPolynomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (polynomial.ShowDialog(this) == DialogResult.OK)
            {

                Data.Polynomial p = polynomial.getPolynomial();
                if (pName != null)
                    chart1.Series.Remove(chart1.Series[pName]);
                pName = p.ToString();
                chart1.Series.Add(pName);
                chart1.Series[pName].ChartType = SeriesChartType.Spline;
                foreach (Data.Point point in p.getPoints(polynomial.rangeStart, polynomial.rangeEnd, polynomial.xOffset))
                {
                    chart1.Series[pName].Points.AddXY(point.getX(), point.getY());
                }
                showPolynomial.Checked = true;
                chart1.ChartAreas[0].AxisX.RoundAxisValues();
            }

        }

        private void showFirstDerivative_CheckedChanged(object sender, EventArgs e)
        {
            string seriesName = "f'(x)";
            Series series = chart1.Series.FindByName(seriesName);
            if (series != null)
                series.Enabled = showFirstDerivative.Checked;
            else
                showFirstDerivative.Checked = false;
        }

        private void showSecondDerivative_CheckedChanged(object sender, EventArgs e)
        {
            string seriesName = "f''(x)";
            Series series = chart1.Series.FindByName(seriesName);
            if (series != null)
                series.Enabled = showSecondDerivative.Checked;
            else
                showSecondDerivative.Checked = false;
        }
    }
}
