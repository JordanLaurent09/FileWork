using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDirectoriesPartTwoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение характеристик жестких дисков
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo item in drives)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DriveType);
                if(item.IsReady)
                {
                    Console.WriteLine(item.TotalSize);
                    Console.WriteLine(item.AvailableFreeSpace);
                    Console.WriteLine(item.VolumeLabel);
                }

            }

            // Выявление подкаталогов и папок

            string dirName = "C:\\";
            if(Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach(string item in dirs)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);
                foreach(string item in files)
                {
                    Console.WriteLine(item);
                }
            }

            // Использование функционала класса DirectoryInfo

            var directory = new DirectoryInfo(dirName);
            if(directory.Exists)
            {
                Console.WriteLine("Папки:");
                DirectoryInfo[] folders = directory.GetDirectories();
                foreach(DirectoryInfo item in folders)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Файлы:");
                FileInfo[] files = directory.GetFiles();
                foreach(FileInfo item in files)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
