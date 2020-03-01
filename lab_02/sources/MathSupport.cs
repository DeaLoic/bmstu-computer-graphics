using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace lab_02
{
    public static class MathSupport
    {
        public static int CompareDouble(double first, double second)
        {
            if (Math.Abs(first - second) <= Math.Abs(first * .00001))
            {
                return 0;
            }
            else if (first > second)
            {
                return 1;
            }

            return -1;
        }

        public static double SectionLenght(PointF first, PointF second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }
    }
}
