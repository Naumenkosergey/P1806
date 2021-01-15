using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerializableTest
{
    class SerializableBin
    {

        public static void BinaryDesirializable(BinaryFormatter binFormater, string nameFile)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                var deSirializeFile = binFormater.Deserialize(file) as Group[];
                if (deSirializeFile != null)
                {
                    foreach (var item in deSirializeFile)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        public static void BinarySerializable(BinaryFormatter binFormater, string nameFile, object[] colections)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                binFormater.Serialize(file, colections);
            }
        }
    }
}
