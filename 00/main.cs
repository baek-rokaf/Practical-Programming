using System;


namespace Prac
{
    class Program
    {
        static void Main(string[] arg)
        {
            int[,] table = new int[9, 9];

            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    table[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{(i + 2),2}*{j + 1,-2}={table[i, j],-3}");
                }
                Console.WriteLine("");
            }
        }
    }
}
