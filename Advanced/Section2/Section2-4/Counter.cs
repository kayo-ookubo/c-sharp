namespace Section204
{
    class Counter
    {
        public static int totalCount = 0;

        public static int TotalCount
        {
            get {  return totalCount; }
        }

        public static void Count()
        {
            totalCount++;
            Console.WriteLine($"トータルカウント数：{TotalCount}");
        }

    }
}