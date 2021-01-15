using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    [Serializable, DataContract] //для разрешения сериализации
   public class Group
    {
        //{   [NonSerialized]
        //    private Random random = new Random(DateTime.Now.Millisecond);
        //[NonSerialized]
        //private int privatint = 5;
        [DataMember]
        public int Number { get; set; }
        [DataMember]
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
