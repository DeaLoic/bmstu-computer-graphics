using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_02
{
    class Model
    {
        public List<PointF> circle;
        public List<PointF> parabola;
        public List<Section> hatching;

        private PointF circleCentre;
        private float radius;

        private PointF parabolaVertex;

        private int hatchingStep = 20;

        public Model()
        {

        }

        public void GenerateModel(PointF circleCentre, int radius, PointF parabolaVertex)
        {
            GenerateCircle(circleCentre, radius);
            GenerateParabola(parabolaVertex);
            hatchingStep = radius / 6;
            GenerateHatching();
        }


        #region Scaling

        public void Scale(PointF scalingCenter, PointF scalingCoeffs)
        {
            ScaleCircle(scalingCenter, scalingCoeffs);
            ScaleParabola(scalingCenter, scalingCoeffs);
            ScaleHatching(scalingCenter, scalingCoeffs);
        }

        private void ScaleCircle(PointF scalingCenter, PointF scalingCoeffs)
        {
            List<PointF>  newCircle = circle.Select(x => ScalePoint(x, scalingCenter, scalingCoeffs)).ToList();
            circle.Clear();
            circle = newCircle;
        }

        private void ScaleParabola(PointF scalingCenter, PointF scalingCoeffs)
        {
            List<PointF> newParabola = parabola.Select(x => ScalePoint(x, scalingCenter, scalingCoeffs)).ToList();
            parabola.Clear();
            parabola = newParabola;
        }

        private void ScaleHatching(PointF scalingCenter, PointF scalingCoeffs)
        {
            hatching = hatching.Select(x => ScaleSection(x, scalingCenter, scalingCoeffs)).ToList();
        }

        private PointF ScalePoint(PointF targetPoint, PointF scalingCenter, PointF scalingCoeffs)
        {
            double x = scalingCoeffs.X * targetPoint.X + scalingCenter.X * (1 - scalingCoeffs.X);
            double y = scalingCoeffs.Y * targetPoint.Y + scalingCenter.Y * (1 - scalingCoeffs.Y);
            return new PointF((float)x, (float)y);
        }

        private Section ScaleSection(Section section, PointF scalingCenter, PointF scalingCoeffs)
        {
            return new Section(ScalePoint(section.first, scalingCenter, scalingCoeffs),
                               ScalePoint(section.second, scalingCenter, scalingCoeffs));
        }

        #endregion Scaling

        #region Moving
        public void Moving(Point delta)
        {
            MovingCircle(delta);
            MovingParabola(delta);
            MovingHatching(delta);
        }

        private PointF MovingPoint(PointF point, PointF delta)
        {
            return new PointF(point.X += delta.X, point.Y += delta.Y);
        }

        private Section MovingSection(Section section, PointF delta)
        {
            return new Section(new PointF(section.first.X + delta.X, section.first.Y + delta.Y),
                               new PointF(section.second.X + delta.X, section.second.Y + delta.Y));
        }
        private void MovingCircle(PointF delta)
        {
            circle = circle.Select(x => MovingPoint(x, delta)).ToList();
        }

        private void MovingParabola(PointF delta)
        {
            parabola = parabola.Select(x => MovingPoint(x, delta)).ToList();
        }

        private void MovingHatching(PointF delta)
        {
            hatching = hatching.Select(x => MovingSection(x, delta)).ToList();
        }

        #endregion Moving

        #region Rotation

        public void Rotate(PointF center, double angle)
        {
            RotateCircle(center, angle);
            RotateParabola(center, angle);
            RotateHatching(center, angle);
        }

        private PointF RotatePoint(PointF point, PointF center, double angle)
        {
            float x = (float)(center.X + (point.X - center.X) * Math.Cos(angle) + (point.Y - center.Y) * Math.Sin(angle));
            float y = (float)(center.Y - (point.X - center.X) * Math.Sin(angle) + (point.Y - center.Y) * Math.Cos(angle));
            return new PointF(x, y);
        }

        private Section RotateSection(Section section, PointF center, double angle)
        {
            return new Section(RotatePoint(section.first, center, angle), RotatePoint(section.second, center, angle));
        }

        private void RotateCircle(PointF center, double angle)
        {
            circle = circle.Select(x => RotatePoint(x, center, angle)).ToList();
        }

        private void RotateParabola(PointF center, double angle)
        {
            parabola = parabola.Select(x => RotatePoint(x, center, angle)).ToList();
        }

        private void RotateHatching(PointF center, double angle)
        {
            hatching = hatching.Select(x => RotateSection(x, center, angle)).ToList();
        }

        #endregion Rotation

        private void GenerateCircle(PointF center, int radius)
        {
            circleCentre = center;
            this.radius = radius;

            double angle = 0;
            double delta = (1.0 / (2 * radius));

            circle = new List<PointF>();

            while (angle <= Math.PI * 2)
            {
                double x = center.X + (radius * Math.Cos(angle));
                double y = center.Y - (radius * Math.Sin(angle));
                circle.Add(new PointF((float)x, (float)y));
                angle += delta;
            }
        }

        private void GenerateParabola(PointF vertex)
        {
            parabolaVertex = vertex;
            parabola = new List<PointF>();

            double y;
            double root;
            int rightBorder = (int)(circleCentre.X + radius + 10);

            if (vertex.X + radius + 10 > rightBorder)
            {
                rightBorder = (int)(vertex.X + radius + 10);
            }

            for (float x = vertex.X; x < rightBorder; x += 0.5f)
            {
                root = Math.Sqrt(x - vertex.X);

                y = (root + vertex.Y);
                parabola.Add(new PointF(x, (float)y));

                y = (-root + vertex.Y);
                parabola.Add(new PointF(x, (float)y));
            }
        }

        private void GenerateHatching()
        {
            hatching = new List<Section>();
            Section currentHatchingLine;
            Straight straight = new Straight(parabolaVertex, new PointF(parabolaVertex.X - 1, parabolaVertex.Y + 1));

            for (int x = (int)parabolaVertex.X + 1; x < circleCentre.X + radius * 2; x += hatchingStep)
            {
                straight.C -= hatchingStep;
                currentHatchingLine = GetHatchingStep(straight);
                if (!(currentHatchingLine is null) || currentHatchingLine.IsCorrect)
                {
                    hatching.Add(currentHatchingLine);
                }
            }
        }

        private Section GetHatchingStep(Straight straight)
        {
            Section section = new Section();
            List<PointF> intersectionCircle = FindCircleIntersection(straight);
            if (intersectionCircle.Count == 2)
            {
                List<PointF> intersectionParabola = FindParabolaIntersection(straight);
                if (intersectionParabola.Count == 2)
                {
                    Section toFirst = new Section(circleCentre, intersectionParabola[0]);
                    Section toSecond = new Section(circleCentre, intersectionParabola[1]);

                    if (toFirst.Len < radius || toSecond.Len < radius)
                    {
                        if (toFirst.Len < radius && toSecond.Len < radius)
                        {
                            section = new Section(intersectionParabola[0], intersectionParabola[1]);
                        }
                        else if (toFirst.Len < radius)
                        {
                            if (intersectionParabola[0].Y > intersectionParabola[1].Y)
                            {
                                section = new Section(intersectionParabola[0],
                                                      intersectionCircle[0].Y < intersectionCircle[1].Y ? intersectionCircle[0] : intersectionCircle[1]);
                            }
                            else
                            {
                                section = new Section(intersectionParabola[0],
                                                      intersectionCircle[0].Y > intersectionCircle[1].Y ? intersectionCircle[0] : intersectionCircle[1]);
                            }
                        }
                        else if (toSecond.Len < radius)
                        {
                            if (intersectionParabola[0].Y < intersectionParabola[1].Y)
                            {
                                section = new Section(intersectionParabola[1],
                                                      intersectionCircle[0].Y < intersectionCircle[1].Y ? intersectionCircle[0] : intersectionCircle[1]);
                            }
                            else
                            {
                                section = new Section(intersectionParabola[1],
                                                      intersectionCircle[0].Y > intersectionCircle[1].Y ? intersectionCircle[0] : intersectionCircle[1]);
                            }
                        }
                    }
                    else
                    {
                        if (intersectionCircle[0].Y < intersectionParabola[0].Y && intersectionCircle[0].Y < intersectionParabola[1].Y &&
                            intersectionCircle[1].Y < intersectionParabola[0].Y && intersectionCircle[1].Y < intersectionParabola[1].Y
                            ||
                            intersectionCircle[0].Y > intersectionParabola[0].Y && intersectionCircle[0].Y > intersectionParabola[1].Y &&
                            intersectionCircle[1].Y > intersectionParabola[0].Y && intersectionCircle[1].Y > intersectionParabola[1].Y)
                        {
                            //Some error
                        }
                        else
                        {
                            section = new Section(intersectionCircle[0], intersectionCircle[1]); 
                        }
                    }
                }
            }



            return section;
        }

        private List<PointF> FindParabolaIntersection(Straight straight)
        {
            List<PointF> points = new List<PointF>();

            float A = (float)straight.C;
            float C = parabolaVertex.X;
            float D = parabolaVertex.Y;

            float mainSqrt = -4 * A - 4 * C - 4 * D + 1;
            if (mainSqrt >= 0)
            {
                float x1 = (float)(1.0 / 2.0 * (-Math.Sqrt(mainSqrt) - 2 * A - 2 * D + 1));
                float x2 = (float)(1.0 / 2.0 * (Math.Sqrt(mainSqrt) - 2 * A - 2 * D + 1));

                float y1 = (float)(1.0 / 2.0 * (Math.Sqrt(mainSqrt) + 2 * D - 1));
                float y2 = (float)(1.0 / 2.0 * (-Math.Sqrt(mainSqrt) + 2 * D - 1));

                points.Add(new PointF(x1, y1));
                if (x1 != x2 && y1 != y2)
                {
                    points.Add(new PointF(x2, y2));
                }
            }
            
            /*
            double discriminant = Math.Pow(2 * parabolaVertex.Y + 1, 2) - 4 * (straight.C + parabolaVertex.X + Math.Pow(parabolaVertex.Y, 2));

            if (discriminant > 0)
            {
                int y1 = (int) ((2 * parabolaVertex.Y + 1) + Math.Sqrt(discriminant)) / 2;
                int y2 = (int) ((2 * parabolaVertex.Y + 1) - Math.Sqrt(discriminant)) / 2;

                int x1 = y1 - (int)straight.C;
                int x2 = y2 - (int)straight.C;

                if (discriminant > 0)
                {
                    points.Add(new Point(x1, y1));
                }
                points.Add(new Point(x2, y2));
            }
            */

            return points;
        }

        private List<PointF> FindCircleIntersection(Straight straight)
        {
            List<PointF> points = new List<PointF>();

            float A = circleCentre.X;
            float B = circleCentre.Y;
            float C = (float)straight.C;

            float mainSqrt = (float)(-Math.Pow(A, 2) - 2 * A * B - 2 * A * C - Math.Pow(B, 2) - 2 * B * C - Math.Pow(C, 2) + 2 * Math.Pow(radius, 2));
            if (mainSqrt >= 0)
            {
                float x1 = (float)(1.0 / 2.0 * (-Math.Sqrt(mainSqrt) + A - B - C));
                float x2 = (float)(1.0 / 2.0 * (Math.Sqrt(mainSqrt) + A - B - C));

                float y1 = (-C - x1);
                float y2 = (-C - x2);

                points.Add(new PointF(x1, y1));
                if (x1 != x2 && y1 != y2)
                {
                    points.Add(new PointF(x2, y2));
                }
            }
            /*
            double discriminant = Math.Pow(- 2 * (- straight.C - circleCentre.X + circleCentre.Y), 2) - 
                                  4 * 2 * (Math.Pow(circleCentre.Y, 2) - Math.Pow(radius, 2));

            if (discriminant > 0)
            {
                int y1 = (int)((2 * (- straight.C - circleCentre.X + circleCentre.Y) + Math.Sqrt(discriminant)) / 4);
                int y2 = (int)((2 * (- straight.C - circleCentre.X + circleCentre.Y) - Math.Sqrt(discriminant)) / 4);

                int x1 = - y1 - (int)straight.C;
                int x2 = - y2 - (int)straight.C;

                if (discriminant > 0)
                {
                    points.Add(new Point(x1, y1));
                }
                points.Add(new Point(x2, y2));
            }
            */
            return points;
        }
    }
}