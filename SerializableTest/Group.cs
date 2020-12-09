using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    [Serializable] //для разрешения сериализации
    class Group
    {
        //{   [NonSerialized]
        //    private Random random = new Random(DateTime.Now.Millisecond);
        //[NonSerialized]
        //private int privatint = 5;
        public int Number { get; set; }
        public string Name { get; set; }
        

        public Group() { }
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
