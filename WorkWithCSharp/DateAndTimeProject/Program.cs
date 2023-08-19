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

            // Дополнение к способам форматирования дат

            // d - день месяца от 1 до 31
            // dd - день месяца от 1 до 31. Одноразрядное число - в начале ноль
            // ddd - сокращенное название дня недели
            // dddd - полное название дня недели
            // f/ffffffff - представляет собой миллисекунды. Количество f указывает на количество разрядов
            // g - период или эра
            // h - часы в виде от 1 до 12
            // hh - часы, к одноразрядным в начале прибавляется ноль
            // H - часы в виде от 0 до 23
            // HH - то же самое, только одноразрядные дополняются нулем
            // K - часовой пояс
            // m - минуты от 0 до 59
            // mm - одноразрядные минуты дополняются нулем
            // M - месяц от 1 до 12
            // MM - одноразрядный месяц дополняется нулем
            // MMM - сокращенное название месяца
            // MMMM - полное название месяца
            // s - секунды от 0 до 59
            // ss - одноразрядные секунды дополняются нулем
            // t - первые символы в обозначениях АМ и РМ
            // y - год с одной или двумя цифрами
            // yy - одноразрядный год дополняется нулем
            // yyy - год из трех цифр
            // yyyy - год из четырех цифр
            // yyyyy - год из пяти цифр
            // z - смещение в часах относительно времени UTC
            // zz - смещение с одним числом дополняется нулем

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


            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd.MM.yyyy"));
            Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss"));

            // Небольшой код по расчету количества лет между двумя датами

            DateTime d1 = new DateTime(2015, 6, 18);
            DateTime d2 = new DateTime(2021, 11, 24);

            Console.WriteLine((int)d2.Subtract(d1).TotalDays/365);

            // Расчет суммы оплаты за электричество за месяц

            DateTime d3 = new DateTime(2023, 4, 1);
            DateTime d4 = new DateTime(2023, 3, 1);

            int hours = d3.Subtract(d4).Hours;
            int count = int.Parse(Console.ReadLine());
            int pay = int.Parse(Console.ReadLine());
            double sum = ((hours / (24.0 / 6)) * count * pay) + ((hours / (24.0 / 10)) * count * pay * 0.7) +
                ((hours / (24.0 / 8)) * count * pay * 0.4);
            Console.WriteLine(sum);
        }
    }
}
