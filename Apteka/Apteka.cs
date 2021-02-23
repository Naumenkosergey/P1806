using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Apteka
{
    public class Apteka
    {
        public void Run()
        {
            while (!Program.isStoped)
            {
                Program.drugController.Sell(Program.GetRandomDrug(), Program.GetRandomCount());
                Thread.Sleep(300);
            }
        }
    }
}
