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
        Model model;
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
        }

        private void ImageBuildButton_Click(object sender, EventArgs e)
        {
            model = new Model();

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

            view.PrintDots(ref model.circle);
            view.PrintDots(ref model.parabola);
            view.PrintHatching(ref model.hatching);
        }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            int xScale, yScale;

            double xScaleCoeff, yScaleCoeff;

            try
            {
                xScale = Convert.ToInt32(scaleXtextBox.Text);
                yScale = Convert.ToInt32(scaleYtextBox.Text);
                xScaleCoeff = Convert.ToDouble(scaleKXtextBox.Text);
                yScaleCoeff = Convert.ToDouble(scaleKYtextBox.Text);
            }
            catch
            {
                MessageBox.Show("Некорректные данные.\nkX и kY должны быть вещественными числами\n" +
                                "X и Y должны быть целыми", "Ошибка");
                return;
            }

            model.Scale(new Point(xScale, yScale), new PointF((float)xScaleCoeff, (float)yScaleCoeff));

        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            double dX, dY;
            try
            {
                dX = Convert.ToDouble(moveDXTextBox.Text);
                dY = Convert.ToDouble(moveDYTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Некорректные данные.\ndX и dY должны быть вещественными числами", "Ошибка");
                return;
            }

            model.Moving(new Point((int)dX, (int)dY));
            view.Clear();

            view.PrintDots(ref model.circle);
            view.PrintDots(ref model.parabola);
            view.PrintHatching(ref model.hatching);
        }
    }
}
