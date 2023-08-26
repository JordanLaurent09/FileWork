using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamsWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Чтение данных из файла и их обработка по заданному условию
            using(StreamReader sr = new StreamReader("text.txt"))
            {
                string line;
                while((line = sr.ReadLine())!= null)
                {
                    if(line.StartsWith("T"))
                    {
                        Console.WriteLine(line);
                    }
                    if (line.Length > 30)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
