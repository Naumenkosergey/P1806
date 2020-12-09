using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    class Runner
    {
        static Group[] groups = new Group[10];
        static Student[] students = new Student[300];
        static Random random = new Random();
        static void Main(string[] args)
        {
            CreateGrups();
            CreateStudents();
            PrintStudents();
            //PrintGroups();

            ///////////////BEGIN BINARY/////////////////////
            var binFormater = new BinaryFormatter();           
            BinarySerializable(binFormater, "students.bin", students);
            Console.WriteLine("----------------------------------------");
            BinaryDesirializable(binFormater, "students.bin");
            ///////////////END BINARY/////////////////////
            Console.ReadKey();

            //Simple Object Acses Protocol не работает со списком (LIST)
            ///////////////BEGIN SOAP//////////////////////
            var soap = new SoapFormatter();
            SoapSerializable(soap, "group.soap", groups);
            Console.WriteLine("-----------------soap-----------------------");
            SoapDesirializable(soap, "group.soap");
            ///////////////END SOAP/////////////////////

        }

        private static void BinaryDesirializable(BinaryFormatter binFormater, string nameFile)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                var deSirializeFile = binFormater.Deserialize(file) as Student[];
                if (deSirializeFile != null)
                {
                    foreach (var item in deSirializeFile)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static void BinarySerializable(BinaryFormatter binFormater, string nameFile, object[] colections)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                binFormater.Serialize(file, colections);
            }
        }

        private static void SoapDesirializable(SoapFormatter soap, string nameFile)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                var deSirializeFile = soap.Deserialize(file) as Group[];
                if (deSirializeFile != null)
                {
                    foreach (var item in deSirializeFile)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static void SoapSerializable(SoapFormatter soap, string nameFile, object[] colections)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                soap.Serialize(file, colections);
            }
        }


        private static void CreateStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {

                Student student = new Student(Guid.NewGuid().ToString().Substring(0, 7), random.Next(10, 20));
                students[i] = student;
                students[i].Group = groups[random.Next(groups.Length)];
            }
        }

        private static void CreateGrups()
        {
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new Group(random.Next(1000, 10000));
            }
        }

        private static void PrintStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintGroups()
        {
            foreach (var item in groups)
            {
                Console.WriteLine(item);
            }
        }
    }
}
