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

        private Graphics g;
        private Model _model = new Model();

        private Color _correctColor;
        private Color _errorColor = Color.Coral;
        public MainForm()
        {
            InitializeComponent();

            g = Graphics.FromHwnd(pictureBox1.Handle);
            _correctColor = xEnterFirst.BackColor;
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
                errorMessage += "Введите не менее трех точек в первой последовательности.\n";
            }

            if (dataGridView2.Rows.Count < 4)
            {
                errorReached = true;
                errorMessage += "Введите не менее трех точек во второй последовательности.\n";
            }

            if (!ParseCoordinatsGrid(dataGridView1, out var firstCoordsSet) | !ParseCoordinatsGrid(dataGridView2, out var secondCoordsSet))
            {
                errorReached = true;
                errorMessage += "В поля с ошибкой введены не вещественные числа\n";
            }

            if (errorReached)
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                g.Clear(pictureBox1.BackColor);
                pictureBox1.Update();
                _model.SetDots(firstCoordsSet, secondCoordsSet);
                if (_model.IsCorrect)
                {

                    _model.Draw(g, pictureBox1.Size);
                    textOut.Text = FormTextOut();
                }
                else
                {
                    MessageBox.Show(_model.ErrorMessage, "Ошибка");
                }
            }

        }

        private string FormTextOut()
        {
            return _model.FormAnswer();
        }

        private bool ParseCoordinatsGrid(DataGridView dataGrid, out List<PointF> parsedCoordinats)
        {
            parsedCoordinats = new List<PointF>();
            float x, y;
            bool is_error_reached = false;

            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                if (!(dataGrid.Rows[i].Cells[0].Value is null) && !(dataGrid.Rows[i].Cells[1].Value is null) &&
                    float.TryParse(dataGrid.Rows[i].Cells[0].Value.ToString().Replace('.',','), out x) &&
                    float.TryParse(dataGrid.Rows[i].Cells[1].Value.ToString().Replace('.',','), out y))
                {
                    parsedCoordinats.Add(new PointF(x, y));
                    dataGrid.Rows[i].ErrorText = "";
                }
                else
                {
                    is_error_reached = true;
                    dataGrid.Rows[i].ErrorText = "Incorrect value";
                }
            }

            if (is_error_reached)
            {
                parsedCoordinats.Clear();
            }

            return !is_error_reached;
        }

        private void ClearAllFirstBtn_Click(object sender, EventArgs e)
        {
            ClearDataGridView(dataGridView1);
        }

        private void ClearAllSecondBtn_Click(object sender, EventArgs e)
        {
            ClearDataGridView(dataGridView2);
        }

        private void ClearDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Update();
        }

        private void DeleteDotFirstBtn_Click(object sender, EventArgs e)
        {
            int position;

            leftDotDelNumber.BackColor = _errorColor;
            if (int.TryParse(this.leftDotDelNumber.Text, out position))
            {
                if (position >= 1 && position < dataGridView1.Rows.Count)
                {
                    leftDotDelNumber.BackColor = _correctColor;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[--position]);
                }
                else
                {
                    MessageBox.Show("Нет точки по этому номеру. Невозможно удалить.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Вводите корректное целое число (номер точки)", "Ошибка");
            }
        }

        private void DeleteDotSecondBtn_Click(object sender, EventArgs e)
        {
            int position;

            rightDotDelNumber.BackColor = _errorColor;
            if (int.TryParse(this.rightDotDelNumber.Text, out position))
            {
                rightDotDelNumber.BackColor = _correctColor;
                if (position >= 1 && position < dataGridView2.Rows.Count)
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[--position]);

                }
                else
                {
                    MessageBox.Show("Нет точки по этому номеру. Невозможно удалить.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Вводите корректное целое число (номер точки)", "Ошибка");
            }
        }

        private void EnterDotFirstBtn_Click(object sender, EventArgs e)
        {
            float x, y;

            bool isCorrectX = false;
            bool isCorrectY = false;

            xEnterFirst.BackColor = _errorColor;
            yEnterFirst.BackColor = _errorColor;

            if (float.TryParse(xEnterFirst.Text.Replace('.', ','), out x))
            {
                isCorrectX = true;
                xEnterFirst.BackColor = _correctColor;
            }

            if (float.TryParse(yEnterFirst.Text.Replace('.', ','), out y))
            {
                isCorrectY = true;
                yEnterFirst.BackColor = _correctColor;
            }

            if (isCorrectX && isCorrectY)
            {
                dataGridView1.Rows.Add(x, y);
            }
            else
            {
                MessageBox.Show("Вводите вещественное число", "Ошибка");
            }
        }

        private void EnterDotSecondBtn_Click(object sender, EventArgs e)
        {
            float x, y;

            bool isCorrectX = false;
            bool isCorrectY = false;

            xEnterSecond.BackColor = _errorColor;
            yEnterSecond.BackColor = _errorColor;

            if (float.TryParse(xEnterSecond.Text.Replace('.', ','), out x))
            {
                isCorrectX = true;
                xEnterSecond.BackColor = _correctColor;
            }

            if (float.TryParse(yEnterSecond.Text.Replace('.', ','), out y))
            {
                isCorrectY = true;
                yEnterSecond.BackColor = _correctColor;
            }

            if (isCorrectX && isCorrectY)
            {
                dataGridView2.Rows.Add(x, y);
            }
            else
            {
                MessageBox.Show("Вводите вещественное число", "Ошибка");
            }
        }
    }
}
