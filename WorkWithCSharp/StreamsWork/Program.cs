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
            Console.Write("Enter the text:");
            string text = Console.ReadLine();
            using(StreamReader sr = new StreamReader("text.txt"))
            {
                string line;
                int count = 0;
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
                    string[] mas = line.Split(' ');
                    if (mas.Length >= 4) Console.WriteLine(line);
                    if (line.Contains(text)) Console.WriteLine(line);
                    mas = line.Split('и');
                    if (mas.Length == 6) count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
