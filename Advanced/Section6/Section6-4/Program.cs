namespace Section604
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            while (true)
            {
                Console.Write("文字列を入力：");
                string str = Console.ReadLine();

                // 空文字なら終了
                if (string.IsNullOrEmpty(str))
                {
                    break;
                }

                words.Add(str);
            }

            Console.WriteLine("入力した文字列：");

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}