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
            Console.WriteLine("Чтобы выбрать способ сортировки, введите цифру от 1 до 11");
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
                case 4:
                    Console.WriteLine("Шейкерная сортировка:");
                    array = ShakerSort(array);
                    PrintArray(array);
                    break;
                case 5:
                    Console.WriteLine("Сортировка по частям:");
                    array = StoogeSort(array, 0, array.Length - 1);
                    PrintArray(array);
                    break;
                case 6:
                    Console.WriteLine("Блинная сортировка:");
                    array = PancakeSort(array);
                    PrintArray(array);
                    break;
                case 7:
                    Console.WriteLine("Сортировка Шелла:");
                    array = ShellSort(array);
                    PrintArray(array);
                    break;
                case 8:
                    Console.WriteLine("Случайная сортировка:");
                    array = BogoSort(array);
                    PrintArray(array);
                    break;
                case 9:
                    Console.WriteLine("Сортировка слиянием:");
                    array = MergeSortArray(array);
                    PrintArray(array);
                    break;
                case 10:
                    Console.WriteLine("Быстрая сортировка (Сортировка Хоара)");
                    array = QuickSortAlg(array);
                    PrintArray(array);
                    break;
                case 11:
                    Console.WriteLine("Гномья сортировка");
                    array = GnomeSort(array);
                    PrintArray(array);
                    break;
            }
        }

        // Алгоритм сортировки пузырьком
        // Bubble sorting algorithm
        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
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
            for (int i = 0; i < array.Length - 1; i++)
            {
                int nMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[nMin] > array[j])
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
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    int x = array[i];
                    int j = i - 1;

                    while (j >= 0 && array[j] > x)
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
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    array[0] = array[i];
                    int j = i - 1;

                    while (array[j] > array[0])
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
            for (int i = 0; i < array.Length / 2; i++)
            {
                bool swapFlag = false;
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }
                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            return array;
        }

        // Алгоритм сортировки по частям
        // Stooge sorting algorithm

        static int[] StoogeSort(int[] array, int startIndex, int endIndex)
        {
            if (array[startIndex] > array[endIndex])
            {
                Swap(ref array[startIndex], ref array[endIndex]);
            }
            if (endIndex - startIndex > 1)
            {
                int len = (endIndex - startIndex + 1) / 3;
                StoogeSort(array, startIndex, endIndex - len);
                StoogeSort(array, startIndex + len, endIndex);
                StoogeSort(array, startIndex, endIndex - len);
            }
            return array;
        }


        // Алгоритм блинной сортировки
        // Pancake sorting algorithm

        static int[] PancakeSort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int maxIndex = IndexOfMax(array, i);
                if (maxIndex != i)
                {
                    Flip(array, maxIndex);
                    Flip(array, i);
                }
            }
            return array;
        }


        // Алгоритм сортировки Шелла
        // Shell sorting algorithm

        static int[] ShellSort(int[] array)
        {
            int d = array.Length / 2;
            while(d >= 1)
            {
                for (int i = d; i < array.Length; i++)
                {
                    int j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return array;
        }


        // Алгоритм случайной сортировки
        // Bogo sorting algorithm

        static int[] BogoSort(int[] array)
        {
            while(!IsSorted(array))
            {
                array = RandomPermulation(array);
            }
            return array;
        }


        // Алгоритм сортировки слиянием
        // Merge sorting algorithm

        static int[] MergeSortArray(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }


        // Вспомогательная функция для сортировки слиянием
        // Adding function for merge sorting algorithm

        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int left = lowIndex;
            int right = middleIndex + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            int index = 0;
            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] <= array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }
                index++;
            }
            for (int i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (int i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        // Еще одна вспомогательная функция для сортировки слиянием
        // Another one adding function for merge sorting algorithm

        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
            return array;
        }



        // Алгоритм быстрой сортировки (Сортировка Хоара)
        // Quick sorting algorithm

        static int[] QuickSortAlg(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }


        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivot = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivot - 1);
            QuickSort(array, pivot + 1, maxIndex);
            return array;
        }

        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        


        // Алгоритм "гномьей" сортировки
        // Gnome sorting algorithm

        static int[] GnomeSort(int[] array)
        {
            int index = 1;
            int nextIndex = index + 1;
            while(index < array.Length)
            {
                if(array[index - 1] < array[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref array[index - 1], ref array[index]);
                    index--;
                    if(index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
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


        // Adding flip function

        static void Flip(int[] array, int end)
        {
            for (var start = 0; start < end; start++, end--)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
            }
        }

        // Adding function for finding index of max element

        static int IndexOfMax(int[] array, int n)
        {
            int result = 0;
            for(int i = 0; i <= n; i++)
            {
                if (array[i] > array[result]) result = i;
            }
            return result;
        }


        // Вспомогательная функция на проверку упорядоченности элементов (специально для СЛУЧАЙНОЙ сортировки)
        // Adding function to understand whether array is sorted or not (especially for BOGO sorting algorithm)

        static bool IsSorted(int[] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] > array[i + 1]) return false;
            }
            return true;
        }

        // Вспомогательная функция для перемешивания элементов (специально для СЛУЧАЙНОЙ сортировки)
        // Adding function for random permulation of array's elements (especially for BOGO sorting algorithm)

        static int[] RandomPermulation(int[] array)
        {
            Random random = new Random();
            int n = array.Length;
            while(n > 1)
            {
                n--;
                int i = random.Next(n + 1);
                int temp = array[i];
                array[i] = array[n];
                array[n] = temp;
            }
            return array;
        }        
    }
}
