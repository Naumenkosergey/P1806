using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriliazableLesson
{
    [Serializable]
    class Group
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public Group(){}

        public Group(int number)
        {
            Name = "BEST";
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name}--{Number}";
        }
    }
}
