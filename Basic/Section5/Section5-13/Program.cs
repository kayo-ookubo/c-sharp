using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section513
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 3];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    n[i, j] = rnd.Next(1, 101);
                    Console.Write(n[i, j] + " ");
                }
                Console.WriteLine();
            }

            int max = n[0, 0];
            int min = n[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (n[i, j] > max)
                    {
                        max = n[i, j];
                    }

                    if (n[i, j] < min)
                    {
                        min = n[i, j];
                    }
                }
            }

            Console.WriteLine($"最大値：{max}");
            Console.WriteLine($"最小値：{min}");
        }
    }
}

