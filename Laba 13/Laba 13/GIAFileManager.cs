using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Laba_13
{
    static class GIAFileManager
    {
        public static void CreateNeededDirectories()
        {
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect");
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAFiles");
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIAFiles");
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\disarchive");
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\zip");
            File.Create(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\zip\zip.txt").Close();
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIAFiles\disarchive");
        }
        public static void InspectDirectoty(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            File.Create(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIADirInfo.txt").Close();

            using (StreamWriter sw = new StreamWriter(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIADirInfo.txt"))
            {
                sw.WriteLine("|Directories|");
                foreach (DirectoryInfo dir in directory.GetDirectories())
                    sw.WriteLine(dir.Name);

                sw.WriteLine();

                sw.WriteLine("|Files|");
                foreach (FileInfo file in directory.GetFiles())
                    sw.WriteLine(file.Name);
            }

            File.Copy(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIADirInfo.txt", @"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIADirInfoRenamed.txt", true);
            File.Delete(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIADirInfo.txt");
        }

        public static void CopyFiles(string path, string extension)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Directory.CreateDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAFiles");

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Extension == extension)
                    file.CopyTo($@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAFiles\{file.Name}", true);
            }

            Directory.Delete(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIAFiles\", true);
            Directory.Move(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAFiles", @"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIAFiles\");
        }

        public static void Archive(string pathFrom, string pathTo)
        {
            if (!File.Exists($@"{pathFrom}.zip"))
                ZipFile.CreateFromDirectory(pathFrom, $@"{pathFrom}.zip");

            ZipFile.ExtractToDirectory($@"{pathFrom}.zip", pathTo, true);
        }
    }
}
