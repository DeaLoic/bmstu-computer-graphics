using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_02
{
    class Straight
    {

        public double A;
        public double B;
        public double C;

        public bool isCorrect = false;

        public Straight()
        {
            isCorrect = false;
        }

        public Straight(double A, double B, double C)
        {
            isCorrect = false;
            if (MathSupport.CompareDouble(A, 0) != 0 || MathSupport.CompareDouble(B, 0) != 0)
            {
                this.A = A;
                this.B = B;
                this.C = C;

                isCorrect = true;
            }
        }

        // Вывод из канонического (x - x1) / (x2 - x1) = (y - y1) / (y2 - y1)
        public Straight(PointF first, PointF second)
        {
            isCorrect = true;

            if (MathSupport.CompareDouble(first.X, second.X) == 0 && MathSupport.CompareDouble(first.Y, second.Y) == 0)
            {
                isCorrect = false;
            }
            else
            {
                if (MathSupport.CompareDouble(first.X, second.X) == 0)
                {
                    A = 1;
                    B = 0;
                    C = -first.X;
                }
                else if (MathSupport.CompareDouble(first.Y, second.Y) == 0)
                {
                    A = 0;
                    B = 1;
                    C = -first.Y;
                }
                else
                {
                    A = second.Y - first.Y;
                    B = first.X - second.X;
                    C = -first.X * second.Y + first.Y * second.X;
                }
            }
        }

        // Находим перпендикуляр (А, В) и задаем прямую через уравнение по направ вектору (x - x1) / p1 = (y - y1) / p2
        public Straight Perpendecular(PointF point)
        {
            Straight perpendicular = new Straight();
            if (isCorrect)
            {
                perpendicular = new Straight(B, -A, -B * point.X + A * point.Y);
            }

            return perpendicular;
        }

        // Формула Крамера для этой системы: https://e-maxx.ru/tex2png/cache/f77e66a94c03f61814aa0ef92635c401.png
        public PointF Intersection(Straight secondStraight)
        {
            PointF intersecPoint = new PointF();
            if (isCorrect && (secondStraight?.isCorrect ?? false))
            {
                double mainDeterminant = A * secondStraight.B - secondStraight.A * B;
                if (mainDeterminant != 0)
                {
                    intersecPoint.X = -(float)((C * secondStraight.B - secondStraight.C * B) / mainDeterminant);
                    intersecPoint.Y = -(float)((A * secondStraight.C - secondStraight.A * C) / mainDeterminant);
                }
            }

            return intersecPoint;
        }
    }
}
