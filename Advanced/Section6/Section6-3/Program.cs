namespace Section603
{
    class Program
    {
        static void Main(string[] args)
        {
            // リストを10個作る
            List<int>[] lists = new List<int>[10];

            for (int i = 0; i < 10; i++)
            {
                lists[i] = new List<int>();
            }

            Random rnd = new Random();

            // 乱数を10個作る
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(0, 101);

                Console.Write(num + " ");

                // 一の位を変数に代入
                int ichinokurai = num % 10;

                // 一の位に応じてリストに追加
                lists[ichinokurai].Add(num);
            }

            Console.WriteLine();

            // 10個のリストの中身を表示
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"一の位が{i}：");

                foreach (int n in lists[i])
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}