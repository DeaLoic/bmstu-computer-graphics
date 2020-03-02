using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02
{
    public partial class MainForm : Form
    {
        Model model = new Model();
        View view;

        PointF startCircle;
        float startRadius;
        PointF startParabola;

        public MainForm()
        {
            InitializeComponent();
            view = new View(MainCanvas.CreateGraphics(), MainCanvas.Size);

            aTextBox.Text = (MainCanvas.Width / 2 - 10).ToString();
            bTextBox.Text = (MainCanvas.Height / 2 - 10).ToString();
            rTextBox.Text = (MainCanvas.Width / 5 - 10).ToString();
            cTextBox.Text = (MainCanvas.Width / 2 - 10).ToString();
            dTextBox.Text = (MainCanvas.Height / 2 - 10).ToString();

            scaleXtextBox.Text = aTextBox.Text;
            scaleYtextBox.Text = bTextBox.Text;

            rotateXTextBox.Text = aTextBox.Text;
            rotateYTextBox.Text = bTextBox.Text;

            startCircle = new PointF(MainCanvas.Width / 2, MainCanvas.Height / 2);
            startRadius = MainCanvas.Width / 5;
            startParabola = new PointF(MainCanvas.Width / 2, MainCanvas.Height / 2);

            model.GenerateModel(startCircle, startRadius, startParabola);
        }

        private void ImageBuildButton_Click(object sender, EventArgs e)
        {
            int a, b, r, c, d;

            try
            {
                a = Convert.ToInt32(aTextBox.Text);
                b = Convert.ToInt32(bTextBox.Text);
                r = Convert.ToInt32(rTextBox.Text);
                c = Convert.ToInt32(cTextBox.Text);
                d = Convert.ToInt32(dTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Некорректные данные.\nНачальные параметры должны быть целыми числами.", "Ошибка");
                return;
            }

            startCircle = new PointF(a + 10, b + 10);
            startRadius = r;
            startParabola = new PointF(c + 10, d + 10);

            model.GetShot();
            model.GenerateModel(startCircle, startRadius, startParabola);

            view.Clear();
            view.Show(ref model);
        }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            double xScale, yScale;

            double xScaleCoeff, yScaleCoeff;

            try
            {
                xScale = Convert.ToDouble(scaleXtextBox.Text.Replace('.', ','));
                yScale = Convert.ToDouble(scaleYtextBox.Text.Replace('.', ','));
                xScaleCoeff = Convert.ToDouble(scaleKXtextBox.Text.Replace('.', ','));
                yScaleCoeff = Convert.ToDouble(scaleKYtextBox.Text.Replace('.', ','));
            }
            catch
            {
                MessageBox.Show("Некорректные данные.\nkX, kY, X и Y должны быть вещественными числами\n", "Ошибка");
                return;
            }

            model.GetShot();
            model.Scale(new PointF((float)xScale + 10, (float)yScale + 10), new PointF((float)xScaleCoeff, (float)yScaleCoeff));

            view.Clear();
            view.Show(ref model);
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            double dX, dY;
            try
            {
                dX = Convert.ToDouble(moveDXTextBox.Text.Replace('.', ','));
                dY = Convert.ToDouble(moveDYTextBox.Text.Replace('.', ','));
            }
            catch
            {
                MessageBox.Show("Некорректные данные.\ndX и dY должны быть вещественными числами", "Ошибка");
                return;
            }

            model.GetShot();
            model.Moving(new Point((int)dX, (int)dY));

            view.Clear();
            view.Show(ref model);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            float X, Y;

            double angle;

            try
            {
                X = (float)Convert.ToDouble(rotateXTextBox.Text.Replace('.', ','));
                Y = (float)Convert.ToDouble(rotateYTextBox.Text.Replace('.', ','));
                angle = Convert.ToDouble(rotateAngleTextBox.Text.Replace('.', ','));
            }
            catch
            {
                MessageBox.Show("Некорректные данные.\nX, Y и значение угла должны быть вещественными числами", "Ошибка");
                return;
            }

            model.GetShot();
            model.Rotate(new PointF(X + 10, Y + 10), angle * Math.PI / 180);

            view.Clear();
            view.Show(ref model);
        }

        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point newCoord = new Point(e.Location.X - 10, e.Location.Y - 10);
            coordsLabel.Text = newCoord.ToString();
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            model.GetShot();
            model.GenerateModel(startCircle, startRadius, startParabola);

            view.Clear();
            view.Show(ref model);
        }

        private void LastStepButton_Click(object sender, EventArgs e)
        {
            view.Clear();
            model.SwapShot();
            view.Show(ref model);
        }
    }
}
