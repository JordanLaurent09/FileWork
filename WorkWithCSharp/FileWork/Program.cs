using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string _directory = "";
            string _fileName = "MyFile.txt";
            string _fullPath = "";
            List<string> _data = new List<string>();
            bool _isExit = false;

            string[] _commandList = new string[] { "exit", "remove", "help", "?", "uppercase" };


            _data = ReadFile();

            while (!_isExit)
            {
                PrintData();
                string line = Console.ReadLine();



                if (CheckCommands(line))
                {
                    ExecuteCommand(line);
                }
                else
                {
                    AppendData(line);
                    Console.Clear();
                }

            }

            WriteDataToFile();
            Console.ReadLine();


            void ExecuteCommand(string command)
            {
                switch (command)
                {
                    case "exit":
                        _isExit = true;
                        break;
                    case "remove":
                        RemoveLines();
                        break;
                    case "help":
                        Console.Clear();
                        HelperMethod();
                        break;
                    case "uppercase":
                        UpperCaseLine();
                        break;
                }

            }

            bool CheckCommands(string line)
            {
                line = line.Trim();
                line = line.ToLower();
                return _commandList.Contains(line);
            }

            void AppendData(string data)
            {
                _data.Add(data);
            }

            List<string> ReadFile()
            {
                _directory = Directory.GetCurrentDirectory();
                _directory = new DirectoryInfo(_directory).Parent.Parent.FullName; 
                _fullPath = Path.Combine(_directory, _fileName); 
                return File.ReadAllLines(_fullPath).ToList();
            }

            void PrintData()
            {
                Console.WriteLine("DATA: ");
                for (int i = 0; i < _data.Count; i++)
                {
                    Console.WriteLine(i + 1 + " " + _data[i]);
                }
                //Console.WriteLine(string.Join(Environment.NewLine, _data));
                Console.WriteLine("--------------------");
            }

            void WriteDataToFile()
            {
                File.WriteAllLines(_fullPath, _data); 
                Console.WriteLine("Файл сохранен");
            }

            void HelperMethod()
            {
                Console.WriteLine("Вам доступны следующие команды -\n1.remove - удаление строки (требует ввод номера строки)" +
                    "\n2.exit - завершает выполнение программы и сохраняет изменения в файле");
            }

            void RemoveLines()
            {
                Console.Write("Какую строку удаляем? (номер от нуля): ");
                int lineNumber = int.Parse(Console.ReadLine());
                try
                {
                    _data.RemoveAt(lineNumber);
                }
                catch
                {
                    Console.WriteLine("Не удалось найти строчку, возврат в главное меню");
                }
            }

            void UpperCaseLine()
            {
                Console.WriteLine("Выберите номер желаемой строчки");
                int lineNumber = int.Parse(Console.ReadLine());
                try
                {
                    _data[lineNumber] = _data[lineNumber].ToUpper();
                }
                catch
                {
                    Console.WriteLine("Не удалось найти строчку, возврат в главное меню");
                }
            }
        }
    }
}
