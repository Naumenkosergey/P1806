using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string param = url.Substring(url.IndexOf("?") + 1);
            string[] paramsSplit = param.Split('&');
            string obj = null;

            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in paramsSplit)
            {
                string[] paramAndVAlue = item.Split('=');
                stringBuilder.Append(paramAndVAlue[0]);
                stringBuilder.Append(" ");

                if (paramAndVAlue[0].Equals("obj"))
                {
                    obj = paramAndVAlue[1];
                }
            }

            Console.WriteLine(stringBuilder.ToString().Trim());

            if (obj != null)
            {

                try
                {
                    Alert(double.Parse(obj));
                }
                catch (FormatException)
                {
                    Alert(obj);
                }
            }
        }

        private static void Alert(string value)
        {
            Console.WriteLine($"string: {value}");
        }

        private static void Alert(double value)
        {
            Console.WriteLine($"double: {value}");
        }
    }
}
