using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31032023
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[20];

            firstArray = FillArray(firstArray.Length);
            secondArray = FillArray(secondArray.Length);

            Console.WriteLine(Join("#", firstArray));
            Console.WriteLine(Join("?", secondArray));



        int[] FillArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = new Random().Next(0, 100);
            }
            return array;
        }

            
        string Join(string separator, int[] array)
        {
            string result = "";

            foreach(int item in array)
            {
                result += item + separator;
            }
            return result;
        }





        }
    }
}
