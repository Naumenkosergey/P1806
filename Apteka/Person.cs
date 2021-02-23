using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Apteka
{
    public class Person
    {
        public void Run()
        {
            while (!Program.isStoped)
            {
                Program.drugController.Buy(Program.GetRandomDrug(), Program.GetRandomCount());
                Thread.Sleep(100);
            }
        }
    }
}
