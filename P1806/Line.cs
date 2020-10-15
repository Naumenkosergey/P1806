using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1806
{
    class Line
    {
        Point start;
        Point end;

        public Line() { }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;

        }

        
        internal Point Start { get => start; set => start = value; }
        internal Point End { get => end; set => end = value; }

        public double GetLineLength()
        {
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2));
        }


    }
}
