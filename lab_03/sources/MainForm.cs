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


        private bool GetSunParameters(out double angle, out int lenght)
        {
            bool error = false;
            if (!double.TryParse(textBoxAngle.Text.Replace('.', ','), out angle))
            {
                textBoxAngle.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxLenght.Text.Replace('.', ','), out lenght))
            {
                textBoxY1.BackColor = errorColor;
                error = true;
            }

            if (error)
            {
                MessageBox.Show("Введите целые числа");
            }

            return !error;
        }

        private void SunProcessing(DrawHelper.DrawLineMethod method, Color workColor)
        {
            double angle;
            int lenght;

            if (GetSunParameters(out angle, out lenght))
            {
                Point center = Point.Empty;
                center.X = workBitmap.Width / 2;
                center.Y = workBitmap.Height / 2;

                DrawHelper.DrawSun(center, workBitmap, graph, workColor, lenght, angle, method);
                graph.DrawImage(workBitmap, 0, 0);
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
            }
        }

        private void SunProcessingStandart(Color workColor)
        {
            double angle;
            int lenght;

            if (GetSunParameters(out angle, out lenght))
            {
                Point center = Point.Empty;
                center.X = workBitmap.Width / 2;
                center.Y = workBitmap.Height / 2;

                DrawHelper.DrawSunStandart(center, graph, workColor, lenght, angle);
            }
        }

        private void DDAColorSimpleBtn_Click(object sender, EventArgs e)
        {
            Point firstPoint;
            Point secondPoint;

            if (GetPointsWithError(out firstPoint, out secondPoint))
            {
                DrawHelper.DrawLineDDA(firstPoint, secondPoint, workBitmap, DDAColorButton.BackColor);
                graph.DrawImage(workBitmap, 0, 0);
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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

        private void DDAColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = DDASunColorButton.BackColor;
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineDDA), workColor);
        }

        private void DDABackSunAct_Click(object sender, EventArgs e)
        {
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineDDA), workBackColor);
        }

        private void bresenhamColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = bresenhamSunColorButton.BackColor;
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineBresenham), workColor);
        }

        private void bresenhamBackSunAct_Click(object sender, EventArgs e)
        {
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineBresenham), workBackColor);
        }

        private void bresenhamIntColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = bresenhamIntSunColorButton.BackColor;
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineBresenhamInt), workColor);
        }

        private void bresenhamIntBackSunAct_Click(object sender, EventArgs e)
        {
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineBresenhamInt), workBackColor);
        }

        private void bresenhamFlatColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = bresenhamFlatSunColorButton.BackColor;
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineBresenhamFlat), workColor);
        }

        private void bresenhamFlatBackSunAct_Click(object sender, EventArgs e)
        {
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineBresenhamFlat), workBackColor);
        }

        private void vuColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = vuSunColorButton.BackColor;
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineVu), workColor);
        }

        private void vuBackSunAct_Click(object sender, EventArgs e)
        {
            SunProcessing(new DrawHelper.DrawLineMethod(DrawHelper.DrawLineVu), workBackColor);
        }

        private void standartColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = standartSunColorButton.BackColor;
            SunProcessingStandart(workColor);
        }

        private void standartBackSunAct_Click(object sender, EventArgs e)
        {
            SunProcessingStandart(workBackColor);
        }

        private void clearButtno_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = workBackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                graph.Clear(colorDialog.Color);
                workBackColor = colorDialog.Color;
            }
        }
    }
}
