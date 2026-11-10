namespace Section607
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random rnd = new Random();

            while(true)
            {
                int num = rnd.Next(0, 21);

                if (num == 0)
                {
                    break;
                }

                numbers.Add(num);
                numbers.Sort();

            }

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}