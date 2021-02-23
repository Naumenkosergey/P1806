using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace XMLTest
{


    class Program
    {
        static void Main(string[] args)
        {
            //LEction1();




            //XDocument xDocument = new XDocument();
            ////создаем первый элемент
            //XElement sony = new XElement("phone");
            ////создаем атрибут
            //XAttribute sonyNameAttribute = new XAttribute("name", "Sony Z1");
            //XElement sonyCompanyElement = new XElement("company", "Sony");
            //XElement sonyPriceElement = new XElement("price", "4000");
            ////добавляем отрибут и элементы в первый элемент
            //sony.Add(sonyNameAttribute);
            //sony.Add(sonyCompanyElement);
            //sony.Add(sonyPriceElement);

            ////создаем второй элемент
            //XElement galaxy = new XElement("phone");
            ////создаем атрибут
            //XAttribute galaxyNameAttribute = new XAttribute("name", "Samsung Galaxy S7");
            //XElement galaxyCompanyElement = new XElement("company", "Samsung");
            //XElement galaxyPriceElement = new XElement("price", "5000");
            ////добавляем отрибут и элементы в первый элемент
            //galaxy.Add(galaxyNameAttribute);
            //galaxy.Add(galaxyCompanyElement);
            //galaxy.Add(galaxyPriceElement);
            ////создаем корневой элемент
            //XElement phones = new XElement("phones");
            //phones.Add(sony);
            //phones.Add(galaxy);
            ////добавляем корневой элемент
            //xDocument.Add(phones);
            //xDocument.Save("phones.xml");

            //XDocument xDocument = new XDocument(new XElement("phones",
            //    new XElement("phone",
            //        new XAttribute("name", "Sony Z1"),
            //        new XElement("company", "Sony"),
            //        new XElement("price", "4000")),
            //    new XElement("phone",
            //        new XAttribute("name", "Samsung Galaxy S7"),
            //        new XElement("company", "Samsung"),
            //        new XElement("price", "5000"))));
            //xDocument.Save("phones2.xml");


            //XDocument xDocument = XDocument.Load("phones2.xml");
            //foreach (XElement phone in xDocument.Element("phones").Elements("phone"))
            //{
            //    XAttribute nameAttribute = phone.Attribute("name");
            //    XElement companyElement = phone.Element("company");
            //    XElement priceElement = phone.Element("price");

            //    if (nameAttribute != null && companyElement != null && priceElement != null)
            //    {
            //        Console.WriteLine($"Смартфон: {nameAttribute.Value}");
            //        Console.WriteLine($"Компания: {companyElement.Value}");
            //        Console.WriteLine($"Цена: {priceElement.Value}");
            //    }
            //    Console.WriteLine();
            //}

            //XDocument xDocument = XDocument.Load("phones2.xml");
            //var items = from element in xDocument.Element("phones").Elements("phone")
            //            where element.Element("company").Value == "Samsung"
            //            select new Phone
            //            {
            //                Name = element.Attribute("name").Value,
            //                Price = element.Element("price").Value
            //            };

            //foreach (var item in items)
            //    Console.WriteLine($"{item.Name} - {item.Price}");

            //XDocument xDocument = XDocument.Load("phones2.xml");
            //XElement root = xDocument.Element("phones");
            //foreach (var element in root.Elements("phone").ToList())
            //{
            //    if (element.Attribute("name").Value == "Samsung Galaxy S7")
            //    {
            //        element.Attribute("name").Value = "Samsung Galaxy M31";
            //        element.Element("price").Value = "1500";
            //    }
            //    else if (element.Element("company").Value == "Sony")
            //        element.Remove();
            //}
            //root.Add(new XElement("phone",
            //            new XAttribute("name", "Nokia lumia 930"),
            //            new XElement("company", "Nokia"),
            //            new XElement("price", 950)));
            //xDocument.Save("phones2.xml");
            //Console.WriteLine(xDocument);


            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            foreach (string s in selectedTeams)
                Console.WriteLine(s);






        }

        private static void LEction1()
        {
            ReadXml();
            Console.ReadLine();
            AddElement();
            // ReadXml();
            Console.WriteLine("Добавили Марка");
            // RemoveElement();
            //Console.WriteLine("Удалили Билла");
            ReadXml();

            UseXPath();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            AllNodesUser();
        }


        private static void AllNodesUser()
        {
            XmlDocument document = new XmlDocument();
            document.Load("XMLFile.xml");

            XmlElement root = document.DocumentElement;
            XmlNodeList childNodes = root.SelectNodes("user");
            foreach (XmlNode element in childNodes)
                Console.WriteLine(element.SelectSingleNode("@name").Value);
        }

        private static void UseXPath()
        {
            XmlDocument document = new XmlDocument();
            document.Load("XMLFile.xml");

            XmlElement root = document.DocumentElement;

            var childNodes = root.SelectNodes("*");
            foreach (XmlNode element in childNodes)
                Console.WriteLine(element.OuterXml);
        }

        private static void RemoveElement()
        {
            XmlDocument document = new XmlDocument();
            document.Load("XMLFile.xml");

            XmlElement root = document.DocumentElement;

            XmlNode firstNode = root.FirstChild;
            root.RemoveChild(firstNode);
            document.Save("XMLFile.xml");
        }

        private static void AddElement()
        {
            XmlDocument document = new XmlDocument();
            document.Load("XMLFile.xml");

            XmlElement root = document.DocumentElement;
            XmlElement user = document.CreateElement("user");
            XmlAttribute attributeName = document.CreateAttribute("name");
            XmlElement company = document.CreateElement("company");
            XmlElement age = document.CreateElement("age");

            XmlText nameText = document.CreateTextNode("Марк Цукерберг");
            XmlText companyText = document.CreateTextNode("The Facebook");
            XmlText ageText = document.CreateTextNode("25");

            attributeName.AppendChild(nameText);
            company.AppendChild(companyText);
            age.AppendChild(ageText);

            user.Attributes.Append(attributeName);
            user.AppendChild(company);
            user.AppendChild(age);

            root.AppendChild(user);
            document.Save("XMLFile.xml");


        }

        private static void ReadXml()
        {
            XmlDocument document = new XmlDocument();
            document.Load("XMLFile.xml");
            //получение корневого элемента
            XmlElement root = document.DocumentElement;
            //обход всех узлов в корневом элементе
            foreach (XmlNode node in root)
            {
                if (node.Attributes.Count > 0)//получение атрибута name
                {
                    XmlNode attribute = node.Attributes.GetNamedItem("name");
                    if (attribute != null)
                    {
                        Console.WriteLine(attribute.Value);
                    }
                }
                //обход всех дочерних элементов
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "company")//если узел(элемент) company
                    {
                        Console.WriteLine($"Компания: {childNode.InnerText}");
                    }

                    if (childNode.Name == "age") //если узел(элемент) age
                    {
                        Console.WriteLine($"Возраст: {childNode.InnerText}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
