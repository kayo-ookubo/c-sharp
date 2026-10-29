using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section311
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int a = int.Parse(Console.ReadLine());


            if (0 <= a && a <= 100)
            {
                Console.WriteLine("有効な範囲です");
            }

            else 
            {
                Console.WriteLine("範囲外です");
            }
        }
    }
}