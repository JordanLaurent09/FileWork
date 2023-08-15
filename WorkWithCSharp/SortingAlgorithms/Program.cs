using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    // Текущий проект содержит в себе основные методы сортировки массивов
    // Current project contains all main sorting algorithms for numeric arrays
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArray(20, 0, 21);
            Console.WriteLine("Исходный неотсортированный массив:");
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("Чтобы выбрать способ сортировки, введите цифру от 1 до 10");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Сортировка пузырьком:");
                    array = BubbleSort(array);
                    PrintArray(array);
                    break;
                case 2:
                    Console.WriteLine("Сортировка выбором:");
                    array = SelectionSort(array);
                    PrintArray(array);
                    break;
                case 3:
                    Console.WriteLine("Сортировка простыми вставками:");
                    array = InsertionSort(array);
                    PrintArray(array);
                    break;
            }
        }

        // Алгоритм сортировки пузырьком
        // Bubble sorting algorithm
        static int[] BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }


        // Алгоритм сортировки выбором
        // Selection sorting algorithm
        static int[] SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int nMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[nMin] > array[j])
                    {
                        nMin = j;
                    }
                }
                if (nMin != i)
                {
                    int temp = array[nMin];
                    array[nMin] = array[i];
                    array[i] = temp;
                }
            }

            return array;
        }


        // Алгоритм сортировки простыми вставками
        // Insertion sorting algorithm

        static int[] InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i - 1] > array[i])
                {
                    int x = array[i];
                    int j = i - 1;

                    while(j >= 0 && array[j] > x)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }

                    array[j + 1] = x;
                }
            }
            return array;
        }


        // Алгоритм сортировки прямыми вставками с барьером
        // Barrier insertion sorting algorithm

        static int[] InsertBarrierSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i - 1] > array[i])
                {
                    array[0] = array[i];
                    int j = i - 1;

                    while(array[j] > array[0])
                    {
                        array[j + 1] = array[j];
                        j--;
                    }

                    array[j + 1] = array[0];
                }
            }

            return array;
        }

        // Алгоритм шейкерной сортировки
        // Shaker sorting algorithm

        static int[] ShakerSort(int[] array)
        {
            for(int i = 0; i < array.Length / 2; i++)
            {
                bool swapFlag = false;
                for(int j = i; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }
                for(int j = array.Length - 2 - i; j > i; j--)
                {
                    if(array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }
                if(!swapFlag)
                {
                    break;
                }
            }
            return array;
        }

        // Вспомогательная функция по созданию случайного массива
        // Adding function using for fast creation of user array
        static int[] CreateArray(int arraySize, int lowestElementValue, int highestElementValue)
        {
            int[] array = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(lowestElementValue, highestElementValue);
            }
            return array;
        }

        // Вспомогательная функция по выводу массивана экран
        // Adding function for print the array
        static void PrintArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write($"{item} ");
            }
        }


        // Вспомогательная функция по перестановке соседних элементов массива
        // Adding function for swap elements of array

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        } 
    }
}
