using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section310
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.Write("文字列を入力:");
            str1 = Console.ReadLine();


            if (str1 == "C#")
            {
                Console.WriteLine("C#言語です");
            }

            else if (str1 == "Java")
            {
                Console.WriteLine("Java言語です");
            }

            else
            {
                Console.WriteLine("その他の言語です");
            }
        }
    }
}