using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section806
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1つ目の分子を入力してください：");
            int a = int.Parse(Console.ReadLine());

            Console.Write("1つ目の分母を入力してください：");
            int b = int.Parse(Console.ReadLine());

            Console.Write("2つ目の分子を入力してください：");
            int c = int.Parse(Console.ReadLine());

            Console.Write("2つ目の分母を入力してください：");
            int d = int.Parse(Console.ReadLine());

            int bunshi = a * d + b * c;
            int bunbo = b * d;

            int gcd = Gcd(bunshi, bunbo);

            bunshi = bunshi / gcd;
            bunbo = bunbo / gcd;

            Console.WriteLine($"{a}/{b} + {c}/{d} = {bunshi}/{bunbo}");
        }

        public static int Gcd(int x, int y)
        { 
            while (y != 0)
            {
                var remainder = x % y;
                x = y;
                y = remainder;
            }
            return Math.Abs(x);
        }
    }
}