using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriliazableLesson
{
    [Serializable]
    public class Student
    {
        [NonSerialized]
        int age;
        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 13)
                    age = value + 5;
                else if (value <= 17)
                    age = value + 3;
                else
                    age = value;
            }
        }

        public Group Group { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Student(){}

        public override string ToString()
        {
            return $"Cтудент {Name} возраст {Age} учится в группе {Group}";
        }
    }
}
