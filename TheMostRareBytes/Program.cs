using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMostRareBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileNmae = Console.ReadLine();
            StreamReader streamReader = new StreamReader(fileNmae);
            int[] byteCountArray = new int[255];
            while (!streamReader.EndOfStream)
            {
                byteCountArray[streamReader.Read()] += 1;
            }
            int minCount = int.MaxValue;
            foreach (int item in byteCountArray)
            {
                if (item < minCount && item > 0)
                    minCount = item;
            }

            IList<int> result = new List<int>();
            for (int i = 0; i < byteCountArray.Length; i++)
            {
                if (byteCountArray[i] == minCount)
                    result.Add(i);
            }

            foreach (int item in result)
                Console.Write(item + " ");
            streamReader.Close();
        }
    }
}
