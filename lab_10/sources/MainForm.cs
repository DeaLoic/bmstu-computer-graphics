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

namespace lab_10
{
    public partial class MainForm : Form
    {
        Color workBackColor;

        Graphics graph;
        SecondOrderSurface surface = new SecondOrderSurface(SurfaceFuncs.EllipsoidFunc);

        int ox, oy, oz;

        public MainForm()
        {
            InitializeComponent();
            workBackColor = mainCanvas.BackColor;
            graph = mainCanvas.CreateGraphics();
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
            {
                colorButton.BackColor = colorDialog.Color;
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

        private void Main()
        {
            DotsDistance borderX = new DotsDistance();
            DotsDistance borderZ = new DotsDistance();

            borderX.max = double.Parse(textBoxStartX.Text.Replace('.', ','));
            borderX.min = double.Parse(textBoxEndX.Text.Replace('.', ','));
            borderX.step = double.Parse(textBoxStepX.Text.Replace('.', ','));

            borderZ.max = double.Parse(textBoxStartZ.Text.Replace('.', ','));
            borderZ.min = double.Parse(textBoxEndZ.Text.Replace('.', ','));
            borderZ.step = double.Parse(textBoxStepZ.Text.Replace('.', ','));

            graph.Clear(workBackColor);
            surface.HorizontDraw(borderX, borderZ, ox, oy, oz, mainCanvas.Size, graph, new Pen(colorButton.BackColor));
        }

        private void mainCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Main();
            }
        }

        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            coordsLabel.Text = e.Location.ToString();
        }

        private void radioButtonEnterEllipsoid_CheckedChanged(object sender, EventArgs e)
        {
            surface = new SecondOrderSurface(SurfaceFuncs.EllipsoidFunc);
        }

        private void radioButtonEnterHyperbOne_CheckedChanged(object sender, EventArgs e)
        {
            surface = new SecondOrderSurface(SurfaceFuncs.HyperbaloidOneFunc);
        }

        private void radioButtonEnterHyperbTwo_CheckedChanged(object sender, EventArgs e)
        {
            surface = new SecondOrderSurface(SurfaceFuncs.HyperbaloidTwoFunc);
        }

        private void radioButtonEnterHyperbParab_CheckedChanged(object sender, EventArgs e)
        {
            surface = new SecondOrderSurface(SurfaceFuncs.HyperbaloidParabFunc);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            ox += int.Parse(textBoxRotateX.Text);
            oy += int.Parse(textBoxRotateY.Text);
            oz += int.Parse(textBoxRotateZ.Text);

            Main();
        }
    }
}