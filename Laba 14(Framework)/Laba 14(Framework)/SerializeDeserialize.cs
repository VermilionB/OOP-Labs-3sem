//using System;
//using System.Linq;
//using System.IO;
//using System.Xml.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Runtime.Serialization.Json;

//namespace Laba_14_Framework_
//{
//    [Serializable]
//    static class Serialize_Deserialize
//    {
//        public static void Serialize(string file, Transformer tr)
//        {
//            string format = file.Split('.').Last();
//            switch (format)
//            {
//                case "bin":
//                    BinaryFormatter bf = new BinaryFormatter();
//                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
//                    {
//                        bf.Serialize(fs, tr);
//                    }
//                    break;

//                case "soap":
//                    SoapFormatter sf = new SoapFormatter();
//                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
//                    {
//                        sf.Serialize(fs, tr);
//                    }
//                    break;

//                case "xml":
//                    XmlSerializer xs = new XmlSerializer(typeof(Transformer));
//                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
//                    {
//                        xs.Serialize(fs, tr);
//                    }
//                    break;

//                case "json":
//                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Transformer));
//                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
//                    {
//                        js.WriteObject(fs, tr);
//                    }
//                    break;
//            }
//        }

//        public static void Deserialize(string file)
//        {
//            string format = file.Split('.').Last();
//            switch (format)
//            {
//                case "bin":
//                    BinaryFormatter bf = new BinaryFormatter();
//                    using (FileStream fs = new FileStream(file, FileMode.Open))
//                    {
//                        Transformer tr = (Transformer)bf.Deserialize(fs);
//                        Console.WriteLine($"Deserialized transformer: {tr.Name} {tr.Year} {tr.Power}");
//                    }
//                    break;

//                case "soap":
//                    SoapFormatter sf = new SoapFormatter();
//                    using (FileStream fs = new FileStream(file, FileMode.Open))
//                    {
//                        Transformer tr = (Transformer)sf.Deserialize(fs);
//                        Console.WriteLine($"Deserialized transformer: {tr.Name} {tr.Year} {tr.Power}");
//                    }
//                    break;

//                case "xml":
//                    XmlSerializer xs = new XmlSerializer(typeof(Transformer));
//                    using (FileStream fs = new FileStream(file, FileMode.Open))
//                    {
//                        Transformer tr = (Transformer)xs.Deserialize(fs);
//                        Console.WriteLine($"Deserialized transformer: {tr.Name} {tr.Year} {tr.Power}");
//                    }
//                    break;

//                case "json":
//                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Transformer));
//                    using (FileStream fs = new FileStream(file, FileMode.Open))
//                    {
//                        Transformer tr = (Transformer)js.ReadObject(fs);
//                        Console.WriteLine($"Deserialized transformer: {tr.Name} {tr.Year} {tr.Power}");
//                    }
//                    break;
//            }
//        }
//    }
//}

using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;


namespace Laba_14_Framework_
{
    static class CustomSerializer
    {
        public static void Serialize(string file, Transformer tr)
        {
            string format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        bf.Serialize(fs, tr);
                    }
                    break;

                case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        sf.Serialize(fs, tr);
                    }
                    break;

                case "xml":
                    XmlSerializer xs = new XmlSerializer(typeof(Transformer));
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        xs.Serialize(fs, tr);
                    }
                    break;

                case "json":
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Transformer));
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        js.WriteObject(fs, tr);
                    }
                    break;
            }
        }

        public static void Deserialize(string file)
        {
            string format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Transformer tr = (Transformer)bf.Deserialize(fs);
                        Console.WriteLine($"Deserialized tr: {tr.Name} {tr.Type} {tr.Power}");
                    }
                    break;

                case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Transformer tr = (Transformer)sf.Deserialize(fs);
                        Console.WriteLine($"Deserialized tr: {tr.Name} {tr.Type} {tr.Power}");
                    }
                    break;

                case "xml":
                    XmlSerializer xs = new XmlSerializer(typeof(Transformer));
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Transformer tr = (Transformer)xs.Deserialize(fs);
                        Console.WriteLine($"Deserialized tr: {tr.Name} {tr.Type} {tr.Power}");
                    }
                    break;

                case "json":
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Transformer));
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Transformer tr = (Transformer)js.ReadObject(fs);
                        Console.WriteLine($"Deserialized tr: {tr.Name} {tr.Type} {tr.Power}");
                    }
                    break;
            }
        }
    }
}