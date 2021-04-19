using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = i;
                        colIndex = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[rowIndex, colIndex]} " + $"{matrix[rowIndex, colIndex + 1]} " + $"{matrix[rowIndex, colIndex + 2]}");
            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} " + $"{matrix[rowIndex + 1, colIndex + 1]} " + $"{matrix[rowIndex + 1, colIndex + 2]}");
            Console.WriteLine($"{matrix[rowIndex + 2, colIndex]} " + $"{matrix[rowIndex + 2, colIndex + 1]} " + $"{matrix[rowIndex + 2, colIndex + 2]}");
        }
    }
}
