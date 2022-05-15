using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pwd = "";
            int count = 0;
            for (count = 1;count <= 3; count++)
            {
                Console.Write("\n>>>> 請輸入密碼 (四個字元)");
                pwd = Console.ReadLine();

                if (pwd == "star")
                    break;
                else
                    Console.WriteLine($"\n Sorry! 密碼錯誤{count}次，請重新輸入");
                Console.WriteLine();
            }
            if (pwd == "star")
                Console.WriteLine("\n  ==== 登入成功，歡迎進入本系統");
            else
                Console.WriteLine("\n **** 非法進入!!!!");
            Console.Read();
        }
    }
}
