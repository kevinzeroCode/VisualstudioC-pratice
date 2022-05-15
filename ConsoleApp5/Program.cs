using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("請輸入年齡:");
            age = int.Parse(Console.ReadLine());
            /*
            if (age >=10 && age <=19)
            {
                Console.WriteLine($"你的年齡是{age}，是青少年");
            }
            else
            {
                Console.WriteLine($"你的年齡是{age}，不是青少年");
            }
            Console.Read();
            */

            if(age < 10 || age > 19)
            {
                Console.WriteLine($"你的年齡是{age}，不是青少年");
            }
            else
            {
                Console.WriteLine($"你的年齡是{age}，是青少年");
            }
            Console.Read();
        }
    }
}
