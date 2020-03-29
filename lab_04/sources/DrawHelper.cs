using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_04
{
    public static class DrawHelper
    {
        public delegate void DrawCircleMethod(Bitmap workBitmap, Color workColor, Point center, int radius);

        public static void DrawCircle(Bitmap workBitmap, DrawCircleMethod method, Color workColor, Point center, int radius)
        {

        }

        public static void DrawCircleCompare(Bitmap workBitmap, DrawCircleMethod method, Color workColor, Point center, int type, int startRadius, int endRadius, int circleCount, int step)
        {

        }

        public static void DrawCircleCompareStandart(Graphics workBitmap, Color workColor, Point center, int type, int startRadius, int endRadius, int circleCount, int step)
        {

        }

        public static void DrawCircleCanonical(Bitmap workBitmap, Color workColor, Point center, int radius)
        {

        }

        public static void DrawCircleBresenham(Bitmap workBitmap, Color workColor, Point center, int radius)
        {

        }

        public static void DrawCircleParam(Bitmap workBitmap, Color workColor, Point center, int radius)
        {

        }

        public static void DrawCircleMiddle(Bitmap workBitmap, Color workColor, Point center, int radius)
        {

        }
    }
}
