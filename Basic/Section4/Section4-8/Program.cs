using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section408
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int n = rnd.Next(1, 101);
                Console.WriteLine(n);
            }
        }
    }
}