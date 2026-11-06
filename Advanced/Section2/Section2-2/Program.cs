namespace Section202
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);

            Console.Write("cの値を入力してください：");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("a * b * c = {0}", Calc.Mul(a, b, c));
        }
    }
}