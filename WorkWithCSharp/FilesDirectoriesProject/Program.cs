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
            string path = @"..\text.txt";
            string newPath = @"..\newtext.txt";
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

        }
    }
}
