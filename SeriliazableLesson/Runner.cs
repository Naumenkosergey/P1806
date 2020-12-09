using SeriliazableLesson;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace SerialiazableLesson
{
    class Runner
    {
        static Group[] groups = new Group[10];
        static Student[] students = new Student[300];
        static Random random = new Random();

        static void Main(string[] args)
        {
            GreateGroups();
            CreateStudents();
            PrintStudents();

            var binarySerialiazable = new BinaryFormatter();
            using (var file = new FileStream("students.bin", FileMode.OpenOrCreate))
            {
                binarySerialiazable.Serialize(file, students);
            }

            Console.WriteLine("----------------------------------------------");
            using (var file = new FileStream("students.bin", FileMode.OpenOrCreate))
            {
                var desirializableBinary = binarySerialiazable.Deserialize(file) as Student[];
                if (desirializableBinary != null)
                {
                    foreach (var item in desirializableBinary)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            var soap = new SoapFormatter();
            using (var file = new FileStream("GROUPS.soap", FileMode.OpenOrCreate))
            {
                soap.Serialize(file, groups);
            }

            Console.WriteLine("----------------------------------------------");
            using (var file = new FileStream("GROUPS.soap", FileMode.OpenOrCreate))
            {
                var desirializableBinary = soap.Deserialize(file) as Group[];
                if (desirializableBinary != null)
                {
                    foreach (var item in desirializableBinary)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static void PrintStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        private static void CreateStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Student student = new Student(Guid.NewGuid().ToString().Substring(0, 6), random.Next(10, 20));
                students[i] = student;
                students[i].Group = groups[random.Next(groups.Length)];
            }
        }

        private static void GreateGroups()
        {
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new Group(random.Next(1000, 10000));
            }
        }
    }
}
