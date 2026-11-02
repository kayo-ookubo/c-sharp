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
            double ans1 = calc.Add(a, b);
            double ans2 = calc.Sub(a, b);
            double ans3 = calc.Mul(a, b);
            double ans4 = calc.Div(a, b);

            Console.WriteLine($"{a} + {b} = {ans1:F1}");
            Console.WriteLine($"{a} - {b} = {ans2:F1}");
            Console.WriteLine($"{a} * {b} = {ans3:F2}");
            Console.WriteLine($"{a} / {b} = {ans4:F14}");
        }
    }
}