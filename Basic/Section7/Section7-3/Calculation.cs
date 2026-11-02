using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section703
{
    class Calculation
    {
        // フィールド
        private int number1;
        private int number2;

        //　プロパティ
        public int Number1
        {
            get { return number1; }
            set { number1 = value;}
        }

        public int Number2
        {
            get { return number2; }
            set { number2 = value;}
        }

        // メソッド
        public int Add()
        {
            return number1 + number2;
        }

        public int Sub()
        {
            return number1 - number2;
        }
    }
}