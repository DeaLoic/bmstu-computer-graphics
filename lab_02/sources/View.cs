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
        Brush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(Color.Black);

        public View(Graphics g)
        {
            this.g = g;
        }

        public void PrintDots(ref List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                g.FillRectangle(brush, new Rectangle(points[i], new Size(1, 1)));
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
