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
 

        public EnterPolynomialForm()
        {
            InitializeComponent();
        }
        public Data.Polinom getPolynomial()
        {
            int max = 0;

            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                int pow = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if (max < pow)
                    max = pow;
            }
            double[] cofficients = new double[max + 1];
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                int pow = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                double c = Double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                cofficients[pow] = c;
            }
            return new Data.Polinom (cofficients);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Polinome_Load(object sender, EventArgs e)
        {
            this.dataGridView1.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);
            this.dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
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

            e.Cancel = false;

        }
        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }


    }
}
