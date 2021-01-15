using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializableTest
{
    /////////////XML Serializable////////////////////
    ////////класс обязатльно public//////////
    ///private не берет////////////
    class SerializableXML
    {
        public static void XmlDesirializable(XmlSerializer xmlSerializer, string nameFile)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                var deSirializeFile = xmlSerializer.Deserialize(file) as Group[];
                if (deSirializeFile != null)
                {
                    foreach (var item in deSirializeFile)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        public static void XmlSerializable(XmlSerializer xmlSerializer, string nameFile, object[] colections)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, colections);
            }
        }
    }
}
