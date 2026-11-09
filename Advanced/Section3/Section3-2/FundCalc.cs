namespace Section302
{
    class FundCalc
    {
        public int Number1 { get; set;}
        public int Number2 { get; set;}

        public void Add()
        {
            Console.WriteLine($"{Number1} + {Number2} = {Number1 + Number2}");
        }

        public void Sub()
        {
            Console.WriteLine($"{Number1} - {Number2} = {Number1 - Number2}");
        }
    }
}