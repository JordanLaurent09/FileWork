using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationProject
{
    class Program
    {
        // Первый способ задания перечисления
        enum Days
        {
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Второй способ задания перечисления

        enum Time : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        // Можно оформить инициализацию перечисления

        enum Operation
        {
            Add = 1, // теперь каждый следующий элемент по умолчанию увеличивается на единицу
            Substract,
            Multiply,
            Divide
        }

        // Еще один способ инициализации перечисления

        enum Operations
        {
            Add = 2,
            Sunstract = 4,
            Multiply = 8,
            Divide = 16
        }
        static void Main(string[] args)
        {
            // Каждое перечисление фактически определяет новый тип данных

            Operation op;
            op = Operation.Add;

            Console.WriteLine(op);

            op = Operation.Multiply;
            Console.WriteLine((int)op);
        }
    }
}
