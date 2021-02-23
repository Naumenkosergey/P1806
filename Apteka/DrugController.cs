using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Apteka
{
    class DrugController
    {
        public static Dictionary<Drug, int> allDrugs = new Dictionary<Drug, int>();

        public DrugController()
        {
            CreateDrugs();
        }
        static void CreateDrugs()
        {
            Drug analgin = new Drug();
            analgin.Name = "Анальгин";
            allDrugs.Add(analgin, 5);

            Drug aspirin = new Drug();
            aspirin.Name = "Аспирин";
            allDrugs.Add(aspirin, 3);

            Drug rinza = new Drug();
            rinza.Name = "Ринза";
            allDrugs.Add(rinza, 10);
        }

        public void Buy(Drug drug, int count)
        {
            lock (allDrugs)
            {
                string name = Thread.CurrentThread.Name;
                if (!allDrugs.ContainsKey(drug))
                    Console.WriteLine($"{drug} нет в наличии");
                int currentCount;
                allDrugs.TryGetValue(drug, out currentCount);
                if (currentCount < count)
                    Console.WriteLine($"{name} хочет купить {drug} {count}. В наличии {currentCount}");
                else
                {
                    //allDrugs.Remove(drug);
                    allDrugs[drug]-=count;
                    Console.WriteLine($"{name} купил(а) {drug} {count} шт. осталось {currentCount - count}");
                }
            }
        }

        public void Sell(Drug drug, int count)
        {
            lock (allDrugs)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Закупка {drug} {count} шт.");
                if (!allDrugs.ContainsKey(drug))
                    allDrugs.Add(drug, 0);
                int currentCount;
                allDrugs.TryGetValue(drug, out currentCount);
                //allDrugs.Remove(drug);
                allDrugs[drug] += count;
            }
        }
    }
}
