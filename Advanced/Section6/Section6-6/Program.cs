namespace Section606
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int num = rnd.Next(0, 11);
                numbers.Add(num);
            }

            numbers.Remove(2);

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}