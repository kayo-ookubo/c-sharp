using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section312
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a="); a = int.Parse(Console.ReadLine());
            Console.Write("b="); b = int.Parse(Console.ReadLine());
            Console.Write("c="); c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine("最大値=" + a);
            }

            else if (b >= a && b >= c)
            {
                Console.WriteLine("最大値=" + b);
            }

            else
            {
                Console.WriteLine("最大値=" + c);
            }
        }
    }
}