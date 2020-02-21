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
        private double scaleX;
        private double scaleY;

        public Converter(PointF min, PointF max, Size area, int indent = 20)
        {
            this.min = min;
            this.max = max;
            this.area = area;
            this.indent = indent;

            scaleX = (area.Width - indent * 2) / (max.X - min.X);
            scaleY = (area.Height - indent * 2) / (max.Y - min.Y);
        }

        public PointF ConvertDot(PointF point)
        {
            PointF resultPoint = new PointF();

            resultPoint.X = (float) ConvertX(point.X);
            resultPoint.Y = (float) ConvertY(point.Y);

            return resultPoint;
        }

        private double ConvertY(double y)
        {
            return ((max.Y - y) * scaleY + indent);
        }

        private double ConvertX(double x)
        {
            return ((x - min.X) * scaleX + indent);
        }
    }
}
