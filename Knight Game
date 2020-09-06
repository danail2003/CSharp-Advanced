using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];

            for (int i = 0; i < size; i++)
            {
                char[] symbols = Console.ReadLine().ToArray();
                matrix[i] = new char[symbols.Length - 1];
                matrix[i] = symbols;
            }

            int currentKnightsInDanger = 0;
            int maxKnightsInDanger = -1;
            int mostDangerousKnightRow = 0;
            int mostDangerousKnightCol = 0;
            int count = 0;

            while (true)
            {
                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex].Equals('K'))
                        {
                            // vertical and left
                            if (IsCellInMatrix(rowIndex - 2, colIndex - 1, matrix))
                            {
                                if (matrix[rowIndex - 2][colIndex - 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and right
                            if (IsCellInMatrix(rowIndex - 2, colIndex + 1, matrix))
                            {
                                if (matrix[rowIndex - 2][colIndex + 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and left
                            if (IsCellInMatrix(rowIndex + 2, colIndex - 1, matrix))
                            {
                                if (matrix[rowIndex + 2][colIndex - 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and right
                            if (IsCellInMatrix(rowIndex + 2, colIndex + 1, matrix))
                            {
                                if (matrix[rowIndex + 2][colIndex + 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal up and left
                            if (IsCellInMatrix(rowIndex - 1, colIndex - 2, matrix))
                            {
                                if (matrix[rowIndex - 1][colIndex - 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal up and right
                            if (IsCellInMatrix(rowIndex - 1, colIndex + 2, matrix))
                            {
                                if (matrix[rowIndex - 1][colIndex + 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal down and left
                            if (IsCellInMatrix(rowIndex + 1, colIndex - 2, matrix))
                            {
                                if (matrix[rowIndex + 1][colIndex - 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal down and right
                            if (IsCellInMatrix(rowIndex + 1, colIndex + 2, matrix))
                            {
                                if (matrix[rowIndex + 1][colIndex + 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                        }

                        if (currentKnightsInDanger > maxKnightsInDanger)
                        {
                            maxKnightsInDanger = currentKnightsInDanger;
                            mostDangerousKnightRow = rowIndex;
                            mostDangerousKnightCol = colIndex;
                        }
                        currentKnightsInDanger = 0;
                    }
                }
                if (maxKnightsInDanger != 0)
                {
                    matrix[mostDangerousKnightRow][mostDangerousKnightCol] = 'O';
                    count++;
                    maxKnightsInDanger = 0;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }
            }

            static bool IsCellInMatrix(int row, int col, char[][] matrix)
            {
                if (0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
