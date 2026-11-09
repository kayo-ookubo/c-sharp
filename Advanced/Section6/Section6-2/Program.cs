namespace Section602
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数字を保存するリスト
            List<int> numbers = new List<int>();

            Random rnd = new Random();

            while(true)
            {
                int num = rnd.Next(0, 11);

                Console.Write(num + " ");

                if (num == 0)
                {
                    break;
                }

                // 出た乱数をリストに追加
                numbers.Add(num);
            }

            Console.WriteLine();

            numbers.Reverse();
            Console.Write("逆順で表示：");

            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}