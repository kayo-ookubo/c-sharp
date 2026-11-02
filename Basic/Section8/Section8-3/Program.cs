using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section803
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力：");
            int n = int.Parse(Console.ReadLine());

            int ans = 1;

            for (int i = 1; i <= n; i++)
            {
                ans = ans * i;
            }
            Console.WriteLine($"{n}!={ans}");
        }
    }
}

