using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    //Simple Object Acses Protocol не работает со списком (LIST)
    class SerializableSoap
    {
        public static void SoapDesirializable(SoapFormatter soap, string nameFile)
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

        public static void SoapSerializable(SoapFormatter soap, string nameFile, object[] colections)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                soap.Serialize(file, colections);
            }
        }
    }
}
