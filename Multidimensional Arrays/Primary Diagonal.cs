using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[,] matrix = new int[number, number];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[j, i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
