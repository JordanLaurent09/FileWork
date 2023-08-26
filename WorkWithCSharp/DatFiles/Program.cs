using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запись в .dat файл
            using(BinaryWriter writer = new BinaryWriter(File.Open("binaryFile.dat", FileMode.OpenOrCreate)))
            {
                for(int i = 0; i < 5; i++)
                {
                    writer.Write(int.Parse(Console.ReadLine()));
                }
            }

            // Чтение из .dat файла
            using(BinaryReader reader = new BinaryReader(File.Open("binaryFile.dat", FileMode.Open)))
            {
                for(int i = 0; i < 5; i++)
                {
                    int digit = reader.ReadInt32();
                    Console.WriteLine(digit);
                }
            }
        }
    }
}
