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

        // Перечисление типа UI

        enum UI : long
        {
            Name,
            Surname,
            ShortName,
            Age,
            Sex
        }

        // Перечисление типа Apple

        enum Apple
        {
            Jonathan,
            GoldenDel,
            RedDel,
            Winsap,
            Cortland,
            McIntosh
        }

        static void Main(string[] args)
        {
            // Каждое перечисление фактически определяет новый тип данных

            Operation op;
            op = Operation.Add;

            Console.WriteLine(op);

            op = Operation.Multiply;
            Console.WriteLine((int)op);


            // Проверка функции MathOperations

            MathOperations(10, 5, Operation.Add);
            MathOperations(11, 5, Operation.Multiply);


            // Работа с перечислением UI

            UI userOne;
            for(userOne = UI.Name; userOne <= UI.Sex; userOne++)
            {
                Console.WriteLine("Элемент: \"{0}\", значение {1}", userOne, (int)userOne);
            }
        }


        // Функция с основными математическими операциями на основе перечислений
        
        static void MathOperations(double x, double y, Operation operation)
        {
            double result = 0;

            switch(operation)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    if (y == 0) result = 0;
                    else result = x / y;
                    break;
            }
            Console.WriteLine("Результат операции равен {0}", result);
        }

    }
}
