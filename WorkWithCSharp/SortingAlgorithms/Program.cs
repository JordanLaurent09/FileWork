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
        }

        // Алгоритм сортировки пузырьком
        int[] BubbleSort(int[] array)
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


        // Вспомогательная функция по созданию случайного массива
        // Adding function using for fast creation of user array
        int[] CreateArray(int arraySize, int lowestElementValue, int highestElementValue)
        {
            int[] array = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(lowestElementValue, highestElementValue);
            }
            return array;
        }
    }
}
