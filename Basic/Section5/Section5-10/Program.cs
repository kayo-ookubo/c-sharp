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

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write((i + 1) + ":");

                for (int j = 0; j < n[i]; j++)
                {
                    Console.Write(" ★");
                }
                Console.WriteLine();
            }
        }
    }
}