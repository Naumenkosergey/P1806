using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLessonn
{
    class Dog : IComparer<Dog>
    {
        int age;

        string Name { get; set; }

        int Age {
            get 
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 25)
                    age = 0;
                else
                    age = value;
            }
        }

        int Size { get; set; }

        public Dog() { }

        public Dog(string name, int age, int size)
        {
            Name = name;
            Age = age;
            Size = size;
        }

        public override string ToString()
        {
            return $" собачка по кличке {Name} весит {Size} кг, возраст {Age} лет";
        }

        public int CompareTo(object obj)
        {
            Dog dog = (Dog)obj;
            //if (Size > dog.Size)
            //    return 1;
            //else if (Size < dog.Size)
            //    return -1;
            //return 0;
            return Size.CompareTo(dog.Size);
        }

        public int CompareTo(Dog other)
        {
            return Size.CompareTo(other.Size);
        }

        public int Compare(Dog x, Dog y)
        {
            return y.Name.CompareTo(x.Name);
        }
    }
}
