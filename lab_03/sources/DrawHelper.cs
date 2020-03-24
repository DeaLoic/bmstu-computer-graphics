using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab_03
{
    public static class DrawHelper
    {
        public delegate void DrawLineMethod(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor);

        public static void DrawLineDDA(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {
            float deltaX = secondPoint.X - firstPoint.X;
            float deltaY = secondPoint.Y - firstPoint.Y;
            int dX = (int)Math.Abs(deltaX);
            int dY = (int)Math.Abs(deltaY);

            int lenght = dX;
            if (dX < dY)
            {
                lenght = dY;
            }

            deltaX = (deltaX / lenght);
            deltaY = (deltaY / lenght);

            float X = firstPoint.X;
            float Y = firstPoint.Y;
            
            for (int i = 0; i < lenght + 1; i++)
            {
                workBitmap.SetPixel((int)X, (int)Y, workColor);
                X += deltaX;
                Y += deltaY;
            }
        }

        public static void DrawLineBresenham(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {
            int X = firstPoint.X;
            int Y = firstPoint.Y;

            int dX = secondPoint.X - firstPoint.X;
            int dY = secondPoint.Y - firstPoint.Y;

            int deltaX = Math.Sign(dX);
            int deltaY = Math.Sign(dY);

            dX = Math.Abs(dX);
            dY = Math.Abs(dY);

            bool isDxGreater = true;
            if (dX < dY)
            {
                isDxGreater = false;
                int temp = dX;
                dX = dY;
                dY = temp;
            }

            float tg = 0;
            if (dX != 0)
            {
                tg = (float)dY / dX;
            }

            float error = tg - (1.0f / 2);

            for (int i = 0; i < dX + 1; i++)
            {
                workBitmap.SetPixel((int)X, (int)Y, workColor);
                if (error >= 0)
                {
                    if (isDxGreater)
                    {
                        Y += deltaY;
                    }
                    else
                    {
                        X += deltaX;
                    }
                    error -= 1;
                }

                if (error < 0)
                {
                    if (isDxGreater)
                    {
                        X += deltaX;
                    }
                    else
                    {
                        Y += deltaY;
                    }
                    error += tg;
                }
            }
        }

        public static void DrawLineBresenhamInt(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {
            int X = firstPoint.X;
            int Y = firstPoint.Y;

            int dX = secondPoint.X - firstPoint.X;
            int dY = secondPoint.Y - firstPoint.Y;

            int deltaX = Math.Sign(dX);
            int deltaY = Math.Sign(dY);

            dX = Math.Abs(dX);
            dY = Math.Abs(dY);

            bool isDxGreater = true;
            if (dX < dY)
            {
                isDxGreater = false;
                int temp = dX;
                dX = dY;
                dY = temp;
            }

            int error = 2 * dY - dX;
            int dotCount = dX + 1;
            dY *= 2;
            dX *= 2;

            for (int i = 0; i < dotCount; i++)
            {
                workBitmap.SetPixel((int)X, (int)Y, workColor);
                if (error >= 0)
                {
                    if (isDxGreater)
                    {
                        Y += deltaY;
                    }
                    else
                    {
                        X += deltaX;
                    }
                    error -= dX;
                }

                if (error < 0)
                {
                    if (isDxGreater)
                    {
                        X += deltaX;
                    }
                    else
                    {
                        Y += deltaY;
                    }
                    error += dY;
                }
            }
        }
        public static void DrawLineBresenhamFlat(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {
            int iMax = 255;

            int X = firstPoint.X;
            int Y = firstPoint.Y;

            int dX = secondPoint.X - firstPoint.X;
            int dY = secondPoint.Y - firstPoint.Y;

            int deltaX = Math.Sign(dX);
            int deltaY = Math.Sign(dY);

            dX = Math.Abs(dX);
            dY = Math.Abs(dY);

            bool isDxGreater = true;
            if (dX < dY)
            {
                isDxGreater = false;
                int temp = dX;
                dX = dY;
                dY = temp;
            }

            float tg = 0;
            if (dX != 0)
            {
                tg = (float)dY / dX * iMax;
            }

            float e = iMax / 2;
            float w = iMax - tg;

            workColor = Color.FromArgb((int)(255 - e), workColor);
            workBitmap.SetPixel((int)X, (int)Y, workColor);
            for (int i = 0; i < dX; i++)
            {
                if (e < w)
                {
                    if (isDxGreater)
                    {
                        X += deltaX;
                    }
                    else
                    {
                        Y += deltaY;
                    }
                    e += tg;
                }
                else
                {
                    X += deltaX;
                    Y += deltaY;
                    e -= w;
                }

                workColor = Color.FromArgb((int)(255 - e), workColor);
                workBitmap.SetPixel((int)X, (int)Y, workColor);
            }
        }

        public static void SwapInt(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = first;
        }
        
        public static void DrawLineVu(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {
            int iMax = 255;

            int dX = secondPoint.X - firstPoint.X;
            int dY = secondPoint.Y - firstPoint.Y;

            int firstX = firstPoint.X;
            int firstY = firstPoint.Y;
            int secondX = secondPoint.X;
            int secondY = secondPoint.Y;

            bool change = false;
            if (dY > dX)
            {
                SwapInt(ref firstX, ref firstY);
                SwapInt(ref secondX, ref secondY);
                SwapInt(ref dX, ref dY);
                change = true;
            }

            if (secondPoint.X < firstPoint.X)
            {
                SwapInt(ref firstX, ref secondX);
                SwapInt(ref firstY, ref secondY);
            }

            float tg = 0;
            if (dX != 0)
            {
                tg = (float)dY / dX;
            }

            double Y = firstY;
            double d1, d2;

            for (int X = firstX; X < secondX; X++)
            {
                d1 = iMax * (Y - (int)Y);
                d2 = iMax - d1;

                if (change)
                {
                    workBitmap.SetPixel((int)Y, X, Color.FromArgb((int)(d2), workColor));
                    workBitmap.SetPixel((int)Y + 1, X, Color.FromArgb((int)(d1), workColor));
                }
                else
                {
                    workBitmap.SetPixel(X, (int)Y, Color.FromArgb((int)(d2), workColor));
                    workBitmap.SetPixel(X, (int)Y + 1, Color.FromArgb((int)(d1), workColor));
                }

                Y += tg;
            }
        }

        public static double DegreeToRadian(double angleInDegree)
        {
            return angleInDegree * Math.PI / 180;
        }

        public static Point GetEndPoint(Point start, double angle, int lenght)
        {
            start.X += (int)(lenght * Math.Cos(DegreeToRadian(angle)));
            start.Y += (int)(lenght * Math.Sin(DegreeToRadian(angle)));

            return start;
        }

        public static void DrawSun(Point center, Bitmap workBitmap, Color workColor, int lenght,  double angle, DrawLineMethod method)
        {
            Point endPoint;
            for (double i = 0; i < 360; i += angle)
            {
                endPoint = GetEndPoint(center, i, lenght);
                method(center, endPoint, workBitmap, workColor);
            }
        }
    }
}
