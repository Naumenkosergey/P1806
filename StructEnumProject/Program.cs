using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.MenuText();
                int item = int.Parse(Console.ReadLine());
                Menu.SelectMenuItem(item);
            }
        }

        

        
    }
}
