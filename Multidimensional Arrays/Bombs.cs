using System;
using System.Linq;
using System.Collections.Generic;

namespace Bombs
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int rowCoordinate = 0;
            int columnCoordinate = 0;
            int bomb = 0;
            int aliveCells = 0;
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            List<string> coordinates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (coordinates.Count != 0)
            {
                List<int> token = coordinates[0].Split(",").Select(int.Parse).ToList();
                rowCoordinate = token[0];
                columnCoordinate = token[1];
                bomb = matrix[rowCoordinate, columnCoordinate];

                if(rowCoordinate >= 0 && rowCoordinate < matrix.GetLength(0) && columnCoordinate >= 0 && columnCoordinate < matrix.GetLength(1) && matrix[rowCoordinate, columnCoordinate] > 0)
                {
                    if(columnCoordinate - 1 >= 0 && matrix[rowCoordinate, columnCoordinate - 1] > 0)
                    {
                        matrix[rowCoordinate, columnCoordinate - 1] -= bomb;
                    }
                    
                    if(columnCoordinate + 1 < matrix.GetLength(1) && matrix[rowCoordinate, columnCoordinate + 1] > 0)
                    {
                        matrix[rowCoordinate, columnCoordinate + 1] -= bomb;
                    }
                    
                    if(rowCoordinate - 1 >= 0 && matrix[rowCoordinate - 1, columnCoordinate] > 0)
                    {
                        matrix[rowCoordinate - 1, columnCoordinate] -= bomb;
                    }
                    
                    if(rowCoordinate + 1 < matrix.GetLength(0) && matrix[rowCoordinate + 1, columnCoordinate] > 0)
                    {
                        matrix[rowCoordinate + 1, columnCoordinate] -= bomb;
                    }
                    
                    if(rowCoordinate + 1 < matrix.GetLength(0) && columnCoordinate + 1 < matrix.GetLength(1) && matrix[rowCoordinate + 1, columnCoordinate + 1] > 0)
                    {
                        matrix[rowCoordinate + 1, columnCoordinate + 1] -= bomb;
                    }
                    
                    if(rowCoordinate - 1 >= 0 && columnCoordinate - 1 >= 0 && matrix[rowCoordinate - 1, columnCoordinate - 1] > 0)
                    {
                        matrix[rowCoordinate - 1, columnCoordinate - 1] -= bomb;
                    }
                    
                    if(rowCoordinate - 1 >= 0 && columnCoordinate + 1 < matrix.GetLength(1) && matrix[rowCoordinate - 1, columnCoordinate + 1] > 0)
                    {
                        matrix[rowCoordinate - 1, columnCoordinate + 1] -= bomb;
                    }
                    
                    if(rowCoordinate + 1 < matrix.GetLength(0) && columnCoordinate - 1 >= 0 && matrix[rowCoordinate + 1, columnCoordinate - 1] > 0)
                    {
                        matrix[rowCoordinate + 1, columnCoordinate - 1] -= bomb;
                    }
                }

                if (matrix[rowCoordinate, columnCoordinate] > 0)
                {
                    matrix[rowCoordinate, columnCoordinate] = 0;
                }
                
                token.RemoveAt(0);
                token.RemoveAt(0);
                coordinates.RemoveAt(0);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        aliveCells++;
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

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
