using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    [Serializable]
    internal class Student
    {
        int age;
        public string Name { get; }
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
