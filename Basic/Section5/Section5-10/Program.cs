using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section510
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[7];
            Random rnd = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 6);
                Console.Write(n[i] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + ":");

                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] == i)
                    {
                        Console.Write(" ★");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}