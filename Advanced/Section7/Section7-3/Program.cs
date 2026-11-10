namespace Section703
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2 };

            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"a[{i}]={a[i]}");
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("配列の範囲を超えています。");
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }
    }
}