namespace Section601
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            Random rnd = new Random();

            while(true)
            {
                int num = rnd.Next(0, 11);

                Console.Write(num + " ");

                if (num == 0)
                {
                    Console.WriteLine();
                    break;
                }

                if (num % 2 == 0)
                {
                    even.Add(num);
                }
                else
                {
                    odd.Add(num);
                }
            }

            Console.WriteLine();
            Console.Write("奇数リスト：");
            foreach (int a in odd)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
            Console.Write("偶数リスト：");
            foreach (int b in even)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }
    }
}