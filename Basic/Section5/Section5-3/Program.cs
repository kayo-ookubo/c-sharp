using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section503
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 11);
                Console.Write(n[i] + " ");
            }

            Console.WriteLine();

            int even = n.Count(x => x % 2 == 0);
            int odd = n.Count(x => x % 2 != 0);

            Console.WriteLine("偶数の個数:" + even);
            Console.WriteLine("奇数の個数:" + odd);
        }
    }
}
