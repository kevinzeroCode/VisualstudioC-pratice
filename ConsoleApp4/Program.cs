using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        enum WeekDays : int
        {
            Monday = 1,
            Tuesday = 2,
            Wendesday  =3,
            Thursday = 4,
            Friday  = 5,
            Saturday = 6,
            Sunday = 7
        };
        static void Main(string[] args)
        {
            Console.WriteLine($"星期三列舉常數值:{(int)WeekDays.Wendesday}");
            Console.WriteLine($"星期五列舉常數值:{(int)WeekDays.Friday}");
            Console.Read();
        }
    }
}
