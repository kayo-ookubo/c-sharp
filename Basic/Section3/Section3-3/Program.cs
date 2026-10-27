using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int a = int.Parse(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine("0以上です");
            }
        }
    }
}