using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laba_13
{
    static class GIAFileInfo
    {
        public static void FullPath(string path)
        {
            FileInfo file = new FileInfo(path);

            Console.WriteLine($"Полный путь к файлу {file.Name}: {file.FullName}");
            Console.WriteLine();

            GIALog.AddNote("GIAFileInfo", file.Name, "Определён полный путь к файлу.\n");
        }

        public static void FileInfo(string path)
        {
            FileInfo file = new FileInfo(path);

            Console.WriteLine($"Имя файла: {file.Name}");
            Console.WriteLine($"Размер: {Math.Round(file.Length / Math.Pow(10, 3), 2)}Кб");
            Console.WriteLine($"Расширение: {file.Extension}");
            Console.WriteLine();

            GIALog.AddNote("GIAFileInfo", file.Name, "Выведена базовая информация о файле.\n");
        }

        public static void FileTiming(string path)
        {
            FileInfo file = new FileInfo(path);

            Console.WriteLine($"Время создания файла {file.Name}: {file.CreationTime}");
            Console.WriteLine($"Время редактирования файла {file.Name}: {file.LastWriteTime}");
            Console.WriteLine();

            GIALog.AddNote("GIAFileInfo", file.Name, "Определены тайминги файла.\n");
        }
    }
}
