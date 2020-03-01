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

        public MainForm()
        {
            InitializeComponent();
            view = new View(MainCanvas.CreateGraphics());

            aTextBox.Text = (MainCanvas.Width / 2).ToString();
            bTextBox.Text = (MainCanvas.Height / 2).ToString();
            rTextBox.Text = (MainCanvas.Width / 5).ToString();
            cTextBox.Text = (MainCanvas.Width / 2).ToString();
            dTextBox.Text = (MainCanvas.Height / 2).ToString();

            scaleXtextBox.Text = aTextBox.Text;
            scaleYtextBox.Text = bTextBox.Text;

            rotateXTextBox.Text = aTextBox.Text;
            rotateYTextBox.Text = bTextBox.Text;

            model.GenerateModel(new Point(MainCanvas.Width / 2, MainCanvas.Height / 2), MainCanvas.Width / 5,
                                new Point(MainCanvas.Width / 2, MainCanvas.Height / 2));
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
                MessageBox.Show("Некорректные данные.\nНачальные параметры должны быть целыми положительными числами.", "Ошибка");
                return;
            }

            view.Clear();
            model.GenerateModel(new Point(a, b), r, new Point(c, d));

            view.PrintPolygon(ref model.circle);
            view.PrintParabola(ref model.parabola);
            view.PrintHatching(ref model.hatching);
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

            model.Scale(new PointF((float)xScale, (float)yScale), new PointF((float)xScaleCoeff, (float)yScaleCoeff));

            view.Clear();

            view.PrintPolygon(ref model.circle);
            view.PrintParabola(ref model.parabola);
            view.PrintHatching(ref model.hatching);
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

            model.Moving(new Point((int)dX, (int)dY));
            view.Clear();

            view.PrintPolygon(ref model.circle);
            view.PrintParabola(ref model.parabola);
            view.PrintHatching(ref model.hatching);
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

            model.Rotate(new PointF(X, Y), angle * Math.PI / 180);

            view.Clear();

            view.PrintPolygon(ref model.circle);
            view.PrintParabola(ref model.parabola);
            view.PrintHatching(ref model.hatching);
        }
    }
}
