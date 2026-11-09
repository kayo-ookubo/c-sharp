namespace Section301
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            airplane.Fly();

            Fighter fighter = new Fighter();
            fighter.Fly();
            fighter.Fight();
        }
    }
}