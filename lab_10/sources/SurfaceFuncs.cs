using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    public static class SurfaceFuncs
    {
        public static double EllipsoidFunc(double x, double z)
        {
            double y = Math.Sin(x * x) * Math.Cos(z * z);

            return y;
        }

        public static double HyperbaloidOneFunc(double x, double z)
        {
            double y = Math.Sin(x) * Math.Cos(z);

            return y;
        }

        public static double HyperbaloidTwoFunc(double x, double z)
        {
            double y = 1;

            return y;
        }

        public static double HyperbaloidParabFunc(double x, double z)
        {
            double y = 1;

            return y;
        }
    }
}
