using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsLesson
{
    class Program
    {
        static string name1 = "Толя";
        static string name2 = "ТоНя";
        static void MyNewThread()
        {
            string s = name1;
            name1 = name2;
            name2 = s;
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(MyNewThread));
            thread.Start();
            Swap();

            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }

        private static async void Swap()
        {
            string s = name1;
            name1 = name2;
            name2 = s;
        }
    }
}
