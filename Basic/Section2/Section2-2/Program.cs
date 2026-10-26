using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section202
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 3;
            Console.WriteLine("a={0} b={1}", a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
        }
    }
}