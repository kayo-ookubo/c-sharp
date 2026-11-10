namespace Section605
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            while(true)
            {
                Console.Write("文字列を入力：");
                string str = Console.ReadLine();

                if (str == "")
                {
                    break;
                }

                words.Add(str);
            }

            // 5文字未満をリストから削除
            words.RemoveAll(s => s.Length < 5);

            Console.WriteLine("入力した文字列：");

            foreach (string s in words)
            {
                 Console.WriteLine(s);
            }
        }
    }
}