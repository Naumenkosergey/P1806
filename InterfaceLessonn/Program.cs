using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLessonn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mas = { 5, 2, 9, 1, 3 };
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog("Жучка", 7, 300);
            dogs[1] = new Dog("Полкаша", 15, 200);
            dogs[2] = new Dog("Тузик", 12, 200);
            PrinttArray(dogs);
            Array.Sort(dogs,dogs[0].Compare);
            PrinttArray(dogs);
        }

        private static void PrinttArray(int[] mas)
        {
            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------");
        }
        private static void PrinttArray(Dog[] mas)
        {
            foreach (var item in mas)
            {
                Console.Write(item + "\n");
            }
            Console.WriteLine("\n-------------");
        }

        static int Comp(int a, int b)
        {
            return b.CompareTo(a);
        }

        static int Comp(string s, string s2)
        {
            return s2.CompareTo(s);
        }
        static int Comp(char s, char s2)
        {
            return s-s2;
        }
    }
}
