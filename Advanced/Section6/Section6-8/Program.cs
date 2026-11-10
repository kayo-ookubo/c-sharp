namespace Section608
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fruit = new Dictionary<string, string>();
            fruit["apple"] = "りんご";
            fruit["banana"] = "バナナ";
            fruit["orange"] = "オレンジ";
            fruit["grape"] = "ぶどう";

            Console.Write("英単語を入力：");
            string word = Console.ReadLine();

            if (fruit.ContainsKey(word))
            {
                Console.WriteLine(fruit[word]);
            }
            else
            {
                Console.WriteLine("対応なし");
            }
        }
    }
}