using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLessons
{
    public delegate int CountDelegate(string massage);
    class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }

        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }
        public int GetCountSymbo(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }
    }
}
