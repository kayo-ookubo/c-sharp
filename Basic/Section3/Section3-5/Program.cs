using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section305
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int a = int.Parse(Console.ReadLine());

            if (5 < a && a < 10) // 5より大きく10より小さい場合
            {
                Console.WriteLine("範囲内です。");
            }
        }
    }
}