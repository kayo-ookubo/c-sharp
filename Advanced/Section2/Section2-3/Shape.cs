namespace Section203
{
    class Shape
    {
        public static void Square(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}