//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Linq;
//using System.Xml.Serialization;
//namespace Laba_14_Framework_
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Transformer tr1 = new Transformer("Bumbl4", "ally", 15);
//            Transformer tr2 = new Transformer("BALO", "enemy", 30);
//            Transformer tr3 = new Transformer("Optimus", "ally", 40);
//            Transformer tr4 = new Transformer("Megatron", "enemy", 35);

//            Serialize_Deserialize.Serialize("binTransformer.bin", tr1);
//            Serialize_Deserialize.Serialize("binTransformer.soap", tr2);
//            Serialize_Deserialize.Serialize("binTransformer.xml", tr3);
//            Serialize_Deserialize.Serialize("binTransformer.json", tr4);

//            Serialize_Deserialize.Deserialize("binTransformer.bin");
//            Serialize_Deserialize.Deserialize("binTransformer.soap");
//            Serialize_Deserialize.Deserialize("binTransformer.xml");
//            Serialize_Deserialize.Deserialize("binTransformer.json");

//            Console.WriteLine();
//            List<Transformer> list = new List<Transformer>() { tr1, tr2, tr3, tr4 };
//            using (FileStream fs = new FileStream("List.xml", FileMode.OpenOrCreate))
//            {
//                XmlSerializer xs = new XmlSerializer(typeof(List<Transformer>));
//                xs.Serialize(fs, list);
//                fs.Close();
//                using (FileStream fsd = new FileStream("List.xml", FileMode.Open))
//                {
//                    List<Transformer> transformers = (List<Transformer>)xs.Deserialize(fsd);
//                    transformers.ForEach(x => Console.WriteLine($"Deserialized transformer: {x.Name} {x.Year} {x.Power}"));
//                }
//            }

//            Console.WriteLine();
//            Regex regex = new Regex(@"<Year>(?<B>\w+)</Year><Type>(?<M>\w+)</Type><Power>(?<P>\w+)</Power>");

//            XmlDocument document = new XmlDocument();
//            document.Load("List.xml");
//            XmlElement xmlRoot = document.DocumentElement;
//            XmlNode lamborghini = xmlRoot.SelectSingleNode("descendant::Transformer[Model='urus']");
//            Console.WriteLine($"{regex.Match(lamborghini.OuterXml).Groups["B"].Value} {regex.Match(lamborghini.OuterXml).Groups["M"].Value}");

//            Console.WriteLine();
//            XmlNodeList allTransformers = xmlRoot.SelectNodes("*");
//            foreach (XmlNode i in allTransformers)
//            {
//                Console.WriteLine($"{regex.Match(i.OuterXml).Groups["B"].Value} {regex.Match(i.OuterXml).Groups["M"].Value}");
//            }

//            Console.WriteLine();
//            XDocument students = new XDocument();
//            XElement root = new XElement("Students");
//            XElement student = new XElement("student");
//            XAttribute name = new XAttribute("name", "Alexander");
//            XAttribute surname = new XAttribute("surname", "Petrov");
//            student.Add(name, surname);
//            root.Add(student);

//            student = new XElement("student");
//            name = new XAttribute("name", "Andrew");
//            surname = new XAttribute("surname", "Ivanov");

//            student.Add(name, surname);
//            root.Add(student);
//            students.Add(root);
//            students.Save("Students.xml");

//            var allStudents = root.Elements("student");
//            foreach (var i in allStudents)
//            {
//                if (i.Attribute("name").Value == "Artyom")
//                    Console.WriteLine(i.Attribute("surname").Value);
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Laba_14_Framework_
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer tr1 = new Transformer("Optimus", "ally", 45);
            Transformer tr2 = new Transformer("Bumbl4", "ally", 30);
            Transformer tr3 = new Transformer("Megatron", "enemy", 40);
            Transformer tr4 = new Transformer("Anrew", "enemy", 20);

            CustomSerializer.Serialize("binTransformer.bin", tr1);
            CustomSerializer.Serialize("binTransformer.soap", tr2);
            CustomSerializer.Serialize("binTransformer.xml", tr3);
            CustomSerializer.Serialize("binTransformer.json", tr4);

            CustomSerializer.Deserialize("binTransformer.bin");
            CustomSerializer.Deserialize("binTransformer.soap");
            CustomSerializer.Deserialize("binTransformer.xml");
            CustomSerializer.Deserialize("binTransformer.json");

            Console.WriteLine();
            List<Transformer> list = new List<Transformer>() { tr1, tr2, tr3, tr4 };
            using (FileStream fs = new FileStream("List.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Transformer>));
                xs.Serialize(fs, list);
                fs.Close();
                using (FileStream fsd = new FileStream("List.xml", FileMode.Open))
                {
                    List<Transformer> trs = (List<Transformer>)xs.Deserialize(fsd);
                    trs.ForEach(x => Console.WriteLine($"Deserialized transformer: {x.Name} {x.Type} {x.Power}"));
                }
            }

            Console.WriteLine();
            Regex regex = new Regex(@"<Name>(?<N>\w+)</Name><Type>(?<T>\w+)</Type><Power>(?<P>\w+)</Power>");

            XmlDocument document = new XmlDocument();
            document.Load("List.xml");
            XmlElement xmlRoot = document.DocumentElement;
            //XmlNode op = xmlRoot.SelectSingleNode("descendant::Transformer[Type='enemy']");
            //Console.WriteLine($"{regex.Match(op.OuterXml).Groups["N"].Value} {regex.Match(op.OuterXml).Groups["T"].Value} {regex.Match(op.OuterXml).Groups["P"].Value}");

            Console.WriteLine("All allies in List:");
            XmlNodeList childnodes = xmlRoot.SelectNodes("Transformer[Type='ally']");
            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine($"{regex.Match(n.OuterXml).Groups["N"].Value} {regex.Match(n.OuterXml).Groups["T"].Value} {regex.Match(n.OuterXml).Groups["P"].Value}");
            }
            Console.WriteLine();

            Console.WriteLine("All transformers in List:");
            XmlNodeList transformers = xmlRoot.SelectNodes("*");
            foreach (XmlNode i in transformers)
            {
                Console.WriteLine($"{regex.Match(i.OuterXml).Groups["N"].Value} {regex.Match(i.OuterXml).Groups["T"].Value} {regex.Match(i.OuterXml).Groups["P"].Value}");
            }

            Console.WriteLine();
            XDocument students = new XDocument();
            XElement root = new XElement("Students");
            XElement student = new XElement("student");
            XAttribute name = new XAttribute("name", "Andrew");
            XAttribute surname = new XAttribute("surname", "Petrov");
            student.Add(name, surname);
            root.Add(student);
            name = new XAttribute("name", "Anton");
            surname = new XAttribute("surname", "Ivanov");
            student = new XElement("student");
            student.Add(name, surname);
            root.Add(student);
            students.Add(root);
            students.Save("Students.xml");

            var allStudents = root.Elements("student");
            foreach (var i in allStudents)
            {
                if (i.Attribute("name").Value == "Anton")
                    Console.WriteLine(i.Attribute("surname").Value);
            }


            Console.ReadKey();
        }
    }
}
