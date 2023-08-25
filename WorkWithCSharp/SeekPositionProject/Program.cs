using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SeekPositionProject
{
    class Program
    {
        //Seek() - позволяет управлять положением курсора потока, начиная с которого
        // производится чтение и запись. Имеет 2 параметра - offset (положение курсора)
        // и позиция в файле, описываемая тремя возможными значениями - 
        // SeekOrigin.Begin, SeekOrigin.End, SeekOrigin.Current
        static async void Main(string[] args)
        {
            string text = "This is the TEXT";
            using(FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                fs.Write(buffer, 0, buffer.Length);
            }

            using(FileStream fs = new FileStream("text.txt",FileMode.OpenOrCreate))
            {
                fs.Seek(7, SeekOrigin.Begin);
                byte[] buffer = new byte[10];
                await fs.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine(textFromFile);
            }
        }
    }
}
