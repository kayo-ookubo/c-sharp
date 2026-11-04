using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section501
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[7];
            Random rnd = new Random();

            for ( int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 11);
            }

            foreach ( int i in n)
            {
                Console.Write(i + " ");
            }
        }
    }
}
