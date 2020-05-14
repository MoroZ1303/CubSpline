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

        List<Tuple<int, double>> state;
        public EnterPolynomialForm()
        {
            state = new List<Tuple<int, double>>();
            InitializeComponent();
        }
        public Data.Polinom getPolynomial()
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
            return new Data.Polinom (cofficients);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Polinome_Load(object sender, EventArgs e)
        {
            xRangeBegin.GotFocus += new EventHandler((s, evt) => {
                xRangeBegin.BackColor = Color.White;
                xRangeEnd.BackColor = Color.White;
            });
            xRangeEnd.GotFocus += new EventHandler((s, evt) => {
                xRangeBegin.BackColor = Color.White;
                xRangeEnd.BackColor = Color.White;
            });
            xRangeBegin.LostFocus += new EventHandler(RangeLostFocus);
            xRangeEnd.LostFocus += new EventHandler(RangeLostFocus);
            this.dataGridView1.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);
            this.dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.Rows.Clear();
            foreach (Tuple<int, double> item in state)
            {
                dataGridView1.Rows.Add(new string[] { item.Item1.ToString(), item.Item2.ToString() });

            }
        }

        private bool ValidateRange()
        {
            bool ok = true;
            double start;
            double end;
            if (!Double.TryParse(xRangeBegin.Text, out start))
            {
                xRangeBegin.BackColor = Color.Red;
                ok = false;
            }
            if (!Double.TryParse(xRangeEnd.Text, out end))
            {
                xRangeEnd.BackColor = Color.Red;
                ok = false;
            }
            if (start >= end)
            {
                xRangeBegin.BackColor = Color.Red;
                xRangeEnd.BackColor = Color.Red;
                ok = false;
            }
            if (ok)
            {
                xRangeBegin.BackColor = Color.White;
                xRangeEnd.BackColor = Color.White;
            }
            return ok;
               
        }

        private void RangeLostFocus(object sender, EventArgs e)
        {
            ValidateRange();
        }
        //FIXME: check for duplicated power
        private void ok_Click(object sender, EventArgs e)
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
                }
                if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString()))
                {
                    dataGridView1.Rows[i].ErrorText = headerText[1] +
                        " must not be empty";
                    ok = false;
                }
          

            }
            ok = ok && ValidateRange();

            if (!ok)
                return;
            
            state.Clear();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                int p = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                double c = Double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                state.Add(new Tuple<int, double>(p, c));

            }

            this.DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
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
                dataGridView1.Rows[e.RowIndex].ErrorText =headerText +
                    " must not be empty";
                e.Cancel = true;
                return;
            }

            int pwr = 0; 
            if (e.ColumnIndex == 0 && (!Int32.TryParse(e.FormattedValue.ToString(),out pwr) || pwr<0) )
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = headerText +
                    " must be positive integer";
                e.Cancel = true;
                return;
            }

            double coef = 0;
            if (e.ColumnIndex == 1 && !Double.TryParse(e.FormattedValue.ToString(), out coef) )
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = headerText +
                    " must be floating point";
                e.Cancel = true;
                return;
            }
            

           
        }
        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }


    }
}
