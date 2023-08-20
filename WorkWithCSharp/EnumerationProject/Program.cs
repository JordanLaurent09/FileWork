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
        static void Main(string[] args)
        {
        }
    }
}
