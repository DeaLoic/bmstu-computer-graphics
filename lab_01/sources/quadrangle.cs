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
        public PointF A;
        public PointF B;
        public PointF C;
        public PointF D;

        public Section AB;
        public Section BC;
        public Section CD;
        public Section DA;

        public Section AC;
        public Section BD;

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

            A = firstRadius.first;
            B = firstRadius.second;
            C = secondRadius.second;
            D = secondRadius.first;

            AB = new Section(A, B);
            BC = new Section(B, C);
            CD = new Section(C, D);
            DA = new Section(D, A);

            AC = new Section(A, C);
            BD = new Section(B, D);

            Square = TriangleSquare(AB.Len, BC.Len, AC.Len) + TriangleSquare(CD.Len, DA.Len, AC.Len);
        }

        private double TriangleSquare(double a, double b, double c)
        {
            double p = 1 / 2 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
