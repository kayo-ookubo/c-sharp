using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section409
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int n = rnd.Next(1, 101);

                if (i == 0 || max < n) max = n;
                if (i == 0 || min > n) min = n;

                Console.WriteLine(n);
            }

            Console.WriteLine("最大値=" + max);
            Console.WriteLine("最小値=" + min);
        }
    }
}