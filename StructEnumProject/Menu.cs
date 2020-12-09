using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumProject
{
    class Menu
    {
        public static void MenuText()
        {
            Console.WriteLine("1 - Ввод массива структур");
            Console.WriteLine("2 - изменение структуры структуры");
            Console.WriteLine("3 - Вывод на экран массива структур");
            Console.WriteLine("4 - специальный пунк1 (общий пробег по одной марке)");
            Console.WriteLine("5 - специальный пунк2 (общая сумма ремонта по одному мастеру)");
            Console.WriteLine("6 - Выход");
            Console.WriteLine("---------------------------");
        }

        public static void SelectMenuItem(int item)
        {
            switch (item)
            {
                case 1: WorkStruct.CreateArrayStructAutoservice();break;
                case 2: WorkStruct.UpdateStructFromId();break;
                case 3: WorkStruct.PrintStruct();break;
                case 4: Console.WriteLine(WorkStruct.AmountAdometrCurrentBrendCar());break;
                case 5: Console.WriteLine(WorkStruct.AmountPriceCurrentMaster());break;
                case 6: Environment.Exit(0);break;
                default: Console.WriteLine("такого пункта нет");break;
            }
        }
    }
}
