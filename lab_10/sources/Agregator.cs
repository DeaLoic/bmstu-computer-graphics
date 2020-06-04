using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_10
{

    internal static class Agregator
    {
        public static List<(Point, Point)> Cutting((Point, Point) cutter, List<(Point, Point)> lines)
        {

            List<(Point, Point)> curLines = new List<(Point, Point)>();

            Point first, second, middle, buff, temp;
            middle = Point.Empty;
            byte codeFirst, codeSecond;
            int i;

            foreach (var line in lines)
            {

                i = 1;

                first = line.Item1;
                second = line.Item2;

                while (true)
                {
                    codeFirst = ComputeBinCode(cutter, first);
                    codeSecond = ComputeBinCode(cutter, second);

                    if (codeFirst == 0 && codeSecond == 0) 
                    {
                        // отрезок тривиально видим
                        curLines.Add(line);
                        break;
                    }

                    if ((codeFirst & codeSecond) != 0)
                    {
                        // отрезок тривиально не видим
                        break;
                    }
                    else // частично видим
                    {
                        buff = first;

                        if (i > 2)
                        {
                            if ((codeFirst & codeSecond) == 0) // отрезок видим
                            {
                                curLines.Add((first, second));
                            }
                            break;
                        }

                        if (codeSecond == 0)
                        {
                            first = second;
                            second = buff;
                            i++;
                        }
                        else
                        {
                            // пока не вырождается в точку
                            while (Math.Abs(first.X - second.X) > 1 || Math.Abs(first.Y - second.Y) > 1)
                            {
                                middle.X = (first.X + second.X) / 2;
                                middle.Y = (first.Y + second.Y) / 2;

                                temp = first;
                                first = middle;
                                codeFirst = ComputeBinCode(cutter, first);
                                if ((codeFirst & codeSecond) != 0)
                                {
                                    // эта часть не видима, обрабатываем вторую половину
                                    first = temp;
                                    second = middle;
                                }
                            }

                            first = second;
                            second = buff;
                            i++;
                        }
                    }
                }
            }

            return curLines;

        }

        private static byte ComputeBinCode((Point, Point) cutter, Point point)
        {
            byte answer = 0;
            if (point.X <= cutter.Item1.X)
            {
                answer |= 8;
            }

            if (point.X >= cutter.Item2.X)
            {
                answer |= 4;
            }

            if (point.Y <= cutter.Item1.Y)
            {
                answer |= 2;
            }

            if (point.Y >= cutter.Item2.Y)
            {
                answer |= 1;
            }

            return answer;
        }
    }
}