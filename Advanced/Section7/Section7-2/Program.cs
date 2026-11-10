namespace Section702
{
    class Program
    {
        delegate void Delfunc(int n);

        static void ShowStars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("☆");
            }
            Console.WriteLine();
        }

        static void ShowBoxes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }

        static void ShowPlus(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Delfunc f = ShowStars;
            f += ShowBoxes;
            f += ShowPlus;
            f(4);
        }
    }
}