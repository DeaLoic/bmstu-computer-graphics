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
        public List<Point> circle;
        public List<Point> parabola;
        public List<Section> hatching;

        private Point circleCentre;
        private int radius;

        private Point parabolaVertex;

        private int hatchingStep = 20;

        public Model()
        {

        }

        public void GenerateModel(Point circleCentre, int radius, Point parabolaVertex)
        {
            GenerateCircle(circleCentre, radius);
            GenerateParabola(parabolaVertex);
            GenerateHatching();
        }

        public void Scale(Point scalingCenter, PointF scailingCoeffs)
        {

        }

        public void Moving(Point delta)
        {
            MovingCircle(delta);
            MovingParabola(delta);
            MovingHatching(delta);
        }

        private Point MovingPoint(Point point, Point delta)
        {
            return new Point(point.X += delta.X, point.Y += delta.Y);
        }

        private Section MovingSection(Section section, Point delta)
        {
            return new Section(new Point((int)section.first.X + delta.X, (int)section.first.Y + delta.Y),
                               new Point((int)section.second.X + delta.X, (int)section.second.Y + delta.Y));
        }
        private void MovingCircle(Point delta)
        {
            circle = circle.Select(x => MovingPoint(x, delta)).ToList();
        }

        private void MovingParabola(Point delta)
        {
            parabola = parabola.Select(x => MovingPoint(x, delta)).ToList();
        }

        private void MovingHatching(Point delta)
        {
            hatching = hatching.Select(x => MovingSection(x, delta)).ToList();
        }

        private void GenerateCircle(Point center, int radius)
        {
            circleCentre = center;
            this.radius = radius;

            double angle = 0;
            double delta = (1.0 / radius);

            circle = new List<Point>();

            while (angle <= Math.PI * 2)
            {
                int x = center.X + (int)(radius * Math.Cos(angle));
                int y = center.Y - (int)(radius * Math.Sin(angle));
                circle.Add(new Point(x, y));
                angle += delta;
            }
        }

        private void GenerateParabola(Point vertex)
        {
            parabolaVertex = vertex;
            parabola = new List<Point>();

            int y;
            double root;
            int rightBorder = circleCentre.X + radius + 10;

            if (vertex.X + radius + 10 > rightBorder)
            {
                rightBorder = vertex.X + radius + 10;
            }

            for (int x = vertex.X; x < circleCentre.X + radius + 10; x++)
            {
                root = Math.Sqrt(x - vertex.X);

                y = (int)(root + vertex.Y);
                parabola.Add(new Point(x, y));

                y = (int)(-root + vertex.Y);
                parabola.Add(new Point(x, y));
            }
        }

        private void GenerateHatching()
        {
            hatching = new List<Section>();
            Section currentHatchingLine;
            Straight straight = new Straight(parabolaVertex, new PointF(parabolaVertex.X - 1, parabolaVertex.Y + 1));

            for (int x = parabolaVertex.X + 1; x < circleCentre.X + radius - 2; x += hatchingStep)
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
            List<Point> intersectionCircle = FindCircleIntersection(straight);
            if (intersectionCircle.Count == 2)
            {
                List<Point> intersectionParabola = FindParabolaIntersection(straight);
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

        private List<Point> FindParabolaIntersection(Straight straight)
        {
            List<Point> points = new List<Point>();

            int A = (int)straight.C;
            int C = parabolaVertex.X;
            int D = parabolaVertex.Y;

            int mainSqrt = -4 * A - 4 * C - 4 * D + 1;
            if (mainSqrt >= 0)
            {
                int x1 = (int)(1.0 / 2.0 * (-Math.Sqrt(mainSqrt) - 2 * A - 2 * D + 1));
                int x2 = (int)(1.0 / 2.0 * (Math.Sqrt(mainSqrt) - 2 * A - 2 * D + 1));

                int y1 = (int)(1.0 / 2.0 * (Math.Sqrt(mainSqrt) + 2 * D - 1));
                int y2 = (int)(1.0 / 2.0 * (-Math.Sqrt(mainSqrt) + 2 * D - 1));

                points.Add(new Point(x1, y1));
                if (x1 != x2 && y1 != y2)
                {
                    points.Add(new Point(x2, y2));
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

        private List<Point> FindCircleIntersection(Straight straight)
        {
            List<Point> points = new List<Point>();

            int A = circleCentre.X;
            int B = circleCentre.Y;
            int C = (int)straight.C;

            int mainSqrt = (int)-Math.Pow(A, 2) - 2 * A * B - 2 * A * C - (int)Math.Pow(B, 2) - 2 * B * C - (int)Math.Pow(C, 2) + 2 * (int)Math.Pow(radius, 2);
            if (mainSqrt >= 0)
            {
                int x1 = (int)(1.0 / 2.0 * (-Math.Sqrt(mainSqrt) + A - B - C));
                int x2 = (int)(1.0 / 2.0 * (Math.Sqrt(mainSqrt) + A - B - C));

                int y1 = (int)(-C - x1);
                int y2 = (int)(-C - x2);

                points.Add(new Point(x1, y1));
                if (x1 != x2 && y1 != y2)
                {
                    points.Add(new Point(x2, y2));
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

