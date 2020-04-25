using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_06
{

    internal class Agregator
    {
        Point seed = Point.Empty;
        Color workColor = Color.Black;
        Color borderColor = Color.White;

        internal bool isEmpty = true;
        internal Bitmap workBitmap;

        int currentRib = 0;
        double currentX = 0;
        int currentY = 0;
        int currentStep = 0;
        double dX = 0;
        int dY = 0;
        bool isHandleStart = false;
        internal Agregator()
        {
            isEmpty = true;
        }

        internal Agregator(Point seed, Color workColor, Color borderColor, Bitmap workBitmap)
        {
            this.seed = seed;
            this.workColor = workColor;
            this.borderColor = borderColor;
            this.workBitmap = workBitmap;
            isEmpty = false;
        }

        private static bool IsColorEquals(Color first, Color second)
        {
            return first.R == second.R && first.G == second.G && first.B == second.B;
        }
        internal static void FillPolygon(Point seed, Color workColor, Color borderColor, Bitmap workBitmap)
        {
            Stack<Point> pointStack = new Stack<Point>();
            pointStack.Push(seed);

            while (!pointStack.IsEmpty)
            {
                Point currentPoint = pointStack.Pop();
                int X = currentPoint.X;
                int Y = currentPoint.Y;

                Color curColor = workBitmap.GetPixel(X, Y);
                while (!IsColorEquals(curColor, borderColor) && X + 1 < workBitmap.Width)
                {
                    workBitmap.SetPixel(X, Y, workColor);
                    X++;
                    curColor = workBitmap.GetPixel(X, Y);
                }

                int xRight = X - 1;
                X = currentPoint.X;

                X--;
                curColor = workBitmap.GetPixel(X, Y);
                while (!IsColorEquals(curColor, borderColor) && X > 0)
                {
                    workBitmap.SetPixel(X, Y, workColor);
                    X--;
                    curColor = workBitmap.GetPixel(X, Y);
                }
                X++;
                int xLeft = X;

                if (Y + 1 < workBitmap.Height)
                {
                    FindSeed(pointStack, xLeft, xRight, Y + 1, workColor, borderColor, workBitmap);
                }
                if (Y > 0)
                {
                    FindSeed(pointStack, xLeft, xRight, Y - 1, workColor, borderColor, workBitmap);
                }
            }
        }

        private static void FindSeed(Stack<Point> pointStack, int X, int xRight, int Y, Color workColor, Color borderColor, Bitmap workBitmap)
        {
            bool finded = false;
            Color curColor = workBitmap.GetPixel(X, Y);

            while (X <= xRight)
            {
                while (!IsColorEquals(curColor, borderColor) && !IsColorEquals(curColor, workColor) && X <= xRight)
                {
                    finded = true;
                    X++;
                    curColor = workBitmap.GetPixel(X, Y);
                }

                if (finded)
                {
                    pointStack.Push(new Point(X - 1, Y));
                }

                while ((IsColorEquals(curColor, borderColor) || IsColorEquals(curColor, workColor)) && X <= xRight)
                {
                    X++;
                    curColor = workBitmap.GetPixel(X, Y);
                }
            }
        }

        internal static void DrawRibs(Bitmap workBitmap, List<(Point, Point)> ribs, Color workColor)
        {
            Graphics graph = Graphics.FromImage(workBitmap);
            Pen pen = new Pen(workColor);
            foreach (var rib in ribs)
            {
                graph.DrawLine(pen, rib.Item1, rib.Item2);
            }
        }
    }
}