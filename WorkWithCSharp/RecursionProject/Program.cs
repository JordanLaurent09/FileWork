using System;
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
            Console.WriteLine(RecFactorial(5));
        }

        // Рекурсивная функция по вычислению факториала
        static long RecFactorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * RecFactorial(n - 1);
        }
    }
}
