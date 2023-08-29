using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            while(true)
            {
                Console.Write(path + ">");
                string command = Console.ReadLine();
                string[] commands = command.Split(' ');
                switch(commands[0])
                {
                    case "help":
                        Console.WriteLine("touch-создание файла touch file");
                        Console.WriteLine("copy-копирование файла copy source destination");
                        Console.WriteLine("move-перемещение переименование файла move source destination");
                        Console.WriteLine("delete-удаление файла delete file");
                        break;

                }
            }
        }
    }
}
