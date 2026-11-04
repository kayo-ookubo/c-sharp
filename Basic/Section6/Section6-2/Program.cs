using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section602
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            double a = 4.1;
            double b = 2.3;
            double add = calc.Add(a, b);
            double sub = calc.Sub(a, b);
            double mul = calc.Mul(a, b);
            double div = calc.Div(a, b);

            Console.WriteLine($"{a} + {b} = {add:F1}");
            Console.WriteLine($"{a} - {b} = {sub:F1}");
            Console.WriteLine($"{a} * {b} = {mul:F2}");
            Console.WriteLine($"{a} / {b} = {div:F14}");
        }
    }
}