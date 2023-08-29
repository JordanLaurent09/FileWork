using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                    case "touch":
                        FileStream file = File.Create($@"{path}\{commands[1]}");
                        break;
                    case "delete":
                        FileInfo fileDel = new FileInfo($@"{path}\{commands[1]}");
                        if(fileDel.Exists)
                        {
                            fileDel.Delete();
                        }
                        else
                        {
                            Console.WriteLine("Файл не существует");
                        }
                        break;
                    case "copy":
                        FileInfo fileSource = new FileInfo($@"{path}\{commands[1]}");
                        if(fileSource.Exists)
                        {
                            fileSource.CopyTo($@"{path}\{commands[2]}", true);
                        }
                        break;
                    case "move":
                        FileInfo moveSource = new FileInfo($@"{path}\{commands[1]}");
                        if(moveSource.Exists)
                        {
                            moveSource.MoveTo($@"{path}\{commands[2]}");
                        }
                        break;
                    case "dir":
                        DirectoryInfo dir = new DirectoryInfo(path);
                        if(dir.Exists)
                        {
                            foreach(DirectoryInfo item in dir.GetDirectories())
                            {
                                Console.WriteLine(item.Name);
                            }
                            foreach(FileInfo item in dir.GetFiles())
                            {
                                Console.WriteLine(item.Name + " " + item.Length + " " + item.CreationTime);
                            }
                        }
                        break;
                    case "mkdir":
                        DirectoryInfo dirCreate = new DirectoryInfo($@"{path}\{commands[1]}");
                        if(!dirCreate.Exists)
                        {
                            dirCreate.Create();
                        }
                        break;
                    case "deleteDir":
                        DirectoryInfo dirInfo = new DirectoryInfo($@"{path}\{commands[1]}");
                        if(dirInfo.Exists)
                        {
                            dirInfo.Delete(true);
                            Console.WriteLine("Каталог удален");
                        }
                        else
                        {
                            Console.WriteLine("Каталог не существует");
                        }
                        break;
                    case "cd":
                        switch(commands[1])
                        {
                            case "..":
                                DirectoryInfo curInfo = new DirectoryInfo($@"{path}");
                                DirectoryInfo newDir = curInfo.Parent;
                                path = newDir.FullName;
                                break;
                            case "/":
                                curInfo = new DirectoryInfo($@"{path}");
                                DirectoryInfo rootDir = curInfo.Root;
                                path = rootDir.FullName;
                                break;
                            default:
                                curInfo = new DirectoryInfo($@"{path}\{commands[1]}");
                                if(curInfo.Exists)
                                {
                                    path = curInfo.FullName;
                                }
                                else
                                {
                                    Console.WriteLine("Такого каталога не существует");
                                }
                                break;
                        }
                        break;
                }
            }
        }
    }
}
