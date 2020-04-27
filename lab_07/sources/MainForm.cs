using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab_07
{
    public partial class MainForm : Form
    {
        Color workBackColor;
        Pen cutterPen = new Pen(Color.Red);
        Pen linesPen = new Pen(Color.DarkBlue);

        Graphics graph;
        Bitmap workBitmap;

        List<Point> cutter = new List<Point>();
        List<(Point, Point)> lines = new List<(Point, Point)>();
        List<Point> currentLine = new List<Point>();

        bool expectedVertical = false;
        bool expectedHorizontal = false;


        public MainForm()
        {
            InitializeComponent();
            workBackColor = mainCanvas.BackColor;
            workBitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height);
            graph = Graphics.FromImage(workBitmap);
            mainCanvas.Image = workBitmap;
        }

        private void UpdateMainBitmap()
        {
            mainCanvas.Image = workBitmap;
            mainCanvas.Update();
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = workBackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                graph.Clear(colorDialog.Color);
                workBackColor = colorDialog.Color;
            }
            cutter.Clear();
            lines.Clear();
            UpdateMainBitmap();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void Redraw()
        {
            graph.Clear(workBackColor);

            if (cutter.Count > 3)
            {
                graph.DrawPolygon(cutterPen, cutter.ToArray());
            }

            for (int i = 0; i < lines.Count; i++)
            {
                graph.DrawLine(linesPen, lines[i].Item1, lines[i].Item2);
            }
            UpdateMainBitmap();
        }

        private void ButtonLastDelete_Click(object sender, EventArgs e)
        {
            if (lines.Count > 0)
            {
                lines.RemoveAt(lines.Count - 1);
            }

            Redraw();
        }

        private void ButtonHorizontal_Click(object sender, EventArgs e)
        {
            expectedHorizontal = true;
            expectedVertical = false;
        }

        private void ButtonVertical_Click(object sender, EventArgs e)
        {
            expectedVertical = true;
            expectedHorizontal = false;
        }

        private void MainFillLogic()
        {
            if (cutter.Count == 4 && lines.Count > 0)
            {
                UpdateMainBitmap();
                var resLines = Agregator.Cutting((cutter[0], cutter[2]), lines);
                foreach (var line in resLines)
                {
                    graph.DrawLine(new Pen(colorButton.BackColor), line.Item1, line.Item2);
                }
                UpdateByBitmap();
            }
            else
            {
                MessageBox.Show("Введите отсекатель и хотя бы один отрезок");
            }

        }

        private void UpdateByBitmap()
        {
            UpdateMainBitmap();
        }

        private void mainCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            Console.WriteLine(e.Button);

            if (e.Button == MouseButtons.Left)
            {
                if (expectedHorizontal)
                {
                    if (currentLine.Count > 0)
                    {
                        point.Y = currentLine[currentLine.Count - 1].Y;
                        expectedHorizontal = false;
                    }
                }
                else if (expectedVertical)
                {
                    if (currentLine.Count > 0)
                    {
                        point.X = currentLine[currentLine.Count - 1].X;
                        expectedVertical = false;
                    }
                }
                EnterDot(point);
            }
            else
            {
                MainFillLogic();
            }
        }

        private void EnterDot(Point point)
        {
            if (radioButtonEnterLine.Checked)
            {
                currentLine.Add(point);
                if (currentLine.Count == 2)
                {
                    lines.Add((currentLine[0], currentLine[1]));
                    currentLine.Clear();
                }
            }
            else
            {
                if (cutter.Count == 0)
                {
                    cutter.Add(point);
                }
                else if (cutter.Count == 1)
                {
                    cutter.Add(new Point(point.X, cutter[0].Y));
                    cutter.Add(point);
                    cutter.Add(new Point(cutter[0].X, point.Y));
                }
                else
                {
                    MessageBox.Show("Отсекатель уже введен");
                }
            }

            Redraw();
        }
        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            coordsLabel.Text = e.Location.ToString();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Point curPoint = Point.Empty;
            curPoint.X = int.Parse(textBoxX1.Text);
            curPoint.Y = int.Parse(textBoxY1.Text);
            EnterDot(curPoint);
        }
    }

}