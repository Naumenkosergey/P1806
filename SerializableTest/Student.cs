using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    [DataContract]
    internal class Student
    {
        int age;
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 13)
                    age = value + 5;
                else if (value <= 16)
                    age = value + 3;
                else
                    age = value;
            }
        }
        [DataMember]
        public Group Group { get; set; }

        public Student(string name, int age)
        {
            //проверка входных параметров
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"студент {Name} возраст {Age} учится в группе {Group}";
        }
    }
}
