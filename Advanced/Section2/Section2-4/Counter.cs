namespace Section204
{
    class Counter
    {
        private static int totalCount = 0;

        public static int TotalCount
        {
            get {  return totalCount; }
        }

        public void Increment()
        {
            totalCount++;
        }

    }
}