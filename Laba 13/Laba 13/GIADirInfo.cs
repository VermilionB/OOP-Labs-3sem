using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba_13
{
    static class GIADirInfo
    {
        public static void FileCount(string path)
        {
            Console.WriteLine($"Количество файлов в директория {path}: {Directory.GetFiles(path).Length}");
            Console.WriteLine();

            GIALog.AddNote("GIADirInfo", path, "Определено количество файлов в директория.\n");
        }

        public static void CreationTime(string path)
        {
            Console.WriteLine($"Время создания директория {path}: {Directory.GetCreationTime(path)}");
            Console.WriteLine();

            GIALog.AddNote("GIADirInfo", path, "Определено время создания дриектория.\n");
        }

        public static void SubDirectoryCount(string path)
        {
            Console.WriteLine($"Количество подкаталогов директория {path}: {Directory.GetDirectories(path).Length}");
            Console.WriteLine();

            GIALog.AddNote("GIADirInfo", path, "Определено количество поддиректориев директория.\n");
        }

        public static void ParentDirectory(string path)
        {
            Console.WriteLine($"Родительский путь каталога {path}: {Directory.GetParent(path)}");
            Console.WriteLine();

            GIALog.AddNote("GIADirInfo", path, "Определен родительский путь директория.\n");
        }
    }
}
