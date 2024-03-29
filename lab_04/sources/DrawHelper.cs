﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_04
{
    public enum CompareType
    {
        StartEndCount,
        StartEndStep,
        StartCountStep,
        EndCountStep
    };

    public static class DrawHelper
    {
        public delegate void DrawCircleMethod(Bitmap workBitmap, Color workColor, Point center, int radius);

        public delegate void DrawEllipseMethod(Bitmap workBitmap, Color workColor, Point center, int xRadius, int yRadius);

        private static void DrawSymmetric(Bitmap workBitmap, Color workColor, Point center, int x, int y)
        {
            if (center.X + x > 0 && center.X + x < workBitmap.Width)
            {
                if (center.Y + y > 0 && center.Y + y < workBitmap.Height)
                {
                    workBitmap.SetPixel(center.X + x, center.Y + y, workColor);
                }
                if (center.Y - y > 0 && center.Y - y < workBitmap.Height)
                {
                    workBitmap.SetPixel(center.X + x, center.Y - y, workColor);
                }
            }

            if (center.X - x > 0 && center.X - x < workBitmap.Width)
            {
                if (center.Y + y > 0 && center.Y + y < workBitmap.Height)
                {
                    workBitmap.SetPixel(center.X - x, center.Y + y, workColor);
                }
                if (center.Y - y > 0 && center.Y - y < workBitmap.Height)
                {
                    workBitmap.SetPixel(center.X - x, center.Y - y, workColor);
                }
            }
        }

        #region Circle
        public static void DrawCircle(Bitmap workBitmap, DrawCircleMethod method, Color workColor, Point center, int radius)
        {
            method(workBitmap, workColor, center, radius);
            
        }

        public static void DrawCircleCompare(Bitmap workBitmap, DrawCircleMethod method, Color workColor, Point center, CompareType type, int startRadius, int endRadius, int circleCount, int step)
        {
            switch (type)
            {
                case CompareType.StartEndCount:
                    double stepTemp = (endRadius - startRadius) / (double)circleCount;
                    for (double i = 0; i < circleCount; i++)
                    {
                        method(workBitmap, workColor, center, (int)Math.Round(startRadius + i * stepTemp));
                    }
                    break;
                case CompareType.StartEndStep:
                    for (double i = startRadius; i <= endRadius; i += step)
                    {
                        method(workBitmap, workColor, center, (int)Math.Round(i));
                    }
                    break;
                case CompareType.StartCountStep:
                    for (int i = 0; i < circleCount; i++)
                    {
                        method(workBitmap, workColor, center, startRadius);
                        startRadius += step;
                    }
                    break;
                case CompareType.EndCountStep:
                    for (int i = 0; i < circleCount; i++)
                    {
                        method(workBitmap, workColor, center, endRadius);
                        endRadius -= step;
                    }
                    break;
            }
        }

        public static void DrawCircleCanonical(Bitmap workBitmap, Color workColor, Point center, int radius)
        {
            int x = 0;
            int y = 1;

            int radiusSqr = radius * radius;

            for (x = 0; x < y; x++)
            {
                y = Convert.ToInt32(Math.Sqrt(radiusSqr - x * x));

                DrawSymmetric(workBitmap, workColor, center, x, y);
                DrawSymmetric(workBitmap, workColor, center, y, x);
            }
        }

        public static void DrawCircleStandart(Bitmap workBitmap, Color workColor, Point center, int radius)
        {
            Graphics graph = Graphics.FromImage(workBitmap);
            graph.DrawEllipse(new Pen(workColor), center.X - radius, center.Y - radius, radius * 2, radius * 2);
            graph.Dispose();
        }

        public static void DrawCircleBresenham(Bitmap workBitmap, Color workColor, Point center, int radius)
        {
            int x = 0;
            int y = radius;

            // error = (x + 1)^2 + (y -1)^2 - R^2 =
            int error = 2 * (1 - radius); // ошибка

            while (x <= y)
            {
                DrawSymmetric(workBitmap, workColor, center, x, y);
                DrawSymmetric(workBitmap, workColor, center, y, x);

                if (error == 0)
                {
                    DiagonalStep(ref x, ref y, ref error);
                }
                else if (error < 0)
                {
                    if (2 * error + 2 * y - 1 > 0)
                        DiagonalStep(ref x, ref y, ref error);
                    else
                        HorizontalStep(ref x, ref error);
                }
                else
                {
                    if (2 * error - 2 * x - 1 < 0)
                        DiagonalStep(ref x, ref y, ref error);
                    else
                        VerticalStep(ref y, ref error);
                }
            }
        }

        private static void DiagonalStep(ref int x, ref int y, ref int error)
        {
            x++;
            y--;
            error += 2 * (x - y + 1);
        }
        private static void HorizontalStep(ref int x, ref int error)
        {
            x++;
            error += 2 * x + 1;
        }
        private static void VerticalStep(ref int y, ref int error)
        {
            y--;
            error += -2 * y + 1;
        }

        public static void DrawCircleParam(Bitmap workBitmap, Color workColor, Point center, int radius)
        {
            double angle = 0;
            double delta = 1.0 / radius;

            while (angle <= Math.PI / 4 + delta)
            {
                double x = (radius * Math.Cos(angle));
                double y = (radius * Math.Sin(angle));

                DrawSymmetric(workBitmap, workColor, center, (int)Math.Round(x), (int)Math.Round(y));
                DrawSymmetric(workBitmap, workColor, center, (int)Math.Round(y), (int)Math.Round(x));

                angle += delta;
            }
        }

        public static void DrawCircleMiddle(Bitmap workBitmap, Color workColor, Point center, int radius)
        {
            int x = 0;
            int y = radius;
            
            int p = 1 - radius;

            DrawSymmetric(workBitmap, workColor, center, x, y);
            DrawSymmetric(workBitmap, workColor, center, y, x);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }

                DrawSymmetric(workBitmap, workColor, center, x, y);
                DrawSymmetric(workBitmap, workColor, center, y, x);
            }
        }

        #endregion Circle

        #region Ellipse

        public static void DrawEllipse(Bitmap workBitmap, DrawEllipseMethod method, Color workColor, Point center, int radiusX, int radiusY)
        {
            method(workBitmap, workColor, center, radiusX, radiusY);
        }

        public static void DrawEllipseCompare(Bitmap workBitmap, DrawEllipseMethod method, Color workColor, Point center, int startX, int startY, int ellipseCount, int stepX, int stepY)
        {
            for (double i = 0; i < ellipseCount; i++)
            {
                DrawEllipse(workBitmap, method, workColor, center, startX, startY);
                startX += stepX;
                startY += stepY;
            }
        }

        public static void DrawEllipseCanonical(Bitmap workBitmap, Color workColor, Point center, int radiusX, int radiusY)
        {
            int aSqr = radiusX * radiusX;
            int bSqr = radiusY * radiusY;

            // Условие y' = -1 - оптимальное.
            int oprimalX = (int)Math.Round(aSqr / Math.Sqrt(aSqr + bSqr));

            int x = 0;
            int y = 0;

            double m = (double)radiusY / radiusX; // b/a
            for (x = 0; x <= oprimalX; x++)
            {
                y = (int)Math.Round(Math.Sqrt(aSqr - x * x) * m);  // y = b/a * sqrt(a^2 - x^2)
                DrawSymmetric(workBitmap, workColor, center, x, y);
            }

            // то же, но для Y
            int optimalY = (int)Math.Round(bSqr / Math.Sqrt(aSqr + bSqr));
            m = 1 / m;

            for (y = 0; y <= optimalY; y++)
            {
                x = (int)Math.Round(Math.Sqrt(bSqr - y * y) * m);
                DrawSymmetric(workBitmap, workColor, center, x, y);
            }
        }

        public static void DrawEllipseStandart(Bitmap workBitmap, Color workColor, Point center, int radiusX, int radiusY)
        {
            Graphics graph = Graphics.FromImage(workBitmap);
            graph.DrawEllipse(new Pen(workColor), center.X - radiusX, center.Y - radiusY, radiusX * 2, radiusY * 2);
            graph.Dispose();
        }

        public static void DrawEllipseBresenham(Bitmap workBitmap, Color workColor, Point center, int radiusX, int radiusY)
        {
            int x = 0;
            int y = radiusY;
            long aSqr = radiusX * radiusX;
            long bSqr = y * y;

            long aSqrTwice = aSqr * 2;
            long bSqrTwice = bSqr * 2;

            //error = b^2 * (x+1)^2 + a^2 * (y-1)^2-a^2 * b^2=
            long error = bSqr - aSqrTwice * radiusY + aSqr;

            long dx = 0;
            long dy = aSqrTwice * y;

            DrawSymmetric(workBitmap, workColor, center, x, y);

            while (y > 0)
            {
                if (error < 0)
                {
                    if (2 * error + dy - aSqr > 0)
                    {
                        DiagonalStep(ref x, ref y, ref error, ref aSqr, ref aSqrTwice, ref bSqr, ref bSqrTwice, ref dx, ref dy);
                    }
                    else
                    {
                        HorizontalStep(ref x, ref y, ref error, ref bSqr, ref bSqrTwice, ref dx);
                    }
                }
                else if (error > 0)
                {
                    if (2 * error - dx - bSqr > 0)
                    {
                        VerticalStep(ref x, ref y, ref error, ref aSqr, ref aSqrTwice, ref dy);
                    }
                    else
                    {
                        DiagonalStep(ref x, ref y, ref error, ref aSqr, ref aSqrTwice, ref bSqr, ref bSqrTwice, ref dx, ref dy);
                    }
                }
                else
                {
                    DiagonalStep(ref x, ref y, ref error, ref aSqr, ref aSqrTwice, ref bSqr, ref bSqrTwice, ref dx, ref dy);
                }

                DrawSymmetric(workBitmap, workColor, center, x, y);
            }
        }

        private static void DiagonalStep(ref int x, ref int y, ref long error, ref long aSqr, ref long aSqrTwice, ref long bSqr, ref long bSqrTwice, ref long dx, ref long dy)
        {
            x++;
            y--;
            dx += bSqrTwice;
            dy -= aSqrTwice;
            error += dx - dy + aSqr + bSqr;
        }

        private static void HorizontalStep(ref int x, ref int y, ref long error, ref long bSqr, ref long bSqrTwice, ref long dx)
        {
            x++;
            dx += bSqrTwice;
            error += dx + bSqr;
        }

        private static void VerticalStep(ref int x, ref int y, ref long error, ref long aSqr, ref long aSqrTwice, ref long dy)
        {
            y--;
            dy -= aSqrTwice;
            error += -dy + aSqr;
        }

        public static void DrawEllipseParam(Bitmap workBitmap, Color workColor, Point center, int radiusX, int radiusY)
        {
            double angle = Math.PI / 2;

            int x = 0, y = radiusY;

            double step = 1 / (double)radiusX;
            while (angle > Math.PI / 4)
            {
                x = Convert.ToInt32(radiusX * Math.Cos(angle));
                y = Convert.ToInt32(radiusY * Math.Sin(angle));

                DrawSymmetric(workBitmap, workColor, center, x, y);

                angle -= step;
            }


            step = 1 / (double)radiusY;
            while (angle > -step)
            {
                x = Convert.ToInt32(radiusX * Math.Cos(angle));
                y = Convert.ToInt32(radiusY * Math.Sin(angle));

                DrawSymmetric(workBitmap, workColor, center, x, y);

                angle -= step;
            }
        }

        public static void DrawEllipseMiddle(Bitmap workBitmap, Color workColor, Point center, int radiusX, int radiusY)
        {
            int x = 0;
            int y = radiusY;
            long aSqr = radiusX * radiusX;
            long bSqr = y * y;

            long aSqrTwice = aSqr * 2;
            long bSqrTwice = bSqr * 2;

            // Начальная ошибка
            long p = (long)Math.Round(bSqr - aSqr * radiusY + (aSqr * 0.25));

            DrawSymmetric(workBitmap, workColor, center, x, y);

            // t = (a^2 * y) / (b^2 * x)
            // a^2 * (y-1/2) ≤ b^2 * (x+1) (координаты дополнительной точки (x+1, y-1/2)
            // a2(2y-1) ≤ 2b2(x+1) - в целых
            long dx = bSqrTwice * x;
            long dy = aSqrTwice * y;
            while (dx < dy)
            {
                x++;
                dx += bSqrTwice;
                if (p < 0)
                {
                    p += dx + bSqr;
                }
                else
                {
                    y--;
                    dy -= aSqrTwice;
                    p += dx - dy + bSqr;
                }

                DrawSymmetric(workBitmap, workColor, center, x, y);
            }

            p += (long)Math.Round((aSqr - bSqr) * 0.75) - (dx + dy) / 2;

            while (y > 0)
            {
                y--;
                dy -= aSqrTwice;
                if (p > 0)
                {
                    p += -dy + aSqr;
                }
                else
                {
                    x++;
                    dx += bSqrTwice;
                    p += dx - dy + aSqr;
                }
                DrawSymmetric(workBitmap, workColor, center, x, y);
            }
            /**/
        }

        #endregion Ellipse
    }
}
