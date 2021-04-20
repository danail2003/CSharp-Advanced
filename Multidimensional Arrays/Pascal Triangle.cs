using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[rows][];
            int width = 1;

            for (int i = 0; i < rows; i++)
            {
                pascalTriangle[i] = new long[width];
                long[] currentRow = pascalTriangle[i];
                currentRow[0] = 1;
                currentRow[^1] = 1;
                width++;

                if (currentRow.Length > 2)
                {
                    for (int j = 1; j < currentRow.Length-1; j++)
                    {
                        long[] previousRow = pascalTriangle[i - 1];
                        long previousSum = previousRow[j] + previousRow[j - 1];
                        currentRow[j] = previousSum;
                    }
                }
            }

            foreach (var array in pascalTriangle)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
