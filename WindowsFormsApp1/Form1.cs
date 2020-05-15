using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            inputDataForm = new Input_data_form();
            polynomial = new EnterPolynomialForm();
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
            }
            
            
        }

        private void EnterPolinome_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pName != null)
                chart1.Series[pName].Enabled = checkBox1.Checked;

        }
    }
}
