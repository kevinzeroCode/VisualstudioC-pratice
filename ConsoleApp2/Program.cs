using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string goods;
            int price;
            Console.Write("請輸入品名:");
            goods = Console.ReadLine();
            Console.Write("請輸入單價:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine($"品名 : {goods} 單價 : {price} 紀錄儲存成功");
            Console.Read();
        }
    }
}
