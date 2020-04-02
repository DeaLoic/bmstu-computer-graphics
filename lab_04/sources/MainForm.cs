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

        delegate void ProcessingCircle(DrawHelper.DrawCircleMethod method, Color workColor);
        delegate void ProcessingEllipse(DrawHelper.DrawEllipseMethod method, Color workColor);

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


        private bool GetCircleDataCompareWithError(out CompareType type, out int startRadius, out int endRadius, out int circleCount, out int step)
        {
            bool error = false;

            textBoxStartRadius.BackColor = inputColor;
            textBoxEndRadius.BackColor = inputColor;
            textBoxRadiusStep.BackColor = inputColor;
            textBoxCircleCount.BackColor = inputColor;

            int tempType = 0;
            type = new CompareType();
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
                    tempType += 1000;
                }

                if (checkedListBox.GetItemChecked(1))
                {
                    tempType += 100;
                }

                if (checkedListBox.GetItemChecked(2))
                {
                    tempType += 10;
                }

                if (checkedListBox.GetItemChecked(3))
                {
                    tempType += 1;
                }

                switch (tempType)
                {
                    case 0111:
                        type = CompareType.EndCountStep;
                        break;
                    case 1011:
                        type = CompareType.StartCountStep;
                        break;
                    case 1101:
                        type = CompareType.StartEndCount;
                        break;
                    case 1110:
                        type = CompareType.StartEndStep;
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

        private bool GetEllipseDataSimpleWithError(out Point centre, out int radiusX, out int radiusY)
        {
            bool error = false;

            centre = new Point();

            textBoxXEllipse.BackColor = inputColor;
            textBoxYEllipse.BackColor = inputColor;
            textBoxXEllipse.BackColor = inputColor;
            textBoxYEllipse.BackColor = inputColor;


            int x, y;
            if (!int.TryParse(textBoxXEllipse.Text.Replace('.', ','), out x))
            {
                textBoxX0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxYEllipse.Text.Replace('.', ','), out y))
            {
                textBoxY0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxSimpleRadiusX.Text.Replace('.', ','), out radiusX))
            {
                textBoxSimpleRadius.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxSimpleRadiusY.Text.Replace('.', ','), out radiusY))
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


        private bool GetEllipseDataCompareWithError(out int startX, out int startY, out int ellipseCount, out int stepX, out int stepY)
        {
            bool error = false;

            textBoxStartX.BackColor = inputColor;
            textBoxStartY.BackColor = inputColor;
            textBoxStepX.BackColor = inputColor;
            textBoxStepY.BackColor = inputColor;
            textBoxEllipseCount.BackColor = inputColor;

            if (!int.TryParse(textBoxStartX.Text.Replace('.', ','), out startX))
            {
                textBoxX0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxStartY.Text.Replace('.', ','), out startY))
            {
                textBoxY0.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxEllipseCount.Text.Replace('.', ','), out ellipseCount))
            {
                textBoxSimpleRadius.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxStepX.Text.Replace('.', ','), out stepX))
            {
                textBoxSimpleRadius.BackColor = errorColor;
                error = true;
            }

            if (!int.TryParse(textBoxStepY.Text.Replace('.', ','), out stepY))
            {
                textBoxSimpleRadius.BackColor = errorColor;
                error = true;
            }

            return !error;
        }

        private void CircleCompareProcessing(DrawHelper.DrawCircleMethod method, Color workColor)
        {
            int startRadius, endRadius, circleCount, step;
            CompareType type;

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

        private void EllipseCompareProcessing(DrawHelper.DrawEllipseMethod method, Color workColor)
        {
            int startX, startY, ellipseCount, stepX, stepY;

            if (GetEllipseDataCompareWithError(out startX, out startY, out ellipseCount, out stepX, out stepY))
            {
                Point center = Point.Empty;
                center.X = workBitmap.Width / 2;
                center.Y = workBitmap.Height / 2;

                DrawHelper.DrawEllipseCompare(workBitmap, method, workColor, center, startX, startY, ellipseCount, stepX, stepY);
                graph.DrawImage(workBitmap, 0, 0);
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
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

        private void SimpleEllipseProcessing(DrawHelper.DrawEllipseMethod method, Color workColor)
        {
            Point center = Point.Empty;
            int radiusX, radiusY;

            if (GetEllipseDataSimpleWithError(out center, out radiusX, out radiusY))
            {
                DrawHelper.DrawEllipse(workBitmap, method, workColor, center, radiusX, radiusY);
                graph.DrawImage(workBitmap, 0, 0);
                workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height, graph);
            }
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

        private void DrawSimpleColorButton_Click(object sender, EventArgs e)
        {
            DrawChoose(SimpleCircleProcessing, SimpleEllipseProcessing, colorButton.BackColor);
        }
        private void DrawSimpleBackButton_Click(object sender, EventArgs e)
        {
            DrawChoose(SimpleCircleProcessing, SimpleEllipseProcessing, workBackColor);
        }
        private void DrawCompareColorButton_Click(object sender, EventArgs e)
        {
            DrawChoose(CircleCompareProcessing, EllipseCompareProcessing, colorButton.BackColor);
        }
        private void DrawCompareBackButton_Click(object sender, EventArgs e)
        {
            DrawChoose(CircleCompareProcessing, EllipseCompareProcessing, workBackColor);
        }

        private void DrawChoose(ProcessingCircle processCircle, ProcessingEllipse processEllipse, Color workColor)
        {
            if (canonicalRadioButton.Checked)
            {
                if (radioButtonCircle.Checked)
                {
                    processCircle(DrawHelper.DrawCircleCanonical, workColor);
                }
                else if (radioButtonEllipse.Checked)
                {
                    processEllipse(DrawHelper.DrawEllipseCanonical, workColor);
                }
            }
            else if (parametricRadioButton.Checked)
            {
                if (radioButtonCircle.Checked)
                {
                    processCircle(DrawHelper.DrawCircleParam, workColor);
                }
                else if (radioButtonEllipse.Checked)
                {
                    processEllipse(DrawHelper.DrawEllipseParam, workColor);
                }
            }
            else if (bresenhamRadioButton.Checked)
            {
                if (radioButtonCircle.Checked)
                {
                    processCircle(DrawHelper.DrawCircleBresenham, workColor);
                }
                else if (radioButtonEllipse.Checked)
                {
                    processEllipse(DrawHelper.DrawEllipseBresenham, workColor);
                }
            }
            else if (middleRadioButton.Checked)
            {
                if (radioButtonCircle.Checked)
                {
                    processCircle(DrawHelper.DrawCircleMiddle, workColor);
                }
                else if (radioButtonEllipse.Checked)
                {
                    processEllipse(DrawHelper.DrawEllipseMiddle, workColor);
                }
            }
            else if (standartRadioButton.Checked)
            {
                if (radioButtonCircle.Checked)
                {
                    processCircle(DrawHelper.DrawCircleStandart, workColor);
                }
                else if (radioButtonEllipse.Checked)
                {
                    processEllipse(DrawHelper.DrawEllipseStandart, workColor);
                }
            }
        }

        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            ellipseDataSimple.Visible = radioButtonEllipse.Checked;
            ellipseDataCompare.Visible = radioButtonEllipse.Checked;
            tabControlData.Update();
        }
        private void tabControlData_Selecting(object sender, TabControlCancelEventArgs e)
        {
            ellipseDataSimple.Visible = radioButtonEllipse.Checked;
            ellipseDataCompare.Visible = radioButtonEllipse.Checked;
            
            tabControlData.Update();
        }
    }
}