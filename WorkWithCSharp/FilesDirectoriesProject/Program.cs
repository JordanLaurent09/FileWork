using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDirectoriesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Файлы

            // Данные 2 адреса означают, что файлы располагаются на одну папку выше папки debug, т.е. в папке bin
            string path = @"..\text.txt";
            string newPath = @"..\newtext.txt";

            // Данные 3 адреса означают, что файл находится в папке debug (корневая папка проекта) 
            string movePath = @"text.txt";

            string destPath = @"dtext.txt";
            string resPath = @"rtext.txt";

            FileInfo fileInfo = new FileInfo(path);
            FileInfo newInfo = new FileInfo(movePath);

            if (newInfo.Exists)
            {
                Console.WriteLine(newInfo.Name);
                Console.WriteLine(newInfo.CreationTime);
                Console.WriteLine(newInfo.Length);
                Console.WriteLine(newInfo.FullName);
                Console.WriteLine(newInfo.Directory);
                Console.WriteLine(newInfo.Attributes);
                Console.WriteLine(newInfo.DirectoryName);
            }

            // Копирование файла по новому пути 
            fileInfo.CopyTo(newPath, true);

            // Перемещение файла по новому пути
            fileInfo.MoveTo(movePath);

            // Еще один способ перемещения файлов
            newInfo.Replace(destPath, resPath);

            // Удаление файла
            newInfo.Delete();

        }
    }
}
