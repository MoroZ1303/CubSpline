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
    public partial class Input_data_form : Form
    {
        public Input_data_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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


        public Data.Point[] GetPoints()
        {
            Data.Point[]res =new Data.Point[this.dataGridView1.RowCount];
            for (int i = 0; i < res.Length-1; i++)
            {
                double x = Double.Parse(dataGridView1.Rows[i].Cells["X"].Value.ToString());
                double y = Double.Parse(dataGridView1.Rows[i].Cells["Y"].Value.ToString());
                res[i] = new Data.Point(x, y);
            }
            return res;
        }
    }
}
