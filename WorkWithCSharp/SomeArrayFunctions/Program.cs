﻿using System;
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
            
        }


        static void PrintArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

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