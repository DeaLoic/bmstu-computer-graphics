using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_08
{
    public class Vector
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public Point first;
        public Point second;

        public Vector(double X = 0, double Y = 0, double Z = 0)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector(Point first, Point second)
        {
            this.first = first;
            this.second = second;

            X = second.X - first.X;
            Y = second.Y - first.Y;
            Z = 0;
        }

        public Vector VectorMultiplication(Vector second)
        {
            return new Vector(Y * second.Z - Z * second.Y, Z * second.X - X * second.Z, X * second.Y - Y * second.X);
        }

        public double ScalarMultiplication(Vector second)
        {
            return X * second.X + Y * second.Y + Z * second.Z;
        }
    }
}
