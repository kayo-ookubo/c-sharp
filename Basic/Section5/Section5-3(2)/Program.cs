using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section501
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int even = 0;
            int odd = 0;
            Random rnd = new Random();
            // 配列に乱数を代入
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 11);
            }
            //配列の値を表示
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");

                //偶数と奇数をカウント
                if (n[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("偶数の個数:" + even);
            Console.WriteLine("奇数の個数:" + odd);
        }
    }
}
