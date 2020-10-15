using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1806
{
    class Point
    {
        int x;
        private int y;

        public int X { get { return x; } set { x = value; } }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                    Y = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    y = value;
                }
            }
        }

        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }


    }
}
