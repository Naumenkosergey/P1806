using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumProject
{
    class WorkStruct
    {
        static Autoservice[] autoservices;

        public static void CreateArrayStructAutoservice()
        {
            Console.WriteLine("Сколько структур создать?");
            int count = int.Parse(Console.ReadLine());
            autoservices = new Autoservice[count];
            WriteData();
        }

        private static void WriteData()
        {
            for (int i = 0; i < autoservices.Length; i++)
            {
                Console.WriteLine("введите гос номер авто");
                autoservices[i].regNomer = Console.ReadLine();
                Console.WriteLine("выберите марку авто. для выбора укажите номер марки");
                PrintBrendCar();
                autoservices[i].brendCar = (Brend)int.Parse(Console.ReadLine());

                Console.WriteLine("введите пробег в целых километрах");
                autoservices[i].odometr = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите фамилию мастера");
                autoservices[i].surnameMaster = Console.ReadLine();

                Console.WriteLine("Введите конечную стоимость ремонта");
                autoservices[i].price = double.Parse(Console.ReadLine());

                Console.WriteLine("-----------------------------------");
            }
        }

        private static void PrintBrendCar()
        {
            int j = 0;
            foreach (var item in Enum.GetNames(typeof(Brend)))
            {
                Console.WriteLine($"{j++} - {item}");
            }
        }

        public static void PrintStruct()
        {
            for (int i = 0; i < autoservices.Length; i++)
            {
                Console.WriteLine($"{i + 1}|{autoservices[i].regNomer}|{autoservices[i].brendCar}|" +
                    $"{autoservices[i].odometr}|{autoservices[i].surnameMaster}|{autoservices[i].price}");
            }
        }

        public static int AmountAdometrCurrentBrendCar()
        {
            Console.WriteLine("выберите марку автомобиля по которой вывести километраж. укажите номер");
            PrintBrendCar();
            int brend = int.Parse(Console.ReadLine());
            int amountAdometr = 0;
            for (int i = 0; i < autoservices.Length; i++)
            {
                if (autoservices[i].brendCar == (Brend)brend)
                    amountAdometr += autoservices[i].odometr;
            }
            return amountAdometr;
        }

        public static double AmountPriceCurrentMaster()
        {
            Console.WriteLine("напишите фамилию мастера");
            string surname = Console.ReadLine();
            double amountPrice = 0;
            for (int i = 0; i < autoservices.Length; i++)
            {
                if (autoservices[i].surnameMaster == surname)
                    amountPrice += autoservices[i].price;
            }
            return amountPrice;
        }

        public static void UpdateStructFromId()
        {
            Console.WriteLine("укажите номер в который хотите внести изменения");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < autoservices.Length; i++)
            {
                if (i == n - 1)
                {
                    Update(i);
                }
            }
        }

        private static void Update(int i)
        {
            Console.WriteLine("хотите поменять номер? y/n");
            if (CheckChoise()) 
                autoservices[i].regNomer = Console.ReadLine();
            
            Console.WriteLine("хотите поменять марку? y/n");
            if (CheckChoise()) 
            {
                PrintBrendCar(); 
                autoservices[i].brendCar = (Brend)int.Parse(Console.ReadLine());
            }
          
            Console.WriteLine("хотите поменять пробег? y/n");
            if (CheckChoise()) 
                autoservices[i].odometr = int.Parse(Console.ReadLine());

            Console.WriteLine("хотите поменять фамилию мастера? y/n");
            if (CheckChoise()) 
                autoservices[i].surnameMaster = Console.ReadLine();

            Console.WriteLine("хотите поменять стоимость? y/n");
            if (CheckChoise()) 
                autoservices[i].price = double.Parse(Console.ReadLine());
        }

        public static bool CheckChoise()
        {
            return Console.ReadLine() == "y" ? true : false;
        }
    }
}
