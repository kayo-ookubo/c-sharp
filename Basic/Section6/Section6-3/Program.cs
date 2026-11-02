using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section603
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 4.0;
            Circle circle = new Circle(radius);

            Console.WriteLine($"半径{radius}の円の円周の長さは{circle.Circumference()}");
            Console.WriteLine($"半径{radius}の円の面積は{circle.Area()}");
        }
    }
}



