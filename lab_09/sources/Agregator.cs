using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security;

namespace lab_09
{

    internal static class Agregator
    {
        public static List<Point> Cutting(List<Point> cutter, List<Point> polygon)
        {

            if (!IsConvex(cutter))
            {
                throw new Exception("Отсекатель не выпуклый");
            }
            else
            {
                List<Vector> normalVectors = FormNormalVectors(cutter);
                List<Point> newTempPolygon;

                Vector D;
                Vector W;

                double scalarD;
                double scalarW;
                double t;

                Point tempPoint;
                for (int i = 0; i < cutter.Count; i++)
                {
                    newTempPolygon = new List<Point>();
                    if (new Vector(cutter[i], GetVertex(polygon, 0)).ScalarMultiplication(normalVectors[i]) > 0)
                    {
                        newTempPolygon.Add(GetVertex(polygon, 0));
                    }

                    for (int j = 0; j < polygon.Count; j++)
                    {
                        D = new Vector(GetVertex(polygon, j), GetVertex(polygon, j + 1));
                        scalarD = D.ScalarMultiplication(normalVectors[i]);

                        if (scalarD != 0)
                        {

                            W = new Vector(cutter[i], polygon[j]);
                            scalarW = W.ScalarMultiplication(normalVectors[i]);
                            t = -scalarW / scalarD;

                            if (0 <= t && t <= 1)
                            {
                                newTempPolygon.Add(CutByParam(t, (GetVertex(polygon, j), GetVertex(polygon, j + 1))));
                            }
                        }

                        if (new Vector(cutter[i], GetVertex(polygon, j + 1)).ScalarMultiplication(normalVectors[i]) > 0)
                        {
                            newTempPolygon.Add(GetVertex(polygon, j + 1));
                        }
                    }

                    polygon = newTempPolygon;
                }
            }

            return polygon;
        }

        private static bool IsConvex(List<Point> cutter)
        {
            int sign = 0;
            bool isConvex = true;

            if (cutter.Count >= 3)
            {
                Vector first = new Vector(cutter[0], cutter[1]);
                Vector second;
                Vector result;

                for (int i = 0; i < cutter.Count && isConvex; i++)
                {
                    second = new Vector(GetVertex(cutter, i), GetVertex(cutter, i + 1));
                    result = first.VectorMultiplication(second);

                    if (sign == 0)
                    {
                        sign = Math.Sign(result.Z);
                    }
                    else if ((sign != Math.Sign(result.Z)) && (result.Z != 0))
                    {
                        sign = 0;
                        isConvex = false;
                    }

                    first = second;
                }
            }

            if (sign == 0)
            {
                isConvex = false;
            }

            return isConvex;
        }

        private static List<Vector> FormNormalVectors(List<Point> cutter)
        {
            List<Vector> normalVectors = new List<Vector>();
            Vector vector;
            Vector result;

            for (int i = 0; i < cutter.Count; i++)
            {
                vector = new Vector(GetVertex(cutter, i), GetVertex(cutter, i + 1));
                if (vector.X != 0)
                {
                    result = new Vector(-vector.Y / vector.X, 1);
                }
                else
                {
                    result = new Vector(1, -vector.X / vector.Y);
                }

                if (result.ScalarMultiplication(new Vector(GetVertex(cutter, i - 1), GetVertex(cutter, i + 1))) > 0)
                {
                    result.X = -result.X;
                    result.Y = -result.Y;
                }

                normalVectors.Add(result);
            }

            return normalVectors;
        }
        private static (Point, Point) CutByParam(double t_down, double t_up, (Point, Point) line)
        {
            return (new Point((int)Math.Round(line.Item1.X + (line.Item2.X - line.Item1.X) * t_down),
                              (int)Math.Round(line.Item1.Y + (line.Item2.Y - line.Item1.Y) * t_down)),

                    new Point((int)Math.Round(line.Item1.X + (line.Item2.X - line.Item1.X) * t_up),
                              (int)Math.Round(line.Item1.Y + (line.Item2.Y - line.Item1.Y) * t_up)));
        }

        private static Point CutByParam(double t, (Point, Point) line)
        {
            return new Point((int)Math.Round(line.Item1.X + (line.Item2.X - line.Item1.X) * t),
                              (int)Math.Round(line.Item1.Y + (line.Item2.Y - line.Item1.Y) * t));
        }

        private static Point GetVertex(List<Point> cutter, int index)
        {
            if (index >= 0)
            {
                return cutter[index % cutter.Count];
            }
            else
            {
                return cutter[cutter.Count - 1 + index % cutter.Count];
            }
        }
    }
}