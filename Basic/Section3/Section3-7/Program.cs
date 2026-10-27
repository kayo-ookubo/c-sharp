using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section307
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int a = int.Parse(Console.ReadLine());


            if (a % 2 == 0)
            {
                Console.WriteLine("偶数です");
            }

            else if (a % 2 == 1)
            {
                Console.WriteLine("奇数です");
            }
        }
    }
}