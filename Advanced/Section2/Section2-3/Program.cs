namespace Section203
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int rows = rnd.Next(1, 11);
            int cols = rnd.Next(1, 11);

            Console.WriteLine($"縦：{rows} 横：{cols}");

            Calc.Square(rows, cols);
        }
    }
}