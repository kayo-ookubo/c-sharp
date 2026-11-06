namespace Section401
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.ShowName();
            d.Move();
            d.Bark();
            Console.WriteLine("----------");

            Monkey m = new Monkey();
            m.ShowName();
            m.Move();
            m.Bark();
            Console.WriteLine("----------");
        }
    }
}