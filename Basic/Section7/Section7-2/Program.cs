using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section702
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoStrings ts = new TwoStrings();

            ts.String1 = "Hello";
            ts.String2 = "World";

            Console.WriteLine($"一つ目の文字列は{ts.String1}");
            Console.WriteLine($"二つ目の文字列は{ts.String2}");
            Console.WriteLine($"二つの文字列を合成したものは{ts.GetConnectedString()}");
        }
    }
}