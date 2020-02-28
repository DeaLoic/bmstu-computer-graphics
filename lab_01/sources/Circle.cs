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
        public List<PointF> dotsSet;

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

                PointF firstCentre = (new Section(firstDot, secondDot)).GetCentre();
                PointF secondCentre = (new Section(secondDot, thirdDot)).GetCentre();

                this.centre = firstChordStraight.Perpendecular(firstCentre).Intersection(secondChordStraight.Perpendecular(secondCentre));
                if (this.centre.IsEmpty)
                {
                    isCorrect = false;
                }
                else
                {
                    this.radius = MathSupport.SectionLenght(this.centre, secondDot);
                    this.dotsSet = new List<PointF> { firstDot, secondDot, thirdDot };
                }
            }
        }

        // https://e-maxx.ru/algo/circle_tangents
        // Решение системы: https://e-maxx.ru/tex2png/cache/1d1f86d073e3245eb60eb11a355f43c9.png
        public List<Section> GeneralTangents(Circle secondCircle)
        {
            List<Section> generalTangents = new List<Section>();
            List<Straight> tangents = new List<Straight>();
            if (isCorrect && (secondCircle?.isCorrect ?? false))
            {
                for (int i = -1; i <= 1; i += 2)
                {
                    tangents.Add(this.GeneralTanget(new PointF(secondCircle.centre.X - centre.X, secondCircle.centre.Y - centre.Y),
                                                    radius * i, secondCircle.radius * i));
                }
                    
                for (int i = 0; i < tangents.Count; i++)
                {
                    tangents[i].C -= tangents[i].A * centre.X + tangents[i].B * centre.Y;
                    generalTangents.Add(new Section(tangents[i].Intersection(tangents[i].Perpendecular(centre)),
                                                    tangents[i].Intersection(tangents[i].Perpendecular(secondCircle.centre))));
                }

                 generalTangents = generalTangents.Where(t => t.IsCorrect).ToList();
                //generalTangents.AddRange(ExternalGeneralTangets(secondCircle));
            }

            return generalTangents;
        }

        private Straight GeneralTanget(PointF normalizedSecondCentre, double r1, double r2)
        {
            Straight tanget = new Straight();

            double r = r2 - r1;
            double z = Math.Pow(normalizedSecondCentre.X, 2) + Math.Pow(normalizedSecondCentre.Y, 2);
            double d = z - Math.Pow(r, 2);
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

        private List<Section> ExternalGeneralTangets(Circle secondCircle)
        {
            List<Section> externalTangets = new List<Section>();

            PointF generalTangetsRoot = new PointF();

            generalTangetsRoot.X = (float)(centre.X - radius / secondCircle.radius * secondCircle.centre.X) / (float)(1 - radius / secondCircle.radius);
            generalTangetsRoot.Y = (float)(centre.Y - radius / secondCircle.radius * secondCircle.centre.Y) / (float)(1 - radius / secondCircle.radius);

            Section AC = new Section(generalTangetsRoot, secondCircle.centre);

            PointF unitVectorAC = new PointF((AC.second.X - AC.first.X) / (float)AC.Len, (AC.second.Y - AC.first.Y) / (float)AC.Len);

            double AB = Math.Sqrt(AC.Len * AC.Len - secondCircle.radius * secondCircle.radius);
            // cos и sin угла поворота
            double cosACB = secondCircle.radius / AC.Len;
            double sinACB = AB / AC.Len;

            PointF vectorByAC = new PointF((float)(unitVectorAC.X * AB), (float)(unitVectorAC.Y * AB));

            PointF coordsALeft = new PointF((float)(vectorByAC.X * cosACB - vectorByAC.Y * sinACB), (float)(vectorByAC.X * sinACB + vectorByAC.Y * cosACB));
            PointF coordsARight = new PointF((float)(vectorByAC.X * cosACB + vectorByAC.Y * sinACB), (float)(- vectorByAC.X * sinACB + vectorByAC.Y * cosACB));

            vectorByAC.X *= (float)(radius / secondCircle.radius);
            vectorByAC.Y *= (float)(radius / secondCircle.radius);

            PointF coordsBLeft = new PointF((float)(vectorByAC.X * cosACB - vectorByAC.Y * sinACB), (float)(vectorByAC.X * sinACB + vectorByAC.Y * cosACB));
            PointF coordsBRight = new PointF((float)(vectorByAC.X * cosACB + vectorByAC.Y * sinACB), (float)(-vectorByAC.X * sinACB + vectorByAC.Y * cosACB));

            externalTangets.Add(new Section(coordsALeft, coordsBLeft));
            externalTangets.Add(new Section(coordsALeft, coordsBLeft));

            return externalTangets;
        }
    }
}
