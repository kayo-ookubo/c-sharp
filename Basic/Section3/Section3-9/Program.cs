using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section309
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.Write("文字列を入力:");
            str1 = Console.ReadLine();


            if (str1 == "yes")
            {
                Console.WriteLine("はい");
            }

            else
            {
                Console.WriteLine("いいえ");
            }
        }
    }
}