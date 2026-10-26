using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section207
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tax = 0.1;

            int price;
            Console.Write("価格を入力:");

            price = int.Parse(Console.ReadLine());

            int total = (int)(price * (1 + tax));

            Console.WriteLine("税込価格:" + total);

        }
    }
}
