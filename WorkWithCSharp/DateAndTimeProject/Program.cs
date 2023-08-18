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


            // Различные методы по модификациям объектов класса DateTime
            DateTime nowDay = DateTime.Now;
            Console.WriteLine(nowDay.AddDays(3));
            Console.WriteLine(nowDay.AddMonths(5));
            Console.WriteLine(nowDay.AddYears(3));
            Console.WriteLine(nowDay.AddHours(10));
            Console.WriteLine(nowDay.AddMinutes(10));
            Console.WriteLine(nowDay.AddSeconds(490));
            Console.WriteLine(nowDay.Subtract(dateTime1));
            Console.WriteLine(nowDay.AddDays(-7));
            Console.WriteLine(nowDay.ToLocalTime());
            Console.WriteLine(nowDay.ToUniversalTime());
            Console.WriteLine(nowDay.ToLongDateString());
            Console.WriteLine(nowDay.ToShortDateString());
            Console.WriteLine(nowDay.ToLongTimeString());
            Console.WriteLine(nowDay.ToShortTimeString());


            // Способы форматирования дат

            // D - полный формат даты
            // d - краткий формат даты
            // F - полный формат даты и времени
            // f - полный формат даты и краткий времени
            // G - краткий формат даты и полный времени
            // g - краткий формат даты и времени
            // M, m - формат дней месяца
            // O, o - формат обратного преобразования даты и времени
            // R, r - время по Гринвичу
            // s - сортируемый формат даты и времени
            // T - полный формат времени
            // t - краткий формат времени
            // U - полный универсальный формат даты и времени
            // u - краткий универсальный формат даты и времени
            // Y, y - формат года

            Console.WriteLine(nowDay.ToString("D"));
            Console.WriteLine(nowDay.ToString("d"));
            Console.WriteLine(nowDay.ToString("F"));
            Console.WriteLine(nowDay.ToString("f"));
            Console.WriteLine(nowDay.ToString("G"));
            Console.WriteLine(nowDay.ToString("g"));
            Console.WriteLine(nowDay.ToString("M"));
            Console.WriteLine(nowDay.ToString("O"));
            Console.WriteLine(nowDay.ToString("R"));
            Console.WriteLine(nowDay.ToString("s"));
            Console.WriteLine(nowDay.ToString("T"));
            Console.WriteLine(nowDay.ToString("t"));
            Console.WriteLine(nowDay.ToString("U"));
            Console.WriteLine(nowDay.ToString("u"));
            Console.WriteLine(nowDay.ToString("Y"));
            
        }
    }
}
