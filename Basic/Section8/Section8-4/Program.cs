using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section804
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 1001);

            Console.WriteLine($"発生した乱数は{n}です。");

            if (n < 10)
            {
                Console.WriteLine("1桁です。");
            }

            else if (n < 100)
            {
                Console.WriteLine("2桁です。");
            }

            else if (n < 1000)
            {
                Console.WriteLine("3桁です。");
            }

            else
            {
                Console.WriteLine("4桁です。");
            }
        }
    }
}
