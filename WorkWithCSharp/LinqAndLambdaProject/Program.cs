using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Некоторые методы Linq

            Console.WriteLine("Введите размер массива");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Random random = new Random();
            for(int i = 0; i <  length; i++)
            {
                array[i] = random.Next(-10, 11);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            //  Использование Linq

            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Average());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
        }
    }
}
