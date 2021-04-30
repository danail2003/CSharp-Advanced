using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    char symbol = matrix[i, j];
                    if(symbol==matrix[i + 1, j] && symbol==matrix[i, j + 1] && symbol==matrix[i + 1,j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
