namespace Section609
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(1, 11);
                numbers.Add(num);
            }

            Console.Write("数値一覧：");

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        
    }
}