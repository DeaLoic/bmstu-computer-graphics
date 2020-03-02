using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace lab_01
{
    class Converter
    {
        private PointF min;
        private PointF max;
        private Size area;
        private int indent;
        private float scale;

        private int indentX;
        private int indentY;

        public Converter(PointF min, PointF max, Size area, int indent = 20)
        {
            this.min = min;
            this.max = max;
            this.area = area;
            this.indent = indent;


            scale = Math.Min((area.Width - indent * 2) / (max.X - min.X), (area.Height - indent * 2) / (max.Y - min.Y));

            indentX = (int)(indent + ((area.Width - indent * 2) - scale * (max.X - min.X)) / 2);
            indentY = (int)(indent + ((area.Height - indent * 2) - scale * (max.Y - min.Y)) / 2);
        }

        public PointF ConvertDot(PointF point)
        {
            PointF resultPoint = new PointF();

            resultPoint.X = ConvertX(point.X);
            resultPoint.Y = ConvertY(point.Y);

            return resultPoint;
        }

        public PointF ConvertDotOffset(PointF point)
        {
            point = ConvertDot(point);
            if (point.X / area.Width > 0.75)
            {
                point.X -= 30;
            }
            point.X += 4;
            point.Y += 10;
            return point;
        }

        public float ConvertSize(float size)
        {
            return size * scale;
        }

        private float ConvertX(float x)
        {
            return ((x - min.X) * scale) + indentX;
        }

        private float ConvertY(float y)
        {
            return ((max.Y - y) * scale) + indentY;
        }
    }
}
