using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section508
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            int positive = 0;
            int negative = 0;
            int zero = 0;

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write((i + 1) + "番目の整数を入力：");
                n[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > 0)
                {
                    positive++;
                }
                else if (n[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine($"正の数：{positive}");
            Console.WriteLine($"負の数：{negative}");
            Console.WriteLine($"ゼロの数：{zero}");
        }
    }
}