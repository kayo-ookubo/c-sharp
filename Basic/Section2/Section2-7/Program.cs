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
            const decimal TaxRate = 0.1m;

            Console.Write("価格を入力:");
            decimal price = decimal.Parse(Console.ReadLine());

            decimal total = Math.Floor(price * (1 + TaxRate));

            Console.WriteLine("税込価格:" + total);

        }
    }
}
