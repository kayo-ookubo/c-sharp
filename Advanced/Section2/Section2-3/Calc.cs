namespace Section203
{
    class Calc
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