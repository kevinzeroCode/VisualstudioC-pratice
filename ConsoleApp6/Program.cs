using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, max;
            Console.Write("1. 請輸入第一個數值 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2. 請輸入第二個數值 : ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("3. 請輸入第三個數值 : ");
            n3 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                if(n1 > n3)
                {
                    max = n1;
                }
                else
                {
                    max = n3;
                }
            }
            else
            {
                if (n2 > n3)
                {
                    max = n2;
                }
                else
                {
                    max = n3;
                }
            }
            Console.Write($"{n1}, {n2}, {n3} 三數中最大值為 : {max}");
            Console.Read();
        }
    }
}
