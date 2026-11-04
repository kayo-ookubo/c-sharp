using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section512
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 3];
            int count = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    n[i, j] = count;
                    count++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(n[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
