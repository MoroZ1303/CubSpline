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
        private EnterPolynomialForm polynomialInput = new EnterPolynomialForm();

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
            Series series = chart1.Series.FindByName(name);
            series.Points.Clear();
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

                updateChartSeries("points", points);

                Data.CubicSpline spline = new Data.CubicSpline(points);
                Data.Point[] splinePoints = spline.getPoints();
                updateChartSeries("spline", splinePoints);

                Data.FirstDerivative firstDerivative = new Data.FirstDerivative(spline.getPoints());
                updateChartSeries("firstDerivative", firstDerivative.GetPoints()).Enabled = false;
                showFirstDerivative.Checked = false;

                Data.SecondDerivative secondDerivative = new Data.SecondDerivative(spline.getPoints());
                updateChartSeries("secondDerivative", secondDerivative.GetPoints()).Enabled = false;
                showSecondDerivative.Checked = false;
                chart1.ChartAreas[0].AxisX.RoundAxisValues();
            }


        }

        private void showPolynomial_CheckedChanged(object sender, EventArgs e)
        {
            if (!polynomialInput.hasData)
            {
                chart1.Series["polynomial"].Enabled = false;
                showPolynomial.Checked = false;
            }
            chart1.Series["polynomial"].Enabled = showPolynomial.Checked;
            chart1.ResetAutoValues();
        }

        private void enterPolynomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (polynomialInput.ShowDialog(this) == DialogResult.OK)
            {

                Data.Polynomial p = polynomialInput.getPolynomial();
                Series series = updateChartSeries("polynomial", p.getPoints(polynomialInput.rangeStart, polynomialInput.rangeEnd, polynomialInput.xOffset));
                series.LegendText = p.ToString();
                series.Enabled = true;
                showPolynomial.Checked = true;
                chart1.ChartAreas[0].AxisX.RoundAxisValues();
                chart1.ResetAutoValues();
            }

        }

        private void showSpline_CheckedChanged(object sender, EventArgs e)
        {
            Series series = chart1.Series.FindByName("spline");
            series.Enabled = showSpline.Checked;
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
            chart1.ResetAutoValues();
        }

        private void showFirstDerivative_CheckedChanged(object sender, EventArgs e)
        {
            Series series = chart1.Series.FindByName("firstDerivative");
            series.Enabled = showFirstDerivative.Checked;
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
            chart1.ResetAutoValues();
        }

        private void showSecondDerivative_CheckedChanged(object sender, EventArgs e)
        {
            Series series = chart1.Series.FindByName("secondDerivative");
            series.Enabled = showSecondDerivative.Checked;
            chart1.ResetAutoValues();
        }
    }
}
