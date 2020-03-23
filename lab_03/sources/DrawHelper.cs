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

            float m = 0;
            if (dX != 0)
            {
                m = (float)dY / (dX);
            }

            float error = m - (1.0f / 2);

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
                    error += m;
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
                    error -= 2 * dX;
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
                    error += 2 * dY;
                }
            }
        }
        public static void DrawLineBresenhamFlat(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {
            int iMax = 256;

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

            float h = 0;
            if (dX != 0)
            {
                h = (float)dY / dX * iMax;
            }

            float e = iMax / 2;
            float w = iMax - h;
            for (int i = 0; i < dX + 1; i++)
            {
                workColor = Color.FromArgb((int)(255 - e), workColor);
                workBitmap.SetPixel((int)X, (int)Y, workColor);

                if (e <= w)
                {
                    if (isDxGreater)
                    {
                        X += deltaX;
                    }
                    else
                    {
                        Y += deltaY;
                    }
                    e += h;
                }
                else
                {
                    X += deltaX;
                    Y += deltaY;
                    e -= w;
                }
            }
        }
        public static void DrawLineVu(Point firstPoint, Point secondPoint, Bitmap workBitmap, Color workColor)
        {

        }

        public static void DrawSun(Point center, Bitmap workBitmap, Color workColor, int lenght,  double angle, DrawLineMethod method)
        {

        }
    }
}
