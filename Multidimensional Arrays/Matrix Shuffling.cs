using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] matrixFill = Console.ReadLine().Split();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrixFill[j];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] parts = command.Split();

                if (parts[0] != "swap" || parts.Length < 5 || parts.Length > 5 || int.Parse(parts[1]) < 0 || 
                   int.Parse(parts[1]) >= matrix.GetLength(0) || int.Parse(parts[2]) < 0 || int.Parse(parts[2]) >= matrix.GetLength(1)
                   || int.Parse(parts[3]) < 0 || int.Parse(parts[3]) >= matrix.GetLength(0) || int.Parse(parts[4]) < 0 || int.Parse(parts[4]) >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }                
                else
                {
                    int row1 = int.Parse(parts[1]);
                    int col1 = int.Parse(parts[2]);
                    int row2 = int.Parse(parts[3]);
                    int col2 = int.Parse(parts[4]);

                    string element = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = element;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
