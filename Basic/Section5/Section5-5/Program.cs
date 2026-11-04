using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section505
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);
                Console.Write(n[i] + " ");
            }

            Console.WriteLine();
            Console.Write("3の倍数：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 3 == 0)
                {
                    Console.Write(n[i] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("3の倍数でない：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 3 != 0)
                {
                Console.Write(n[i] + " ");
                 }
            }

            Console.WriteLine();
        }
    }
}