using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_05
{

    internal class Agregator
    {
        List<(Point, Point)> ribs;
        int maxX = 0;
        Color workColor = Color.Black;
        Color backColor = Color.White;

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

        internal Agregator(List<(Point, Point)> ribs, int maxX, Color workColor, Color backColor, Bitmap workBitmap)
        {
            this.ribs = ribs;
            this.maxX = maxX;
            this.workColor = workColor;
            this.backColor = backColor;
            this.workBitmap = workBitmap;
            isEmpty = false;
        }

        internal static void FillPolygon(List<(Point, Point)> ribs, int maxX, Color workColor, Color backColor, Bitmap workBitmap)
        {
            Point first;
            Point second;
            int dY;
            double dX;
            int currentY;
            double currentX;

            foreach (var rib in ribs)
            {
                first = rib.Item1;
                second = rib.Item2;

                // Игнорируем горизонтальные ребра
                if (first.Y == second.Y)
                {
                    continue;
                }
                else if (first.Y > second.Y)
                {
                    Point temp = first;
                    first = second;
                    second = temp;
                }

                dY = second.Y - first.Y;
                dX = (double)(second.X - first.X) / dY;
                currentX = first.X + 1; // начинаем с ближайшего правого пиксела
                currentY = first.Y;

                for (int i = 0; i < dY; i++)
                {
                    for (int x = (int)currentX; x < maxX; x++)
                    {
                        // т.к цвет заливки может не быть дополнением фонового,
                        // то надо смотреть на цвет пикселя =>
                        // лишнее сравнение и долгие операции считывания/записи

                        Color tempColor = workBitmap.GetPixel(x, currentY);

                        if (tempColor.R == backColor.R && tempColor.G == backColor.G && tempColor.B == backColor.B)
                        {
                            workBitmap.SetPixel(x, currentY, workColor);
                        }
                        else
                        {
                            workBitmap.SetPixel(x, currentY, backColor);
                        }
                    }

                    currentX += dX;
                    currentY += 1;
                }
            }

            DrawRibs(workBitmap, ribs, workColor);
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

        internal bool NextStep()
        {
            if (isHandleStart)
            {
                if (currentStep + 1 < dY)
                {
                    currentStep++;
                    currentX += dX;
                    currentY += 1;

                    for (int x = (int)currentX; x < maxX; x++)
                    {
                        // т.к цвет заливки может не быть дополнением фонового,
                        // то надо смотреть на цвет пикселя => лишнее сравнение

                        Color tempColor = workBitmap.GetPixel(x, currentY);

                        if (tempColor.R == backColor.R && tempColor.G == backColor.G && tempColor.B == backColor.B)
                        {
                            workBitmap.SetPixel(x, currentY, workColor);
                        }
                        else
                        {
                            workBitmap.SetPixel(x, currentY, backColor);
                        }
                    }
                }
                else if (currentRib + 1 < ribs.Count)
                {
                    currentRib++;
                    Point first = ribs[currentRib].Item1;
                    Point second = ribs[currentRib].Item2;
                    dY = 0;
                    currentStep = 0;

                    // Игнорируем горизонтальные ребра
                    if (first.Y == second.Y)
                    {
                        return NextStep();
                    }
                    else if (first.Y > second.Y)
                    {
                        Point temp = first;
                        first = second;
                        second = temp;
                    }

                    dY = second.Y - first.Y;
                    dX = (double)(second.X - first.X) / dY;
                    currentX = first.X + 0.5; // 0.5 для удобного округления (отброс дробной части)
                    currentY = first.Y;

                    for (int x = (int)currentX; x < maxX; x++)
                    {
                        // т.к цвет заливки может не быть дополнением фонового,
                        // то надо смотреть на цвет пикселя => лишнее сравнение

                        Color tempColor = workBitmap.GetPixel(x, currentY);

                        if (tempColor.R == backColor.R && tempColor.G == backColor.G && tempColor.B == backColor.B)
                        {
                            workBitmap.SetPixel(x, currentY, workColor);
                        }
                        else
                        {
                            workBitmap.SetPixel(x, currentY, backColor);
                        }
                    }
                }
                else
                {
                    isEmpty = true;
                    isHandleStart = false;
                }
            }
            else if (!isEmpty)
            {
                if (ribs.Count == 0)
                {
                    isEmpty = true;
                    isHandleStart = false;
                    return isEmpty;
                }
                isHandleStart = true;

                Point first = ribs[0].Item1;
                Point second = ribs[0].Item2;
                dY = 0;
                currentStep = 0;

                // Игнорируем горизонтальные ребра
                if (first.Y == second.Y)
                {
                    NextStep();
                }
                else if (first.Y > second.Y)
                {
                    Point temp = first;
                    first = second;
                    second = temp;
                }

                dY = second.Y - first.Y;
                dX = (double)(second.X - first.X) / dY;
                currentX = first.X + 0.5; // 0.5 для удобного округления (отброс дробной части)
                currentY = first.Y;

                for (int x = (int)currentX; x < maxX; x++)
                {
                    // т.к цвет заливки может не быть дополнением фонового,
                    // то надо смотреть на цвет пикселя => лишнее сравнение

                    Color tempColor = workBitmap.GetPixel(x, currentY);

                    if (tempColor.R == backColor.R && tempColor.G == backColor.G && tempColor.B == backColor.B)
                    {
                        workBitmap.SetPixel(x, currentY, workColor);
                    }
                    else
                    {
                        workBitmap.SetPixel(x, currentY, backColor);
                    }
                }
            }

            return isEmpty;
        }
    }
}