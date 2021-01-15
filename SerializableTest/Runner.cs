using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            PrintGroups();
            PrintStudents();

            Console.WriteLine("------------------bin----------------------");
            BinWork();
            Console.ReadKey();

            Console.WriteLine("-----------------soap-----------------------");
            SoapWork();
            Console.ReadKey();

            Console.WriteLine("-----------------XML-----------------------");
            XmlWork();
            Console.ReadKey();

            Console.WriteLine("-----------------JSON-----------------------");
            JsonWork();

        }

        private static void JsonWork()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Student[]));
            SerializableJSON.JsonSerializable(jsonFormatter, "students.json", students);
            SerializableJSON.JsonDesirializable(jsonFormatter, "students.json");
        }

        private static void BinWork()
        {
            var binFormater = new BinaryFormatter();
            SerializableBin.BinarySerializable(binFormater, "groups.bin", groups);
            SerializableBin.BinaryDesirializable(binFormater, "groups.bin");
        }

        private static void XmlWork()
        {
            var xmlFormatter = new XmlSerializer(typeof(Group[]));
            SerializableXML.XmlSerializable(xmlFormatter, "groups.xml", groups);
            SerializableXML.XmlDesirializable(xmlFormatter, "groups.xml");
        }

        private static void SoapWork()
        {
            var soap = new SoapFormatter();
            SerializableSoap.SoapSerializable(soap, "group.soap", groups);
            SerializableSoap.SoapDesirializable(soap, "group.soap");
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
