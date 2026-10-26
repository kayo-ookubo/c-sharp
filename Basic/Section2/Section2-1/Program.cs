using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Section201
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数型変数を宣言・代入
            int a = 10;
            int b = 3;

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b); // 和
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b); // 差
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b); // 積
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b); // 商
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b); // 余り
        }
    }
}