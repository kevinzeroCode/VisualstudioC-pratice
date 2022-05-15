using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double netIncome = 0;
            double taxRate = 0;
            double tax = 0;
            int discount = 0;
            int stage = 0;

            Console.Write(" >>>> 請輸入全年綜合所得淨額(元) :");
            netIncome = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (netIncome > 0)
                stage = (netIncome <= 520000 ? 1 : (netIncome <= 1370000 ? 2 :
                        (netIncome <= 2350000 ? 3 : (netIncome <= 4400000 ? 4 :
                        (netIncome <= 10000000 ? 5 : 6)))));
            else
                Console.WriteLine("\n全年綜合所得淨額為負，不用繳稅");

            switch (stage)
            {
                case 1:
                    taxRate = 0.05;
                    discount = 0;
                    tax = netIncome * 0.05;
                    break;
                case 2:
                    taxRate = 0.12;
                    discount = 36400;
                    tax = netIncome * 0.12 - 36400;
                    break;
                case 3:
                    taxRate = 0.2;
                    discount = 130000;
                    tax = netIncome * 0.2 - 130000;
                    break;
                case 4:
                    taxRate = 0.3;
                    discount = 365000;
                    tax = netIncome * 0.3 - 365000;
                    break;
                case 5:
                    taxRate = 0.4;
                    discount = 805000;
                    tax = netIncome * 0.4 - 805000;
                    break;
                case 6:
                    taxRate = 0.45;
                    discount = 1305000;
                    tax = netIncome * 0.45 - 1305000;
                    break;
                default:
                    Console.WriteLine("\n **** 無此級距 ****");
                    break;
            }
            Console.WriteLine($"\n == 1. 綜合所得 : {netIncome:C} 元");
            Console.WriteLine($"\n == 2. 所得稅級距 : 第 {stage} 級");
            Console.WriteLine($"\n == 3. 累進稅率 : {taxRate*100}%");
            Console.WriteLine($"\n == 4. 累計差額 : {discount:C} 元");
            Console.WriteLine($"\n == 5. 應繳稅率 : {tax:C} 元");
            Console.Read();

        }
    }
}
