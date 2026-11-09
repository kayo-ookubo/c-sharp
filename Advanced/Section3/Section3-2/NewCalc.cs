namespace Section302
{
    class NewCalc : FundCalc
    {
        public void Mul()
        {
            Console.WriteLine($"{Number1} * {Number2} = {Number1 * Number2}");
        }

        public void Div()
        {
            Console.WriteLine($"{Number1} / {Number2} = {Number1 / Number2}");
        }
    }
}