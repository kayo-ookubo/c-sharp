using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int a = int.Parse(Console.ReadLine());

            if ( a > 0 )
            {
                Console.WriteLine("正の数です。");
            }

            else if ( a < 0 )
            {
                Console.WriteLine("負の数です。");
            }

            else
            {
                Console.WriteLine("ゼロです。");
            }
        }
    }
}