using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section406
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("整数を入力:");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    break;
                }


                Console.WriteLine("入力値:" + n);

            }
        }
    }
}