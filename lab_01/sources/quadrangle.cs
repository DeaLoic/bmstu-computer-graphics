using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_01
{
    class Quadrangle
    {
        public PointF[] points;

        public double Square;

        public Quadrangle(Section firstRadius, Section secondRadius)
        {
            if (firstRadius.first.X > firstRadius.second.X || firstRadius.first.Y > firstRadius.second.Y)
            {
                PointF temp = firstRadius.first;
                firstRadius.first = firstRadius.second;
                firstRadius.second = temp;
            }

            if (secondRadius.first.X > secondRadius.second.X || secondRadius.first.Y > secondRadius.second.Y)
            {
                PointF temp = secondRadius.first;
                secondRadius.first = secondRadius.second;
                secondRadius.second = temp;
            }

            PointF A = firstRadius.first;
            PointF B = firstRadius.second;
            PointF C = secondRadius.second;
            PointF D = secondRadius.first;

            points = new PointF[] { A, B, C, D };


            Square = TriangleSquare(new Section(A, B).Len, new Section(B, C).Len, new Section(A, C).Len) + 
                     TriangleSquare(new Section(C, D).Len, new Section(D, A).Len, new Section(A, C).Len);
        }

        private double TriangleSquare(double a, double b, double c)
        {
            double p = 1.0 / 2 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
