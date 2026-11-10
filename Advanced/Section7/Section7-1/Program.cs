namespace Section701
{
    class Program
    {
        delegate void Delfunc();

        static void Func1()
        {
            Console.WriteLine("Func1");
        }

        static void Func2()
        {
            Console.WriteLine("Func2");
        }

        static void Main(string[] args)
        {
            Delfunc df = Func2;

            df();
        }
    }
}