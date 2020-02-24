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

        public Converter(PointF min, PointF max, Size area, int indent = 20)
        {
            this.min = min;
            this.max = max;
            this.area = area;
            this.indent = indent;

            scale = Math.Min((area.Width - indent * 2) / (max.X - min.X), (area.Height - indent * 2) / (max.Y - min.Y));
        }

        public PointF ConvertDot(PointF point)
        {
            PointF resultPoint = new PointF();

            resultPoint.X = ConvertX(point.X);
            resultPoint.Y = ConvertY(point.Y);

            return resultPoint;
        }

        public float ConvertSize(float size)
        {
            return size * scale;
        }
        private float ConvertY(float y)
        {
            return ((max.Y - y) * scale) + indent;
        }

        private float ConvertX(float x)
        {
            return ((x - min.X) * scale) + indent;
        }
    }
}
