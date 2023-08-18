using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создание объекта по умолчанию типа "дата-время"
            DateTime dateTime = new DateTime();
            Console.WriteLine($"Значение по умолчанию: {dateTime}");

            Console.WriteLine($"Минимальное значение: {DateTime.MinValue}");

            Console.WriteLine($"Максимальное значение: {DateTime.MaxValue}");

            Console.WriteLine($"Текущее время: {DateTime.Now}");

            // Создание объектов с конкретными заданными параметрами:

            DateTime dateTime1 = new DateTime(2015, 12, 21);

            DateTime dateTime2 = new DateTime(2017, 6, 15, 12, 45, 25);

            Console.WriteLine(dateTime1);
            Console.WriteLine(dateTime2);

            // Различные методы для отображения времени и дат
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Date);
        }
    }
}
