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

            array = CreateArray(20, 0, 28);
            PrintArray(array);

            //2. Метод Reverse переставляет все элементы массива в обратном порядке
            Array.Reverse(array);
            PrintArray(array);

            array = CreateArray(20, 0, 28);
            PrintArray(array);

            //3. Метод Sort помогает отсортировать элементы массива
            Array.Sort(array);
            PrintArray(array);


            //4. Метод BinarySearch ищет и возвращает индекс искомого числа в предварительно отсортированном массиве;
            // в случае отсутствия данного числа метод возвращает отрицательное значение
            Console.WriteLine(Array.BinarySearch(array, 22));


            array = CreateArray(20, 0, 28);
            PrintArray(array);


            //5. Метод ConstrainedCopy копирует выбранный диапазон элементов из одного массива в другой

            // Для начала создадим дополнительный массив
            int[] arrayTwo = new int[20];

            // Теперь применим метод ConstrainedCopy
            Array.ConstrainedCopy(array, 3, arrayTwo, 3, 4);
            PrintArray(arrayTwo);


            array = CreateArray(20, 0, 28);
            PrintArray(array);

            //6. Метод IndexOf ищет заданное значение внутри массива и возвращает индекс его первого вхождения в массив

            Console.WriteLine(Array.IndexOf(array, 21));
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
