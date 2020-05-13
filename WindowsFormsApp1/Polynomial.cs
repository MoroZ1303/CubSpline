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
    
    public partial class Polynomial : Form
    {

        public Polynomial()
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

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
