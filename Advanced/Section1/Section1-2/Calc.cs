using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section102
{
    class Calc
    {
        private int num1;
        private int num2;

        // 引数なし
        public Calc()
        {
            num1 = 1;
            num2 = 2;
        }

        // 引数二つ
        public Calc(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public void ShowAdd()
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}