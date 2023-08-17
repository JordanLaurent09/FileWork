using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresProject
{
    class Program
    {
        struct People
        {
            public string name;
            public string surname;
        }
        static void Main(string[] args)
        {
            // Первый способ инициализации структуры
            People personOne = new People();
            personOne.name = "Andrew";
            personOne.surname = "Klein";
            Console.WriteLine($"{personOne.name} {personOne.surname}");

            // Второй способ инициализации структуры
            People personTwo = new People() { name = "Richard", surname = "Robinson" };
            Console.WriteLine($"{personTwo.name} {personTwo.surname}");
        }
    }
}
