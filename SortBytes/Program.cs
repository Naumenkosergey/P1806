using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            ISet<int> set = new SortedSet<int>();
            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                set.Add(streamReader.Read());
            }
            //List<int> list = new List<int>(set);
            //list.Sort();

            foreach(var item in set)
            {
                Console.Write(item + " " );
            }
        }
    }
}
