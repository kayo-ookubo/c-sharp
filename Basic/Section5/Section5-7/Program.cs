using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section507
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);
                Console.Write(n[i] + " ");
            }

            int total = n.Sum();
            double avg = n.Average();

            Console.WriteLine();
            Console.WriteLine($"合計：{total}");
            Console.WriteLine($"平均：{avg}");

            Console.WriteLine();
            Console.Write("平均以上：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= avg)
                {
                    Console.Write(n[i] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("平均未満：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < avg)
                { 
                Console.Write(n[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}