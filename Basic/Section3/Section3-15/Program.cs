using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section315
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("年齢を入力:");
            int a = int.Parse(Console.ReadLine());


            if (0 <= a && a <= 12)
            {
                Console.WriteLine("子ども");
            }

            else if (13 <= a && a <= 17)
            {
                Console.WriteLine("中高生");
            }

            else if (18 <= a && a <= 64)
            {
                Console.WriteLine("成人");
            }

            else if (65 <= a )
            {
                Console.WriteLine("高齢者");
            }
        }
    }
}
