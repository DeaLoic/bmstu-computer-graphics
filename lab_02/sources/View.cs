using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_02
{
    class View
    {
        Graphics g;
        Size size;

        Brush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(Color.Black, 1);

        Font font = new Font("Arial", 14);

        public View(Graphics g, Size size)
        {
            this.g = g;
            this.size = size;
        }

        public void Show(ref Model model)
        {
            PrintAxis();
            PrintParabola(ref model.parabola);
            PrintPolygon(ref model.circle);
            PrintHatching(ref model.hatching);

        }

        public void PrintAxis()
        {
            g.DrawLine(pen, 10, 0, 10, size.Height);
            g.DrawLine(pen, 10, size.Height, 5, size.Height - 7);
            g.DrawLine(pen, 10, size.Height, 15, size.Height - 7);

            g.DrawString("Y", font, brush, 20, size.Height - 20);

            g.DrawLine(pen, 0, 10, size.Width, 10);
            g.DrawLine(pen, size.Width, 10, size.Width - 7, 5);
            g.DrawLine(pen, size.Width, 10, size.Width - 7, 15);

            g.DrawString("X", font, brush, size.Width - 20, 20);
        }

        public void PrintDots(ref List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                g.FillRectangle(brush, new Rectangle(points[i], new Size(1, 1)));
            }
        }

        public void PrintPolygon(ref List<Point> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                g.DrawLine(pen, points[i], points[i + 1]);
            }
            if (points.Count >= 2)
            {
                g.DrawLine(pen, points[0], points[points.Count - 1]);
            }
        }
        public void PrintPolygon(ref List<PointF> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                g.DrawLine(pen, points[i], points[i + 1]);
            }
            if (points.Count >= 2)
            {
                g.DrawLine(pen, points[0], points[points.Count - 1]);
            }
        }

        public void PrintParabola(ref List<Point> points)
        {
            for (int i = 0; i < points.Count - 2; i++)
            {
                g.DrawLine(pen, points[i], points[i + 2]);
            }
        }

        public void PrintParabola(ref List<PointF> points)
        {
            for (int i = 0; i < points.Count - 2; i++)
            {
                g.DrawLine(pen, points[i], points[i + 2]);
            }
        }

        public void PrintHatching(ref List<Section> sections)
        {
            for (int i = 0; i < sections.Count; i++)
            {
                g.DrawLine(pen, sections[i].first, sections[i].second);
            }
        }

        public void Clear()
        {
            g.Clear(Color.Cornsilk);
        }
    }
}
