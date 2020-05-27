using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CSpline
{
    public partial class PointsInputForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        List<Tuple<double, double>> points = new List<Tuple<double, double>>();
        
        public PointsInputForm()
        {
            InitializeComponent();
        }

        private void PointsInputForm_Load(object sender, EventArgs e)
        {
            dataGridView.CellValidating += GridViewCellValidating;
            dataGridView.CellEndEdit += GridViewCellEndEdit;
            dataGridView.Rows.Clear();
            foreach (var p in points)
            {
                dataGridView.Rows.Add(new string[] { p.Item1.ToString(), p.Item2.ToString() });
            }
        }

        private void GridViewCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            IsCellValid(e.RowIndex, e.ColumnIndex);
        }

        private void GridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.
            IsCellValid(e.RowIndex, e.ColumnIndex);
        }

        private bool IsCellValid(int row, int col, out string errMsg)
        {
            string headerText = dataGridView.Columns[col].HeaderText;
            string value = dataGridView.Rows[row].Cells[col].FormattedValue.ToString();

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(value))
            {
                errMsg = headerText + " не должен быть пустым";
                return false;
            }

            double x = 0;
            if (!Double.TryParse(value, out x))
            {
                errMsg = headerText + " должно быть число с плавающей точкой";
                return false;
            }

            double y = 0;
            if (!Double.TryParse(value, out y))
            {
                errMsg = headerText + " должно быть число с плавающей точкой";
                return false;
            }
            errMsg = String.Empty;
            return true;
        }

        private bool IsCellValid(int row, int col, bool setErrMsg = true)
        {
            string errMsg;
            bool valid = IsCellValid(row, col, out errMsg);
            if (setErrMsg)
                dataGridView.Rows[row].ErrorText = errMsg;
            else
                dataGridView.Rows[row].ErrorText = String.Empty;
            return valid;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount < 5)
            {
                dataGridView.Rows[0].ErrorText = "Требуется как минимум 4 точки";
                return;
            }

            bool valid = true;
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                dataGridView.Rows[i].ErrorText = String.Empty;
                valid = valid && IsCellValid(i, 0);
                valid = valid && IsCellValid(i, 1);
            }

            if (!valid)
                return;

            List<Tuple<double, double>> newPoints = new List<Tuple<double, double>>();
            HashSet<double> xSet = new HashSet<double>();

            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                string xValue = dataGridView.Rows[i].Cells[0].FormattedValue.ToString();
                string yValue = dataGridView.Rows[i].Cells[1].FormattedValue.ToString();

                double x = Double.Parse(xValue);
                double y = Double.Parse(yValue);

                if (xSet.Contains(x))
                {
                    valid = false;
                    dataGridView.Rows[i].ErrorText = "Одинаковые значения Х не допустимы";
                }

                xSet.Add(x);

                newPoints.Add(new Tuple<double, double>(x, y));
            }


            if (!valid)
                return;

            points = newPoints;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        public Data.Point[] GetPoints()
        {
            Data.Point[] res = new Data.Point[points.Count];
            int i = 0;
            foreach (var p in points)
            {
                res[i++] = new Data.Point(p.Item1, p.Item2);
            }
            return res;
        }

        public DataGridView gridView
        {
            get
            {
                return gridView;
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    dataGridView.Rows.Clear();
                    foreach(var p in Data.Utils.GetPointsFromFile(openFileDialog.OpenFile()))
                    {
                        dataGridView.Rows.Add(new string[] { p.getX().ToString(), p.getY().ToString() });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла " + openFileDialog.FileName + " : " + ex.Message);
                }
            }
        }
    }
}
