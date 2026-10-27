using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数aを入力:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("整数bを入力");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }
        }
    }
}