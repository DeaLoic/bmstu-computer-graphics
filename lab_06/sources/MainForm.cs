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

namespace lab_06
{
    public partial class MainForm : Form
    {
        Color workBackColor;

        Graphics graph;
        Bitmap workBitmap;

        List<List<Point> > polygons = new List<List<Point>>();

        List<Point> currentPolygon = new List<Point>();

        int maxX = 0;

        bool expectedVertical = false;
        bool expectedHorizontal = false;

        Agregator agregator = new Agregator();

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
            maxX = 0;
            polygons.Clear();
            currentPolygon.Clear();
            UpdateMainBitmap();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Redraw();

        }

        private void Redraw()
        {
            graph.Clear(workBackColor);
            agregator = new Agregator();
            Pen pen = new Pen(colorButton.BackColor);
            foreach (var polygon in polygons)
            {
                graph.DrawPolygon(pen, polygon.ToArray());
            }

            for (int i = 0; i < currentPolygon.Count - 1; i++)
            {
                graph.DrawLine(pen, currentPolygon[i], currentPolygon[i + 1]);
            }
            UpdateMainBitmap();
        }

        private void ButtonLastDelete_Click(object sender, EventArgs e)
        {
            if (currentPolygon.Count > 0)
            {
                currentPolygon.RemoveAt(currentPolygon.Count - 1);
            }
            else if (polygons.Count > 0)
            {
                currentPolygon = polygons[polygons.Count - 1];
                polygons.RemoveAt(polygons.Count - 1);
                currentPolygon.RemoveAt(currentPolygon.Count - 1);
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

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            if (polygons.Count >= 1 && currentPolygon.Count == 0)
            {
                if (radioButtonWayQuick.Checked)
                {
                    if (!agregator.isEmpty)
                    {
                        Redraw();
                    }
                    var startTime = System.Diagnostics.Stopwatch.StartNew();
                    UpdateMainBitmap();
                    workBitmap.SetPixel(1, 1, Color.Black);
                    for (int i = 0; i < 1; i++)
                    {
                        Agregator.FillPolygon(ExtractRibs(polygons), maxX, colorButton.BackColor, workBackColor, workBitmap);
                    }

                    startTime.Stop();
                    var resultMillisecondsTime = startTime.Elapsed.TotalMilliseconds / 100;
                    resultMessage.Text = String.Format("Результат: {0}ms", resultMillisecondsTime.ToString());

                    UpdateByBitmap(workBitmap);
                }
                else if (radioButtonWayStep.Checked)
                {
                    agregator = new Agregator(ExtractRibs(polygons), maxX, colorButton.BackColor, workBackColor, workBitmap);
                    while (!agregator.NextStep())
                    {
                        UpdateByBitmap(agregator.workBitmap);
                        Thread.Sleep(10);
                    }
                    Agregator.DrawRibs(workBitmap, ExtractRibs(polygons), colorButton.BackColor);
                    UpdateByBitmap(agregator.workBitmap);
                }
            }
            else
            {
                if (polygons.Count == 0)
                {
                    MessageBox.Show("Введите хотя бы один многоугольник");
                }
                if (currentPolygon.Count != 0)
                {
                    MessageBox.Show("Текущий вводимый многоугольник незамкнут");
                }
            }
        }

        private List<(Point, Point)> ExtractRibs(List<List<Point> > polygons)
        {
            List<(Point, Point)> ribs = new List<(Point, Point)>();

            foreach(var polygon in polygons)
            {
                for (int i = 0; i < polygon.Count - 1; i++)
                {
                    ribs.Add((polygon[i], polygon[i + 1]));
                }
                ribs.Add((polygon[0], polygon[polygon.Count - 1]));
            }

            return ribs;
        }

        private void UpdateByBitmap(Bitmap bitmap)
        {
            UpdateMainBitmap();
        }

        private void mainCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            if (expectedHorizontal)
            {
                if (currentPolygon.Count > 0)
                {
                    point.Y = currentPolygon[currentPolygon.Count - 1].Y;
                    expectedHorizontal = false;
                }
            }
            else if (expectedVertical)
            {
                if (currentPolygon.Count > 0)
                {
                    point.X = currentPolygon[currentPolygon.Count - 1].X;
                    expectedVertical = false;
                }
            }
            EnterDot(point);
        }

        private void EnterDot(Point point)
        {
            maxX = Math.Max(maxX, point.X);
            if (currentPolygon.Contains(point))
            {
                polygons.Add(currentPolygon);
                currentPolygon = new List<Point>();
            }
            else
            {
                currentPolygon.Add(point);
            }

            Redraw();
        }
        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            coordsLabel.Text = e.Location.ToString();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Point curPoint = new Point();
            curPoint.X = int.Parse(textBoxX.Text);
            curPoint.Y = int.Parse(textBoxY.Text);
            EnterDot(curPoint);
        }
    }

}