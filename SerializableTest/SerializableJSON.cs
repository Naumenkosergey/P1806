using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SerializableTest
{
    //////////////////JSON/////////////////////////////
    ///[DataContract] - атрибут для json, вместо [Serializable]
    /// ПКМ Ссылки ->  NuGet->обзор->System.Runtime.json.Serialization.Json
    /// [DataMember]
    class SerializableJSON
    {
        public static void JsonDesirializable(DataContractJsonSerializer jsonSerializer, string nameFile)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                var deSirializeFile = jsonSerializer.ReadObject(file) as Student[];
                if (deSirializeFile != null)
                {
                    foreach (var item in deSirializeFile)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        public static void JsonSerializable(DataContractJsonSerializer jsonSerializer, string nameFile, object[] colections)
        {
            using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(file, colections);
            }
        }
    }
}
