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
            int Max = 0;
            int Min = 0;

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int n = rnd.Next(1, 101);

                if (i == 0 || Max < n) Max = n;
                if (i == 0 || Min > n) Min = n;

                Console.WriteLine(n);
            }

            Console.WriteLine("最大値=:" + Max);
            Console.WriteLine("最小値=:" + Min);
        }
    }
}