using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class EnterPolynomialForm : Form
    {

        List<Tuple<int, double>> state = new List<Tuple<int, double>>();
        Tuple<double, double, double> rangeAndOffset = null;

        public EnterPolynomialForm()
        {
            InitializeComponent();
        }
        public Data.Polynomial getPolynomial()
        {
            int max = 0;

            foreach (var i in state)
            {
                int pow = i.Item1;
                if (max < pow)
                    max = pow;
            }
            double[] cofficients = new double[max + 1];
            foreach (var i in state)
            {
                int pow = i.Item1;
                double c = i.Item2;
                cofficients[pow] = c;
            }
            return new Data.Polynomial(cofficients);
        }

        public double rangeStart
        {
            get {
                return rangeAndOffset.Item1;
            }
        }
        public double rangeEnd
        {
            get
            {
                return rangeAndOffset.Item2;
            }
        }

        public double xOffset
        {
            get
            {
                return rangeAndOffset.Item3;
            }
        }

        private void EnterPolynomialForm_Load(object sender, EventArgs e)
        {
            xRangeBeginInput.GotFocus += new EventHandler((s, evt) =>
            {
                xRangeBeginInput.ForeColor = Color.Black;
                xRangeEndInput.ForeColor = Color.Black;
                xOffsetInput.ForeColor = Color.Black;
            });
            xRangeEndInput.GotFocus += new EventHandler((s, evt) =>
            {
                xRangeBeginInput.ForeColor = Color.Black;
                xRangeEndInput.ForeColor = Color.Black;
                xOffsetInput.ForeColor = Color.Black;
            });

            xRangeBeginInput.LostFocus += RangeLostFocus;
            xRangeEndInput.LostFocus += RangeLostFocus;
            xOffsetInput.LostFocus += RangeLostFocus;
            
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            
            if (rangeAndOffset != null)
            {
                xRangeBeginInput.Text = rangeAndOffset.Item1.ToString();
                xRangeEndInput.Text = rangeAndOffset.Item2.ToString();
                xOffsetInput.Text = rangeAndOffset.Item3.ToString();
            }
            else
            {
                xRangeBeginInput.Text = "";
                xRangeEndInput.Text = "";
            }
            xRangeBeginInput.ForeColor = Color.Black;
            xRangeEndInput.ForeColor = Color.Black;

            dataGridView1.Rows.Clear();
            foreach (Tuple<int, double> item in state)
            {
                dataGridView1.Rows.Add(new string[] { item.Item1.ToString(), item.Item2.ToString() });
            }

        }

        private bool ValidateRangeAndOffset()
        {
            bool ok = true;
            double start;
            double end;
            if (!Double.TryParse(xRangeBeginInput.Text, out start))
            {
                xRangeBeginInput.ForeColor = Color.Red;
                ok = false;
            }
            
            if (String.IsNullOrEmpty(xOffsetInput.Text))
                xOffsetInput.Text = xRangeBeginInput.Text;

            if (!Double.TryParse(xRangeEndInput.Text, out end))
            {
                xRangeEndInput.ForeColor = Color.Red;
                ok = false;
            }
            double offset;
            if (!Double.TryParse(xOffsetInput.Text, out offset))
            {
                xOffsetInput.ForeColor = Color.Red;
                ok = false;
            }

            if (start >= end)
            {
                xRangeBeginInput.ForeColor = Color.Red;
                xRangeEndInput.ForeColor = Color.Red;
                ok = false;
            }

            if (ok)
            {
                xRangeBeginInput.ForeColor = Color.Black;
                xRangeEndInput.ForeColor = Color.Black;
                xOffsetInput.ForeColor = Color.Black;
            }
            return ok;

        }

        private void RangeLostFocus(object sender, EventArgs e)
        {
            ValidateRangeAndOffset();
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            string[] headerText = new string[] { dataGridView1.Columns[0].HeaderText, dataGridView1.Columns[1].HeaderText };
            bool ok = true;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString()))
                {
                    dataGridView1.Rows[i].ErrorText = headerText[0] +
                        " must not be empty";
                    ok = false;
                    continue;
                }
                if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString()))
                {
                    dataGridView1.Rows[i].ErrorText = headerText[1] +
                        " must not be empty";
                    ok = false;
                    continue;
                }
                dataGridView1.Rows[i].ErrorText = String.Empty;
            }

            ok = ok && ValidateRangeAndOffset();

            
            if (dataGridView1.RowCount < 2)
            {
                dataGridView1.Rows[0].ErrorText = "Polynomial should contain at least one entry";
                ok = false;
            }

            if (!ok)
                return;

            List<Tuple<int, double>> newState = new List<Tuple<int, double>>();
            HashSet<int> powers = new HashSet<int>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                int p = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                double c = Double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                newState.Add(new Tuple<int, double>(p, c));
                if (powers.Contains(p))
                {
                    ok = false;
                    dataGridView1.Rows[i].ErrorText = "Polynomial should not have duplicate power of X";
                }
                else
                    powers.Add(p);

            }
            if (!ok)
                return;

            rangeAndOffset = new Tuple<double, double, double>(
                Double.Parse(xRangeBeginInput.Text), 
                Double.Parse(xRangeEndInput.Text),
                Double.Parse(xOffsetInput.Text));
            state = newState;
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //if (!ValidateRange())
            //  return;
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = headerText +
                    " must not be empty";
                //e.Cancel = true;
                return;
            }

            int pwr = 0;
            if (e.ColumnIndex == 0 && (!Int32.TryParse(e.FormattedValue.ToString(), out pwr) || pwr < 0))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = headerText +
                    " must be positive integer";
                //e.Cancel = true;
                return;
            }

            double coef = 0;
            if (e.ColumnIndex == 1 && !Double.TryParse(e.FormattedValue.ToString(), out coef))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = headerText +
                    " must be floating point";
                //e.Cancel = true;
                return;
            }
        }
        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
       
        public bool hasData
        {
            get
            {
                return rangeAndOffset != null && state.Count > 0;
            }
        }

    }
}
