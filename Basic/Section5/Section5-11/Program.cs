using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section511
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

            Console.WriteLine();
            Console.Write("60未満：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < 60)
                {
                    Console.Write(n[i] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("60～80未満：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 60 || 80 < n[i])
                {
                    Console.Write(n[i] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("80以上：");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 80)
                {
                    Console.Write(n[i] + " ");
                }
            }

        }
    }
}
