using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section403
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力:");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            do
            {
                Console.Write("■");
                i++;
            } while (i < n);

            Console.WriteLine();
        }
    }
}