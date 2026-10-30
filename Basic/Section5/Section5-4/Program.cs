using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section504
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
            Console.Write("50以上の数：");
            for (int i = 0;i < n.Length; i++)
            {
                if (n[i] >= 50)
                {
                    Console.Write(n[i] + " ");
                }
            }

            Console.WriteLine() ;
            Console.Write("50未満の数：");
            for (int i = 0;i <n.Length; i++)
            {
                if (n[i] < 50)
                {
                    Console.Write(n[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}