using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1806
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point();

            pointA.Y = int.Parse(Console.ReadLine());
            Console.WriteLine(pointA.X+" "+pointA.Y);
            
            
            //Point pointB = new Point(5, 13);

            //Line line = new Line(pointA, pointB);
            //Console.WriteLine(line.Start +" " +line.End);

            //Console.WriteLine(line.GetLineLength());
            //Console.WriteLine(pointA.ToString());
            //Console.WriteLine(pointB.ToString());

        }

    }
}
