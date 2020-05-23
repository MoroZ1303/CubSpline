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
        private Data.Point[] inputPoints;

        OpenFileDialog openFileDialogue = new OpenFileDialog();

        public MainWindow()
        {
            InitializeComponent();
            leastSquaresOrderSelection.SelectedItem = "3";
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
                inputPoints = inputDataForm.GetPoints();

                updateChartSeries("points", inputPoints);

                Data.LagrangeInterpolation lagrange = new Data.LagrangeInterpolation(inputPoints);
                Data.Point[] lagrangePoints = lagrange.GetPoints();
                updateChartSeries("Lagrange", lagrangePoints);

                Data.NewtonInterpolation newton = new Data.NewtonInterpolation(inputPoints);
                updateChartSeries("Newton", newton.GetPoints()).Enabled = false;
                showNewton.Checked = false;

                updateLeastSqaresSeries(false);
                chart1.ChartAreas[0].AxisX.RoundAxisValues();
            }
        }

        private void updateLeastSqaresSeries(bool enabled)
        {
            int order;
            if (leastSquaresOrderSelection.SelectedItem == null)
                return;

            if (!Int32.TryParse(leastSquaresOrderSelection.SelectedItem.ToString(), out order))
                return;

            if (inputPoints == null)
                return;

            Data.LeastSquares leastSquares = new Data.LeastSquares(inputPoints, order);
            updateChartSeries("leastSquares", leastSquares.GetPoints()).Enabled = enabled;
            showLeastSquares.Checked = enabled;
            if (enabled)
                chart1.ResetAutoValues();
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

        private void showLagrange_CheckedChanged(object sender, EventArgs e)
        {
            Series series = chart1.Series.FindByName("Lagrange");
            series.Enabled = showLagrange.Checked;
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
            chart1.ResetAutoValues();
        }

        private void showNewton_CheckedChanged(object sender, EventArgs e)
        {
            Series series = chart1.Series.FindByName("Newton");
            series.Enabled = showNewton.Checked;
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
            chart1.ResetAutoValues();
        }

        private void showLeastSquares_CheckedChanged(object sender, EventArgs e)
        {
            Series series = chart1.Series.FindByName("leastSquares");
            series.Enabled = showLeastSquares.Checked;
            chart1.ResetAutoValues();
        }

        private void leastSquaresOrderSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLeastSqaresSeries(true);
        }
    }
}
