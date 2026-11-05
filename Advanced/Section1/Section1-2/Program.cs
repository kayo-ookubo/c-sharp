using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section102
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc1 = new Calc();
            Calc calc2 = new Calc(3, 1);

            calc1.ShowAdd();
            calc2.ShowAdd();
        }
    }
}