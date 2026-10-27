using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section401
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}