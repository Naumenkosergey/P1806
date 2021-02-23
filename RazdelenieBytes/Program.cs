using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazdelenieBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"F:\test.txt";
            string file2 = @"F:\text.txt";
            string file3 = @"F:\text1.txt";
            StreamReader streamReader = new StreamReader(file1);
            StreamWriter writer1 = new StreamWriter(file2);
            StreamWriter writer2 = new StreamWriter(file3);

            List<char> list = new List<char>();
            while (!streamReader.EndOfStream)
            {
                list.Add(Convert.ToChar(streamReader.Read()));
            }
            int size = list.Count;
            writer1.Write(list.ToArray(), 0, (size + 1) / 2);
            writer2.Write(list.ToArray(), (size + 1) / 2, size / 2);

            streamReader.Close();
            writer1.Close();
            writer2.Close();
        }
    }
}
