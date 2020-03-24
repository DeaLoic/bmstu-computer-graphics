using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab_03
{
    public partial class MainForm : Form
    {
        Color workBackColor;
        Color errorColor = Color.Red;
        Color inputColor;

        Graphics graph;
        Bitmap workBitmap;

        public MainForm()
        {
            InitializeComponent();
            workBackColor = mainCanvas.BackColor;
            inputColor = textBoxX0.BackColor;
            graph = mainCanvas.CreateGraphics();
            workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            SetChooseColor((Button)sender);
        }

        private void SetChooseColor(Button colorButton)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = colorButton.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                colorButton.BackColor = colorDialog.Color;
        }

        private bool GetPointsWithError(out Point first, out Point second)
        {
            bool error = false;

            first = new Point();
            second = new Point();

            textBoxX0.BackColor = inputColor;
            textBoxX1.BackColor = inputColor;
            textBoxY0.BackColor = inputColor;
            textBoxY1.BackColor = inputColor;

            int x, y, x1, y1;
            if (!int.TryParse(textBoxX0.Text.Replace('.', ','), out x))
            {
                textBoxX0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxX1.Text.Replace('.', ','), out x1))
            {
                textBoxX1.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxY0.Text.Replace('.', ','), out y))
            {
                textBoxY0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxY1.Text.Replace('.', ','), out y1))
            {
                textBoxY1.BackColor = errorColor;
                error = true;
            }

            if (error)
            {
                MessageBox.Show("Введите целые числа");
            }
            else
            {
                first.X = x;
                first.Y = y;
                second.X = x1;
                second.Y = y1;
            }

            return !error;
        }

        private void DDAColorSimpleBtn_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineDDA(firstPoint, secondPoint, workBitmap, DDAColorButton.BackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void DDABackSimpleBtn_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineDDA(firstPoint, secondPoint, workBitmap, workBackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void bresenhamColorSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineBresenham(firstPoint, secondPoint, workBitmap, bresenhamColorButton.BackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void bresenhamBackSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineBresenham(firstPoint, secondPoint, workBitmap, workBackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void bresenhamIntColorSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineBresenhamInt(firstPoint, secondPoint, workBitmap, bresenhamIntColorButton.BackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void bresenhamIntBackSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineBresenhamInt(firstPoint, secondPoint, workBitmap, workBackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void bresenhamFlatColorSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineBresenhamFlat(firstPoint, secondPoint, workBitmap, bresenhamFlatColorButton.BackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void bresenhamFlatBackSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineBresenhamFlat(firstPoint, secondPoint, workBitmap, workBackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void vuColorSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineVu(firstPoint, secondPoint, workBitmap, vuColorButton.BackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void vuBackSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineVu(firstPoint, secondPoint, workBitmap, workBackColor);
                graph.DrawImage(workBitmap, 0, 0);
            }
        }

        private void standartColorSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                graph.DrawLine(new Pen(standartColorButton.BackColor), firstPoint, secondPoint);
            }
        }

        private void standartBackSimpleButton_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                graph.DrawLine(new Pen(workBackColor), firstPoint, secondPoint);
            }
        }
    }
}
