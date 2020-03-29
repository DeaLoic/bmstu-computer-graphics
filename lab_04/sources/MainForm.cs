using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab_04
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

        private bool GetCircleDataSimpleWithError(out Point centre, out int radius)
        {
            bool error = false;

            centre = new Point();

            textBoxX0.BackColor = inputColor;
            textBoxY0.BackColor = inputColor;
            textBoxSimpleRadius.BackColor = inputColor;

            int x, y;
            if (!int.TryParse(textBoxX0.Text.Replace('.', ','), out x))
            {
                textBoxX0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxY0.Text.Replace('.', ','), out y))
            {
                textBoxY0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxSimpleRadius.Text.Replace('.', ','), out radius))
            {
                textBoxSimpleRadius.BackColor = errorColor;
                error = true;
            }

            if (error)
            {
                MessageBox.Show("Введите целые числа");
            }
            else
            {
                centre.X = x;
                centre.Y = y;
            }

            return !error;
        }


        private bool GetCircleDataCompareWithError(out int type, out int startRadius, out int endRadius, out int circleCount, out int step)
        {
            bool error = false;

            textBoxStartRadius.BackColor = inputColor;
            textBoxEndRadius.BackColor = inputColor;
            textBoxRadiusStep.BackColor = inputColor;
            textBoxCircleCount.BackColor = inputColor;

            type = 0;
            startRadius = 0;
            endRadius = 0;
            circleCount = 0;
            step = 0;

            if (checkedListBox.CheckedItems.Count != 3)
            {
                error = true;

                MessageBox.Show("Отметьте ровно три пункта");

            }
            else
            {
                if (checkedListBox.GetItemChecked(0))
                {
                    type += 1000;
                }

                if (checkedListBox.GetItemChecked(0))
                {
                    type += 100;
                }

                if (checkedListBox.GetItemChecked(0))
                {
                    type += 10;
                }

                if (checkedListBox.GetItemChecked(0))
                {
                    type += 1;
                }

                switch (type)
                {
                    case 0111:
                        type = 1;
                        break;
                    case 1011:
                        type = 2;
                        break;
                    case 1101:
                        type = 3;
                        break;
                    case 1110:
                        type = 4;
                        break;
                }

                if (checkedListBox.GetItemChecked(0) && !int.TryParse(textBoxStartRadius.Text.Replace('.', ','), out startRadius))
                {
                    textBoxStartRadius.BackColor = errorColor;
                    error = true;
                }

                if (checkedListBox.GetItemChecked(1) && !int.TryParse(textBoxEndRadius.Text.Replace('.', ','), out endRadius))
                {
                    textBoxEndRadius.BackColor = errorColor;
                    error = true;
                }

                if (checkedListBox.GetItemChecked(2) && !int.TryParse(textBoxRadiusStep.Text.Replace('.', ','), out step))
                {
                    textBoxRadiusStep.BackColor = errorColor;
                    error = true;
                }

                if(checkedListBox.GetItemChecked(3) && !int.TryParse(textBoxCircleCount.Text.Replace('.', ','), out circleCount))
                {
                    textBoxCircleCount.BackColor = errorColor;
                    error = true;
                }

                if (error)
                {
                    MessageBox.Show("Введите целые числа");
                }
            }

            return !error;
        }

        private void CircleCompareProcessing(DrawHelper.DrawCircleMethod method, Color workColor)
        {
            int type, startRadius, endRadius, circleCount, step;

            if (GetCircleDataCompareWithError(out type, out startRadius, out endRadius, out circleCount, out step))
            {
                Point center = Point.Empty;
                center.X = workBitmap.Width / 2;
                center.Y = workBitmap.Height / 2;

                DrawHelper.DrawCircleCompare(workBitmap, method, workColor, center, type, startRadius, endRadius, circleCount, step);
                graph.DrawImage(workBitmap, 0, 0);
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
            }
        }

        private void CircleCompareProcessingStandart(Color workColor)
        {
            int type, startRadius, endRadius, circleCount, step;

            if (GetCircleDataCompareWithError(out type, out startRadius, out endRadius, out circleCount, out step))
            {
                Point center = Point.Empty;
                center.X = workBitmap.Width / 2;
                center.Y = workBitmap.Height / 2;

                DrawHelper.DrawCircleCompareStandart(graph, workColor, center, type, startRadius, endRadius, circleCount, step);
            }
        }

        private void SimpleCircleProcessing(DrawHelper.DrawCircleMethod method, Color workColor)
        {
            Point center = Point.Empty;
            int radius;

            if (GetCircleDataSimpleWithError(out center, out radius))
            {
                DrawHelper.DrawCircle(workBitmap, method, workColor, center, radius);
                graph.DrawImage(workBitmap, 0, 0);
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
            }
        }

        private void CanonColorSimpleBtn_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleCanonical), canonColorSimpleBtn.BackColor);
        }

        private void CanonBackSimpleBtn_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleCanonical), workBackColor);
        }

        private void BresenhamColorSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleBresenham), bresenhamColorSimpleButton.BackColor);
        }

        private void BresenhamBackSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleBresenham), workBackColor);
        }

        private void ParamColorSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleParam), paramColorSimpleButton.BackColor);
        }

        private void ParamBackSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleParam), workBackColor);
        }

        private void MiddleColorSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleMiddle), middleColorSimpleButton.BackColor);
        }

        private void MiddleBackSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleCircleProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleMiddle), workBackColor);
        }

        private void StandartColorSimpleButton_Click(object sender, EventArgs e)
        {
            Point center = Point.Empty;
            int radius;

            if (GetCircleDataSimpleWithError(out center, out radius))
            {
                graph.DrawEllipse(new Pen(standartColorButton.BackColor), center.X - radius, center.Y - radius,
                                                                          radius * 2, radius * 2);
            }
        }

        private void StandartBackSimpleButton_Click(object sender, EventArgs e)
        {
            Point center = Point.Empty;
            int radius;

            if (GetCircleDataSimpleWithError(out center, out radius))
            {
                graph.DrawEllipse(new Pen(workBackColor), center.X - radius, center.Y - radius,
                                                          radius * 2, radius * 2);
            }
        }


        private void CanonicalColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = canonCompareColorButton.BackColor;
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleCanonical), workColor);
        }

        private void CanonicalBackSunAct_Click(object sender, EventArgs e)
        {
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleCanonical), workBackColor);
        }

        private void BresenhamColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = bresenhamCompareColorButton.BackColor;
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleBresenham), workColor);
        }

        private void BresenhamBackSunAct_Click(object sender, EventArgs e)
        {
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleBresenham), workBackColor);
        }

        private void ParamColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = paramColorCompareButton.BackColor;
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleParam), workColor);
        }

        private void ParamBackSunAct_Click(object sender, EventArgs e)
        {
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleParam), workBackColor);
        }

        private void MiddleColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = middleSunColorButton.BackColor;
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleMiddle), workColor);
        }

        private void MiddleBackSunAct_Click(object sender, EventArgs e)
        {
            CircleCompareProcessing(new DrawHelper.DrawCircleMethod(DrawHelper.DrawCircleMiddle), workBackColor);
        }

        private void standartColorSunAct_Click(object sender, EventArgs e)
        {
            Color workColor = standartCompColorButton.BackColor;
            CircleCompareProcessingStandart(workColor);
        }

        private void standartBackSunAct_Click(object sender, EventArgs e)
        {
            CircleCompareProcessingStandart(workBackColor);
        }

        private void ClearButton_Click(object sender, EventArgs e)
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
