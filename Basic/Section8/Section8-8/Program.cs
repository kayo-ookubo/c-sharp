using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section808
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;

            for (int i = 1; i <= 10000; i++)
            {
                sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (i == sum)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}