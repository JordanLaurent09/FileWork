using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeArrayFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArray(20, 0, 28);
            PrintArray(array);

            //1. Метод Clear позволяет удалять элементы, входящие в выбранный диапазон номеров индексов массива
            Array.Clear(array, 0, array.Length);
            PrintArray(array);
        }



        // Вспомогательная функция для вывода массива на экран
        static void PrintArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        // Вспомогательная функция для создания нового массива
        static int[] CreateArray(int arrayLength, int lowerLimit, int upperLimit)
        {
            Random random = new Random();
            int[] array = new int[arrayLength];
            for(int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(lowerLimit, upperLimit);
            }

            return array;
        }
    }
}
