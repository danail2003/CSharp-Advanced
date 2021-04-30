using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int square = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (square > maxSum)
                    {
                        maxSum = square;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
