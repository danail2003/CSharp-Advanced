using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, rows];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int primary = 0;
            int secondary = 0;
            int number = 0;
            int counter = 0;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int element = matrix.GetLength(1) - counter;
                    if (i == j)
                    {
                        primary += matrix[i, j];
                    }

                    if (element == j + 1)
                    {
                        number = matrix[i, j];
                        counter++;
                        secondary += number;
                    }
                }
            }

            int diff = Math.Abs(primary - secondary);
            Console.WriteLine(diff);
        }
    }
}
