using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultPath = "C:\\";
            PrintDirectory(new DirectoryInfo(defaultPath), "", true);
        }

        public static void PrintDirectory(DirectoryInfo directory, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            if(lastDirectory)
            {
                Console.Write("|___");
                indent += " ";
            }
            else
            {
                Console.Write("|---");
                indent += "| ";
            }
            Console.WriteLine(directory.Name);

            DirectoryInfo[] subDirectories = directory.GetDirectories();

            for (int i = 0; i < subDirectories.Length; i++)
            {
                PrintDirectory(subDirectories[i], indent, i == subDirectories.Length - 1);
            }
        }
    }
}
