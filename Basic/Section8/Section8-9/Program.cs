using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section809
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Fibo(int n)
            {
                if (n == 0)
                    return 1;
                if (n == 1)
                    return 1;
                return Fibo(n - 1) + Fibo(n - 2);
            }

            for (int i = 0; i < 20;  i++)
            {
                Console.Write(Fibo(i) + " ");
            }
        }
    }
}