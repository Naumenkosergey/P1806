using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMostFrequentBytes
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
            
            int maxCount = int.MinValue;
            foreach (int item in byteCountArray)
            {
                if (item > maxCount && item > 0)
                    maxCount = item;
            }

            IList<int> result = new List<int>();
            for (int i = 0; i < byteCountArray.Length; i++)
            {
                if (byteCountArray[i] == maxCount)
                    result.Add(i);
            }

            foreach (int item in result)
                Console.Write(item + " ");
        }
    }
}
