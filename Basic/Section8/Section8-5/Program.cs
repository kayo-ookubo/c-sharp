using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section805
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
