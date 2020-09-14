using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            int sum = 0;
            foreach (var array in matrix)
            {
                sum += array;
            }

            Console.WriteLine(rowsAndCols[0]);
            Console.WriteLine(rowsAndCols[1]);
            Console.WriteLine(sum);
        }
    }
}
