using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section802
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 100; a++)
            {
                for (int b = 1; b <= 100; b++)
                {
                    for (int c = 1; c <= 100; c++)
                    {
                        if (a <= b && a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a}^2 + {b}^2 = {c}^2");
                        }
                    }
                }
            }
        }
    }
}