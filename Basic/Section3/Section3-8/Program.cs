using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section308
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("季節を入力(1=春 2=夏 3=秋 4=冬):");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("春");
                    break;
                case 2:
                    Console.WriteLine("夏");
                    break;
                case 3:
                    Console.WriteLine("秋");
                    break;
                case 4:
                    Console.WriteLine("冬");
                    break;
                default:
                    Console.WriteLine("無効な入力です");
                    break;
            }
        }
    }
}