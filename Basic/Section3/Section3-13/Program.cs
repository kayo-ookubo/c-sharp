using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section313
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力(1=月 2=火 3=水 4=木 5=金 6=土 7=日):");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("月曜日");
                    break;
                case 2:
                    Console.WriteLine("火曜日");
                    break;
                case 3:
                    Console.WriteLine("水曜日");
                    break;
                case 4:
                    Console.WriteLine("木曜日");
                    break;
                case 5:
                    Console.WriteLine("金曜日");
                    break;
                case 6:
                    Console.WriteLine("土曜日");
                    break;
                case 7:
                    Console.WriteLine("日曜日");
                    break;
            }
        }
    }
}