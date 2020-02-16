using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_01
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            object header = this.dataGridView1.Rows[index].HeaderCell.Value;

            string indexStr = (index + 1).ToString();

            if (header == null || !header.Equals(indexStr))
                this.dataGridView1.Rows[index].HeaderCell.Value = indexStr;
        }

        private void DataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            object header = this.dataGridView2.Rows[index].HeaderCell.Value;

            string indexStr = (index + 1).ToString();

            if (header == null || !header.Equals(indexStr))
                this.dataGridView2.Rows[index].HeaderCell.Value = indexStr;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            bool errorReached = false;

            if (dataGridView1.Rows.Count < 4)
            {
                errorReached = true;
                errorMessage.Concat("Введите не менее трех точек в первой последовательности.\n");
            }

            if (dataGridView2.Rows.Count < 4)
            {
                errorReached = true;
                errorMessage.Concat("Введите не менее трех точек во второй последовательности.\n");
            }

            if (!ParseCoordinatsGrid(dataGridView1, out var firstCoordsSet) | !ParseCoordinatsGrid(dataGridView2, out var secondCoordsSet))
            {
                errorReached = true;
                errorMessage.Concat("В поля с ошибкой введены не числа с плавающей точкой\n");
            }

            if (errorReached)
            {
                MessageBox.Show(errorMessage, "Ошибка ввода");
            }
            else
            {
                Model model = new Model(firstCoordsSet, secondCoordsSet);
                if (model.IsCorrect)
                {

                }
                else
                {
                    MessageBox.Show(model.ErrorMessage, "Ошибка");
                }
            }

        }

        private bool ParseCoordinatsGrid(DataGridView dataGrid, out List<PointF> parsedCoordinats)
        {
            parsedCoordinats = new List<PointF>();
            float x, y;
            bool is_error_reached = false;

            for (int i = 0; i < dataGrid.Rows.Count - 2; i++)
            {
                if (!(dataGrid.Rows[i].Cells[0].Value is null) && !(dataGrid.Rows[i].Cells[1].Value is null) &&
                    float.TryParse(dataGrid.Rows[i].Cells[0].Value.ToString(), out x) && float.TryParse(dataGrid.Rows[i].Cells[1].Value.ToString(), out y))
                {
                    parsedCoordinats.Add(new PointF(x, y));
                }
                else
                {
                    is_error_reached = true;
                    dataGrid.Rows[i].HeaderCell.Value = "Incorrect value";
                }
            }

            if (is_error_reached)
            {
                parsedCoordinats.Clear();
            }

            return !is_error_reached;
        }
    }
}
