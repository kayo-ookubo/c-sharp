using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section601
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMax mm = new MinMax();

            int a = 4;
            int b = 2;
            int c = 7;

            Console.WriteLine($"{a}と{b}と{c}のうち、最大のものは{mm.Max(a, b, c)}");
            Console.WriteLine($"{a}と{b}と{c}のうち、最小のものは{mm.Min(a, b, c)}");
        }
    }
}