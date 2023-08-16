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
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            //1. Метод Clear позволяет удалять элементы, входящие в выбранный диапазон номеров индексов массива
            Array.Clear(array, 0, array.Length);
            Console.WriteLine("Результат работы метода Clear:");
            PrintArray(array);

            array = CreateArray(20, 0, 28);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            //2. Метод Reverse переставляет все элементы массива в обратном порядке
            Array.Reverse(array);
            Console.WriteLine("Результат работы метода Reverse:");
            PrintArray(array);

            array = CreateArray(20, 0, 28);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            //3. Метод Sort помогает отсортировать элементы массива
            Array.Sort(array);
            Console.WriteLine("Результат работы метода Sort:");
            PrintArray(array);


            //4. Метод BinarySearch ищет и возвращает индекс искомого числа в предварительно отсортированном массиве;
            // в случае отсутствия данного числа метод возвращает отрицательное значение
            Console.WriteLine("Результат работы метода BinarySearch:");
            Console.WriteLine(Array.BinarySearch(array, 22));


            array = CreateArray(20, 0, 28);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);


            //5. Метод ConstrainedCopy копирует выбранный диапазон элементов из одного массива в другой

            // Для начала создадим дополнительный массив
            int[] arrayTwo = new int[20];

            // Теперь применим метод ConstrainedCopy
            Array.ConstrainedCopy(array, 3, arrayTwo, 3, 4);
            Console.WriteLine("Результат работы метода ConstraintCopy:");
            PrintArray(arrayTwo);


            array = CreateArray(20, 0, 28);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            //6. Метод IndexOf ищет заданное значение внутри массива и возвращает индекс его первого вхождения в массив
            Console.WriteLine("Результат работы метода IndexOf:");
            Console.WriteLine(Array.IndexOf(array, 21));


            //7. Метод LastIndexOf возвращает индекс последнего вхождения искомого числа в массив
            Console.WriteLine("Результат работы метода LastIndexOf:");
            Console.WriteLine(Array.LastIndexOf(array, 20));

            //8. Метод Resize изменяет размер массива до указанной величины
            Array.Resize(ref array, 13);
            Console.WriteLine("Новый размер массива:");
            Console.WriteLine(array.Length);
            Console.WriteLine("Результат работы метода Resize:");
            PrintArray(array);
            
        }



        // Вспомогательная функция для вывода массива на экран
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
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
