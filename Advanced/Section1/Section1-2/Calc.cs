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
        public Calc(): this(1, 2)
        {
        }

        // 引数二つ
        public Calc(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }

        public void ShowAdd()
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}