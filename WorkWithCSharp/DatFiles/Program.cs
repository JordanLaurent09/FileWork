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

            // Запись в файл произвольного вещественного массива
            using (BinaryWriter writer = new BinaryWriter(File.Open("arrayFile.dat", FileMode.OpenOrCreate)))
            {
                Random random = new Random();
                double[] array = new double[20];
                for (int i = 0; i < 20; i++)
                {
                    double value = random.NextDouble();
                    Console.WriteLine(value);
                    writer.Write(value);
                }
            }

            // Чтение из файла произвольного вещественного массива
            using(BinaryReader reader = new BinaryReader(File.Open("arrayFile.dat", FileMode.Open)))
            {
                for (int i = 0; i < 20; i++)
                {
                    double value = reader.ReadDouble();
                    Console.WriteLine(value);
                }
            }

            using(BinaryWriter writer = new BinaryWriter(File.Open("EgyptTravel.dat", FileMode.OpenOrCreate)))
            {
                string title = "Egypt";
                string subTitle = "Funny journey";
                int age = 32;
                writer.Write(title);
                writer.Write(subTitle);
                writer.Write(age);
            }

            using(BinaryReader reader = new BinaryReader(File.Open("EgyptTravel.dat", FileMode.Open)))
            {
                while(reader.PeekChar() > -1)
                {
                    string title = reader.ReadString();
                    string subTitle = reader.ReadString();
                    int age = reader.ReadInt32();
                    Console.WriteLine(title);
                    Console.WriteLine(subTitle);
                    Console.WriteLine(age);
                }
            }
        }
    }
}
