using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba_8
{
    class FileStream
    {
        public static void WriteToFile(Collection<string> collection)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 8\Laba 8\outfile.txt"))
            {
                foreach (var el in collection)
                {
                    sw.Write(el);
                    if (el != collection.list[collection.GetSize() - 1])
                    {
                        sw.Write("-->");
                    }
                }
            }
        }

        public static void ReadFile(ref Collection<string> collection)
        {
            using (StreamReader sw = new StreamReader(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 8\Laba 8\outfile.txt"))
            {
                string[] items = sw.ReadToEnd().Split(" --> ");
                foreach (string item in items)
                {
                    collection.Add(item);
                }
            }

        }
    }
}
