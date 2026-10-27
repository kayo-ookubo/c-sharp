using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力:");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            while (i < n)
            {
                Console.Write("■");
                i++;
            }
            
            Console.WriteLine();
        }
    }
}