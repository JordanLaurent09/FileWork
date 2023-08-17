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


        struct Geography
        {
            public string country;
            public string city;
        }


        struct PhoneBook
        {
            public string surname;
            public string address;
            public long number;
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

            // Массив из типа Структура
            People[] people = new People[5];
            for(int i = 0; i <people.Length; i++)
            {
                people[i] = new People();
                Console.WriteLine("Добавьте имя студента:");
                people[i].name = Console.ReadLine();
                Console.WriteLine("Добавьте фамилию студента:");
                people[i].surname = Console.ReadLine();
            }

            foreach(People person in people)
            {
                Console.WriteLine($"{person.name} {person.surname}");
            }

            // Создание массива структур типа Geography 
            // и поиск города по некому условию
            Geography[] places = new Geography[5];
            for(int i = 0; i < places.Length; i++)
            {
                places[i] = new Geography();
                Console.WriteLine("Введите название страны:");
                places[i].country = Console.ReadLine();
                Console.WriteLine("Введите название города:");
                places[i].city = Console.ReadLine();
            }

            foreach(Geography place in places)
            {
                if (place.country == "Italy") Console.WriteLine(place.city);
            }

            // Создание массива структур типа PhoneBook
            // и поиск информации по конкретному условию
            PhoneBook[] data = new PhoneBook[5];
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = new PhoneBook();
                Console.WriteLine("Введите фамилию:");
                data[i].surname = Console.ReadLine();
                Console.WriteLine("Введите адрес:");
                data[i].address = Console.ReadLine();
                Console.WriteLine("Введите номер:");
                data[i].number = long.Parse(Console.ReadLine());
            }

            foreach(PhoneBook item in data)
            {
                if (item.number / 1000000 == 3) Console.WriteLine($"Фамилия абонента: {item.surname} и он живет по адресу: {item.address}");
            }
        }
    }
}
