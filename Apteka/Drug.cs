using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    class Drug
    {
        public string Name { get; set; }
        public string Discription { get; set; }

        public override string ToString()
        {
            return $" Лекарство {Name} ";
        }
    }
}
