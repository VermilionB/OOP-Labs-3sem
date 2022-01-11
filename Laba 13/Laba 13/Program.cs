using System;


namespace Laba_13
{
    class Program
    {
        static void Main(string[] args)
        {
            GIALog.Clear();

            GIADiskInfo.FreeSpace("C:\\");
            GIADiskInfo.FileSystemInfo("C:\\");
            GIADiskInfo.DriveFullInfo();

            GIAFileInfo.FullPath(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIALogFile.txt");
            GIAFileInfo.FileInfo(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIALogFile.txt");
            GIAFileInfo.FileTiming(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIALogFile.txt");

            GIADirInfo.FileCount(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13");
            GIADirInfo.CreationTime(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13");
            GIADirInfo.SubDirectoryCount(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13");
            GIADirInfo.ParentDirectory(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13");

            GIAFileManager.CreateNeededDirectories();
            GIAFileManager.InspectDirectoty(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13");
            GIAFileManager.CopyFiles(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13", ".txt");
            GIAFileManager.Archive(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\zip",
                @"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 13\Laba 13\GIAInspect\GIAFiles\disarchive");
        }
    }
}
