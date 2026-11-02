using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section603
{
    class Circle
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double Circumference()
        {
            return 2 * radius * 3.14;
        }

        public double Area()
        {
            return radius * radius * 3.14;
        }
    }
}
