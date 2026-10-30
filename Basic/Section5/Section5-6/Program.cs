using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section506
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

            int max = n.Max();
            int min = n.Min();
            double avg = n.Average();

            Console.WriteLine();
            Console.WriteLine($"最大値：{max}");
            Console.WriteLine($"最小値：{min}");
            Console.WriteLine($"平均値：{avg}");
        }
    }
}

