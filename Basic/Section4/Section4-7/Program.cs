using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section407
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数の設定
            Random rnd = new Random();
            Console.WriteLine("10の倍数が出たら終了");

            //無限ループ
            while (true)
            {
                int n = rnd.Next(1, 101);
                Console.WriteLine(n);
                if (n % 10 == 0 )
                {
                    break;
                }
            }
            Console.WriteLine("終了");
        }
    }
}