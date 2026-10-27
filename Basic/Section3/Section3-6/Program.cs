using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section306
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a="); a = int.Parse(Console.ReadLine());
            Console.Write("b="); b = int.Parse(Console.ReadLine());


            if (a == b)
            {
                Console.WriteLine("aとbは等しいです");
            }

            else if (a > b)
            {
                Console.WriteLine("aはbより大きいです");
            }

            else if (a < b)
            {
                Console.WriteLine("aはbより小さいです");
            }
        }
    }
}