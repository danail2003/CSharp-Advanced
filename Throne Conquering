using System;

namespace Throne_Conquering
{
    class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];
            int parisRow = 0;
            int parisColumn = 0;
            bool isReached = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string row = Console.ReadLine();
                matrix[i] = new char[row.Length];

                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i][j] = row[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'P')
                    {
                        parisRow = i;
                        parisColumn = j;
                    }
                }
            }

            matrix[parisRow][parisColumn] = '-';

            while (true)
            {
                string command = Console.ReadLine();
                string[] token = command.Split();
                int row = int.Parse(token[1]);
                int column = int.Parse(token[2]);
                matrix[row][column] = 'S';
                energy -= 1;

                if (token[0] == "up")
                {
                    if (parisRow - 1 >= 0 && parisRow - 1 < matrix.GetLength(0) && parisColumn >= 0 && parisColumn < matrix[parisRow].Length)
                    {
                        parisRow -= 1;

                        if (energy <= 0)
                        {
                            matrix[parisRow][parisColumn] = 'X';
                            break;
                        }

                        if (matrix[parisRow][parisColumn] == 'S')
                        {
                            energy -= 2;

                            if (energy <= 0)
                            {
                                matrix[parisRow][parisColumn] = 'X';
                                break;
                            }
                            else
                            {
                                matrix[parisRow][parisColumn] = '-';
                            }
                        }
                        else if (matrix[parisRow][parisColumn] == 'H')
                        {
                            isReached = true;
                            matrix[parisRow][parisColumn] = '-';
                            break;
                        }
                    }
                }
                else if (token[0] == "down")
                {
                    if (parisRow + 1 >= 0 && parisRow + 1 < matrix.GetLength(0) && parisColumn >= 0 && parisColumn < matrix[parisRow].Length)
                    {
                        parisRow += 1;

                        if (energy <= 0)
                        {
                            matrix[parisRow][parisColumn] = 'X';
                            break;
                        }

                        if (matrix[parisRow][parisColumn] == 'S')
                        {
                            energy -= 2;

                            if (energy <= 0)
                            {
                                matrix[parisRow][parisColumn] = 'X';
                                break;
                            }
                            else
                            {
                                matrix[parisRow][parisColumn] = '-';
                            }
                        }
                        else if (matrix[parisRow][parisColumn] == 'H')
                        {
                            isReached = true;
                            matrix[parisRow][parisColumn] = '-';
                            break;
                        }
                    }
                }
                else if (token[0] == "right")
                {
                    if (parisColumn + 1 >= 0 && parisColumn + 1 < matrix[parisRow].Length && parisRow >= 0 && parisRow < matrix.GetLength(0))
                    {
                        parisColumn += 1;

                        if (energy <= 0)
                        {
                            matrix[parisRow][parisColumn] = 'X';
                            break;
                        }

                        if (matrix[parisRow][parisColumn] == 'S')
                        {
                            energy -= 2;

                            if (energy <= 0)
                            {
                                matrix[parisRow][parisColumn] = 'X';
                                break;
                            }
                            else
                            {
                                matrix[parisRow][parisColumn] = '-';
                            }
                        }
                        else if (matrix[parisRow][parisColumn] == 'H')
                        {
                            isReached = true;
                            matrix[parisRow][parisColumn] = '-';
                            break;
                        }
                    }
                }
                else if (token[0] == "left")
                {
                    if (parisColumn - 1 >= 0 && parisColumn - 1 < matrix[parisRow].Length && parisRow >= 0 && parisRow < matrix.GetLength(0))
                    {
                        parisColumn -= 1;

                        if (energy <= 0)
                        {
                            matrix[parisRow][parisColumn] = 'X';
                            break;
                        }

                        if (matrix[parisRow][parisColumn] == 'S')
                        {
                            energy -= 2;

                            if (energy <= 0)
                            {
                                matrix[parisRow][parisColumn] = 'X';
                                break;
                            }
                            else
                            {
                                matrix[parisRow][parisColumn] = '-';
                            }
                        }
                        else if (matrix[parisRow][parisColumn] == 'H')
                        {
                            isReached = true;
                            matrix[parisRow][parisColumn] = '-';
                            break;
                        }
                    }
                }
            }

            if (isReached)
            {
                Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisColumn}.");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
