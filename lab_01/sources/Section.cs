using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_01
{
    class Section
    {
        public PointF first;
        public PointF second;

        public bool IsEmpty { get => first.IsEmpty || second.IsEmpty; }
        public double Len
        {
            get
            {
                if (IsEmpty)
                {
                    throw new ArgumentNullException();
                }
                return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
            }
        }

        public Section(PointF first, PointF second)
        {
            this.first = first;
            this.second = second;
        }
        
        public Section()
        {

        }

    }
}
