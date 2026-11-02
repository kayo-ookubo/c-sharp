using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section703
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            calc.Number1 = 8;
            calc.Number2 = 9;

            Console.WriteLine($"{calc.Number1} + {calc.Number2} = {calc.Add()}");
            Console.WriteLine($"{calc.Number1} - {calc.Number2} = {calc.Sub()}");
        }
    }
}