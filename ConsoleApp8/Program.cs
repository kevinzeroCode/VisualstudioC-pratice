using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("題目 : ");
            Console.Write("試問 Visual Studio 可開發下列哪種應用程式 \n 1.視窗程式 2.Web 程式 " +
                "3.裝置應用程式 4.以上皆是\n 請作答 : ");
            string ans = Console.ReadLine();
            switch(ans){
                case "1":
                case "2":
                case "3":
                    Console.WriteLine("答錯了，正確答案是 4 ");
                    break;
                case "4":
                    Console.WriteLine("答對了，真不愧是 .NET達人");
                    break;
                default:
                    Console.WriteLine("沒有此選項");
                    break;
            }
            Console.Read();
        }
    }
}
