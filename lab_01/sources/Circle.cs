using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_01
{
    class Circle
    {
        public (PointF, PointF, PointF) dotsSet;

        public PointF centre;
        public double radius;

        public bool isCorrect = false;

        public Circle(PointF centre, double radius)
        {
            isCorrect = false;

            if (!centre.IsEmpty || radius > 0)
            {
                isCorrect = true;
                this.radius = radius;
                this.centre = centre;
            }
        }

        public Circle(PointF firstDot, PointF secondDot, PointF thirdDot)
        {
            isCorrect = true;

            if (MathSupport.CompareDouble(firstDot.X, secondDot.X) == 0 && MathSupport.CompareDouble(thirdDot.X, secondDot.X) == 0)
            {
                isCorrect = false;
            }
            else if (MathSupport.CompareDouble(firstDot.X, secondDot.X) == 0)
            {
                PointF tempDot = firstDot;
                firstDot = thirdDot;
                thirdDot = tempDot;
            }
            else if (MathSupport.CompareDouble(thirdDot.X, secondDot.X) == 0)
            {
                PointF tempDot = firstDot;
                firstDot = secondDot;
                secondDot = tempDot;
            }

            if (isCorrect)
            {
                Straight firstChordStraight = new Straight(firstDot, secondDot);
                Straight secondChordStraight = new Straight(secondDot, thirdDot);

                this.centre = firstChordStraight.Perpendecular(firstDot).Intersection(secondChordStraight.Perpendecular(thirdDot));
                if (this.centre.IsEmpty)
                {
                    isCorrect = false;
                }
                else
                {
                    this.radius = MathSupport.SectionLenght(this.centre, secondDot);
                    this.dotsSet = (firstDot, secondDot, thirdDot);
                }
            }
        }

        // https://e-maxx.ru/algo/circle_tangents
        // Решение системы: https://e-maxx.ru/tex2png/cache/1d1f86d073e3245eb60eb11a355f43c9.png
        public List<Section> GeneralTangents(Circle secondCircle)
        {
            List<Section> generalTangents = new List<Section>();
            if (isCorrect && (secondCircle?.isCorrect ?? false))
            {
                Straight tanget = this.GeneralTanget(new PointF(secondCircle.centre.X - centre.X, secondCircle.centre.Y - centre.Y),
                                                                    secondCircle.radius, radius);
                tanget.C -= tanget.A * centre.X + tanget.B * centre.Y;
                if (tanget.isCorrect)
                {
                    generalTangents.Add(new Section(tanget.Intersection(tanget.Perpendecular(centre)),
                                                    tanget.Intersection(tanget.Perpendecular(secondCircle.centre))));
                }


                tanget = this.GeneralTanget(new PointF(secondCircle.centre.X - centre.X, secondCircle.centre.Y - centre.Y),
                                                                    -secondCircle.radius, -radius);
                tanget.C -= tanget.A * centre.X + tanget.B * centre.Y;
                if (tanget.isCorrect)
                {
                    generalTangents.Add(new Section(tanget.Intersection(tanget.Perpendecular(centre)),
                                                    tanget.Intersection(tanget.Perpendecular(secondCircle.centre))));
                }


                tanget = this.GeneralTanget(new PointF(secondCircle.centre.X - centre.X, secondCircle.centre.Y - centre.Y),
                                                                    secondCircle.radius, -radius);
                tanget.C -= tanget.A * centre.X + tanget.B * centre.Y;
                if (tanget.isCorrect)
                {
                    generalTangents.Add(new Section(tanget.Intersection(tanget.Perpendecular(centre)),
                                                    tanget.Intersection(tanget.Perpendecular(secondCircle.centre))));
                }


                tanget = this.GeneralTanget(new PointF(secondCircle.centre.X - centre.X, secondCircle.centre.Y - centre.Y),
                                                                    -secondCircle.radius, radius);
                tanget.C -= tanget.A * centre.X + tanget.B * centre.Y;
                if (tanget.isCorrect)
                {
                    generalTangents.Add(new Section(tanget.Intersection(tanget.Perpendecular(centre)),
                                                    tanget.Intersection(tanget.Perpendecular(secondCircle.centre))));
                }
            }

            return generalTangents;
        }

        private Straight GeneralTanget(PointF normalizedSecondCentre, double r2, double r1)
        {
            Straight tanget = new Straight();

            double r = r2 - r1;
            double z = Math.Sqrt(normalizedSecondCentre.X) + Math.Sqrt(normalizedSecondCentre.Y);
            double d = z - Math.Sqrt(r);
            if (d >= 1e-7)
            {
                d = Math.Sqrt(Math.Abs(d));
                double A = (normalizedSecondCentre.X * r + normalizedSecondCentre.Y * d) / z;
                double B = (normalizedSecondCentre.Y * r - normalizedSecondCentre.X * d) / z;
                double C = r1;

                tanget = new Straight(A, B, C);
            }

            return tanget;
        }
    }
}
