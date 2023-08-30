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


            // Lambda expressions

            // Even numbers
            int[] evens = array.Where(i => i % 2 == 0).ToArray();
            foreach(int item in evens)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Square roots of array's elements
            double[] roots = array.Select(i => Math.Sqrt(i)).ToArray();
            foreach(double item in roots)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Numbers contains in even indexes
            int[] arrayResult = array.Where((s, i) => i % 2 == 0).ToArray();
            foreach (double item in arrayResult)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Calculation element's squares sum
            int sum = array.Select(i => i * i).Sum();
            Console.WriteLine(sum);
        }
    }
}
