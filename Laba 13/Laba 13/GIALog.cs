using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laba_13
{
    static class GIALog
    {
        public static void AddNote(string utility, string path, string message)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\GIAlogfile.txt", true))
            {
                sw.WriteLine($"{utility}: {path}");
                sw.WriteLine($"{message}");
            }
        }

        public static void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\GIAlogfile.txt"))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine();
                sw.Close();
            }
        }
    }
}
