using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section807
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(1, 1001);

            Console.WriteLine($"発生した乱数は{n}です。");

            // 約数を求める
            Console.Write("約数は");
            for (int i = 1; i <= n; i++)
            {
                if ( n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("です。");
        }
    }
}