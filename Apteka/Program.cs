using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Apteka
{
    class Program
    {
        public static DrugController drugController = new DrugController();
        public static bool isStoped = false;
        static void Main(string[] args)
        {

            Thread thread2 = new Thread(new Person().Run);
            thread2.Name = "Мужчина";
            Thread thread = new Thread(new ThreadStart(new Apteka().Run));
            thread.Name = "Аптека";
            Thread thread3 = new Thread(new Person().Run);
            thread3.Name = "Женщина";
            thread2.Start();
            thread3.Start();
            thread.Start();
            Thread.Sleep(5000);
            isStoped = true;
        }

        public static int GetRandomCount()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }

        public static Drug GetRandomDrug()
        {
            Random random = new Random();
            List<Drug> drugs = new List<Drug>(DrugController.allDrugs.Keys);
            int i = random.Next(0, drugs.Count);
            return drugs[i];
        }
    }

    

    


}
