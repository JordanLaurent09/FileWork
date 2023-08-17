﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление факториала:");
            Console.WriteLine(RecFactorial(5));
            Console.WriteLine("Возведение числа в степень:");
            Console.WriteLine(Power(5, 2));
        }

        // Рекурсивная функция по вычислению факториала
        static long RecFactorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * RecFactorial(n - 1);
        }

        // Рекурсивная функция по вычислению степени числа

        static long Power(int number, int power)
        {
            if (power == 0) return 1;
            if (power == 1) return number;
            return number * Power(number, power - 1);
        }
    }
}