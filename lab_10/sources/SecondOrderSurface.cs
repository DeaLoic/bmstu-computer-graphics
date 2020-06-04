using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_10
{
    public struct DotsDistance
    {
        public double min;
        public double max;
        public double step;
        public int dotsCount;

        public DotsDistance(double min, double max, double step)
        {
            this.min = min;
            this.max = max;
            this.step = step;
            dotsCount = (int)Math.Ceiling((max - min) / step);
        }
    }

    class SecondOrderSurface
    {
        Size screenSize;
        List<int> bottom;
        List<int> top;

        private Func<double, double, double> function2d;  // y = f(x, z)
        DotsDistance borderX;
        DotsDistance borderY;
        double coef;

        public SecondOrderSurface(Func<double, double, double> function)
        {
            function2d = function;
        }

        private void PrepareArraysFill()
        {
            bottom = new List<int>();
            top = new List<int>();

            for (int i = 0; i < screenSize.Width; i++)
            {
                bottom.Add(screenSize.Height);
                top.Add(0);
            }
        }

        Point GetIntersection(Point first, Point second, List<int> horizont)
        {
            Point result = first;
            int deltaX = second.X - first.X;
            int deltaCurY = second.Y - first.Y;
            int deltaPrevY = horizont[second.X] - horizont[first.X];

            double m = deltaCurY / (double)(deltaX);
            if (deltaX == 0)
            {
                result.X = second.X;
                result.Y = horizont[second.X];
            }
            else if (first.Y == horizont[first.X] && second.Y == horizont[second.X])
            {
                result.X = first.X;
                result.Y = first.Y;
            }
            else
            {
                result.X = first.X - (int)(Math.Round(deltaX * (first.Y - horizont[first.X]) / (double)(deltaCurY - deltaPrevY)));
                result.Y = (int)(Math.Round((result.X - first.X) * m + first.Y));
            }

            return result;
        }


        void Horizon(Point first, Point second, Graphics painter, Pen pen)
        {
            if (second.X < 0 || second.X > screenSize.Width - 1)
                return;
            if (first.X < 0 || first.X > screenSize.Width - 1)
                return;

            if (second.X < first.X)
            {
                Swap(ref first, ref second);
            }
            if (second.X - first.X == 0)
            {
                top[second.X] = Math.Max(top[second.X], second.Y);
                bottom[second.X] = Math.Min(bottom[second.X], second.Y);
                if (second.X >= 0 && second.X <= screenSize.Width)
                {
                    first.X = (int)Math.Round((first.X) * coef  + screenSize.Width / 2 - ((first.X) * coef / 2));
                    second.X = (int)Math.Round((second.X) * coef + screenSize.Width / 2 - ((second.X) * coef / 2));
                    first.Y = (int)Math.Round((first.Y) * coef + screenSize.Height / 2 - ((first.Y) * coef / 2));
                    second.Y = (int)Math.Round((second.Y) * coef + screenSize.Height / 2 - ((second.Y) * coef / 2));
                    painter.DrawLine(pen, first, second);
                }
            }
            else
            {
                int x_prev = first.X;
                int y_prev = first.Y;
                double m = (second.Y - first.Y) / (double)(second.X - first.X);
                for (int x = first.X; x <= second.X; x++)
                {
                    int y = (int)(Math.Round(m * (x - first.X) + first.Y));
                    top[x] = Math.Max(top[x], y);
                    bottom[x] = Math.Min(bottom[x], y);
                    if (x >= 0 && x <= screenSize.Width)
                    {
                        x_prev = (int)Math.Round(( x_prev) * coef + screenSize.Width / 2 - ((x_prev) * coef / 2));
                        x = (int)Math.Round(( x) * coef + screenSize.Width / 2 - ((x) * coef / 2));
                        y_prev = (int)Math.Round(y_prev * coef + screenSize.Height / 2 - ((y_prev) * coef / 2));
                        y = (int)Math.Round(( y) * coef + screenSize.Height / 2 - ((y) * coef / 2));

                        painter.DrawLine(pen, x_prev, y_prev, x, y);
                    }
                }
            }
        }

        // Обработка ребер
        void ProcessEdge(Point current, ref Point past, Graphics painter, Pen pen)
        {
            if (past.X != -1)
            {
                Horizon(past, current, painter, pen);
            }
            past = current;
        }

        // Проверяет видимость текущей точки
        int Visible(Point dot)
        {
            int Visible = -1;

            if (dot.Y < screenSize.Height && dot.X < screenSize.Width && dot.X > 0 && dot.Y > 0)
            {
                if (dot.Y < top[dot.X] && dot.Y > bottom[dot.X])
                {
                    Visible = 0;
                }
                if (dot.Y >= top[dot.X])
                {
                    Visible = 1;
                }
            }

            return Visible;
        }

        // Преобразование координат
        void rotate_x(ref double x, ref double y, ref double z, double ox)
        {
            ox = ox * Math.PI / 180;
            double buf = y;
            y = Math.Cos(ox) * y - Math.Sin(ox) * z;
            z = Math.Cos(ox) * z + Math.Sin(ox) * buf;
        }
        void rotate_y(ref double x, ref double y, ref double z, double oy)
        {
            oy = oy * Math.PI / 180;
            double buf = x;
            x = Math.Cos(oy) * x - Math.Sin(oy) * z;
            z = Math.Cos(oy) * z + Math.Sin(oy) * buf;
        }
        void rotate_z(ref double x, ref double y, ref double z, double oz)
        {
            oz = oz * Math.PI / 180;
            double buf = x;
            x = Math.Cos(oz) * x - Math.Sin(oz) * y;
            y = Math.Cos(oz) * y + Math.Sin(oz) * buf;
        }
        Point Transform(double x, double y, double z, double ox, double oy, double oz)
        {
            double x_center = screenSize.Width / 2;
            double y_center = screenSize.Height / 2;
            rotate_x(ref x, ref y, ref z, ox);
            rotate_y(ref x, ref y, ref z, oy);
            rotate_z(ref x, ref y, ref z, oz);
            this.coef = 35;// Math.Min(Math.Abs(screenSize.Width / (borderX.max - borderX.min)), Math.Abs(screenSize.Height / (borderY.max - borderY.min + 1)));

            if (y < borderY.min)
            {
                borderY.min = y;
            }
            if (y > borderY.max)
            {
                borderY.max = y;
            }

            Point result = new Point();
            result.X = (int)(Math.Round(x));
            result.Y = (int)(Math.Round(y));

            return result;
        }

        public void HorizontDraw(DotsDistance borderX, DotsDistance borderZ, double ox, double oy, double oz, Size size, Graphics painter, Pen pen)
        {
            // для масштабирования.
            screenSize = size;
            this.borderX = borderX;
            this.borderY.max = 0;
            this.borderY.min = size.Height;

            PrepareArraysFill();

            Point left = new Point(-1, -1);
            Point right = new Point(-1, -1);
            Point previos = new Point(0, 0);

            for (double z = borderZ.max; z >= borderZ.min; z -= borderZ.step)
            {
                double yTemp = function2d(borderX.min, z);
                previos = Transform(borderX.min, yTemp, z, ox, oy, oz);  // для обработки поворотов
                ProcessEdge(previos, ref left, painter, pen);           // обработка левой границы
                int Pflag = Visible(previos);

                for (double x = borderX.min; x <= borderX.max; x += borderX.step)
                {
                    Point current = new Point(0, 0);
                    Point intersection = new Point(0, 0);

                    yTemp = function2d(x, z);
                    current = Transform(x, yTemp, z, ox, oy, oz);     // для обработки поворотов
                    int Tflag = Visible(current);

                    if (Tflag == Pflag) // если видимость не изменилась
                    {
                        if (Pflag != 0) // и точка видима
                        {
                            Horizon(previos, current, painter, pen);  // отрисовать участок и обновить массивы горизонтов
                        }
                    }
                    else if (Tflag == 0) // если точка стала невидима
                    {
                        if (Pflag == 1)  // а была выше top
                        {
                            intersection = GetIntersection(previos, current, top);
                        }
                        else            // была ниже bottom
                        {
                            intersection = GetIntersection(previos, current, bottom);
                        }

                        // отрисовать
                        Horizon(previos, intersection, painter, pen);
                    }
                    else if (Tflag == 1) // если точка стала видима и выше top
                    {
                        if (Pflag == 0) // а была невидима
                        {
                            intersection = GetIntersection(previos, current, top);
                            Horizon(previos, intersection, painter, pen);
                        }
                        else           // была ниже bottom (два пересечения)
                        {
                            intersection = GetIntersection(previos, current, top);
                            Horizon(previos, intersection, painter, pen);
                            intersection = GetIntersection(previos, current, bottom);
                            Horizon(intersection, current, painter, pen);
                        }
                    }
                    else   // аналогично предыдущему
                    {
                        if (Pflag == 0)
                        {
                            intersection = GetIntersection(previos, current, bottom);
                            Horizon(previos, intersection, painter, pen);
                        }
                        else
                        {
                            intersection = GetIntersection(previos, current, top);
                            Horizon(previos, intersection, painter, pen);
                            intersection = GetIntersection(previos, current, bottom);
                            Horizon(intersection, current, painter, pen);
                        }
                    }
                    Pflag = Tflag; // видимость предыдущей точки
                    previos = current;
                }
                ProcessEdge(previos, ref right, painter, pen); // обработать правое ребро

            }
        }


        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
