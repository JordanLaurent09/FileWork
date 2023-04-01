using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string _directory = Directory.GetCurrentDirectory();
            Console.WriteLine(_directory);
            string _fileAddressFirstWay = Directory.GetParent(_directory).Parent.Parent.FullName;
            Console.WriteLine(_fileAddressFirstWay);
            string _fileAddressSecondWay = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName;
            Console.WriteLine(_fileAddressSecondWay);
        }
    }
}
