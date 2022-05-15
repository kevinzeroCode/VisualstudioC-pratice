using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.以貨幣方式 Clc 顯示資料，以 NT$ 開頭 ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0}/{1}/{2}", 1234, -1234, 123.4);
            Console.WriteLine($"{5,0:c}   {-5,0:c3}\n{-5,15:c3}\n{-5,-15:c3}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("2.以十進位方式 D|d 顯示資料，空白處補零 ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0,0:d5}",25);
            Console.WriteLine("{0,10:d5}",25);
            Console.WriteLine("{0,-10:d5}",-25);
            Console.Read();
        }
    }
}
