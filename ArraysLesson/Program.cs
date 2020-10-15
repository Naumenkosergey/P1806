using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dima dima kolya petya dima";

            Console.WriteLine(s.Replace("dima", "tema"));

            string[] sArray = s.Split('a');

            foreach (var el in sArray)
            {
                
            }


            



        }
    }
}
