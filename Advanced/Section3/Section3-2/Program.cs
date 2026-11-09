namespace Section302
{
    class Program
    {
        static void Main (string[] args)
        {
            NewCalc calc = new NewCalc();

            calc.Number1 = 10;
            calc.Number2 = 2;

            calc.Add();
            calc.Sub();
            calc.Mul();
            calc.Div();
        }
    }
}