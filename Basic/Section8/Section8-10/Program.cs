using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section810
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Random rand = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rand.Next(1, 100);
            }

            Console.Write("並び変え前：");

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }

            Console.WriteLine();

            // 選択ソート（昇順）
            for (int i = 0; i < n.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[j] < n[min])
                    {
                        min = j;
                    }
                }

                int temp = n[i];
                n[i] = n[min];
                n[min] = temp;
            }

            Console.Write("並び替え後：");

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
        }
    }
}