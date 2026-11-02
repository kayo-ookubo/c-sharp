using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section701
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            data.Number = 100;
            data.Comment = "Programming C#";

            Console.WriteLine($"number = {data.Number}");
            Console.WriteLine($"comment = {data.Comment}");
        }
    }
}