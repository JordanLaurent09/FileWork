using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsAndFilesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Синхронные потоки
            // Чтение из файла
            FileStream stream = null;
            try
            {
                stream = new FileStream("File.txt", FileMode.Open);
                byte[] buffer = new byte[1024];
                UTF8Encoding text = new UTF8Encoding(true);

                while(stream.Read(buffer, 0, buffer.Length) > 0)
                {
                    Console.WriteLine(text.GetString(buffer));
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
