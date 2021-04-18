using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int snakeRow = 0;
            int snakeColumn = 0;
            int foodQuantity = 0;
            bool isEnough = false;

            for (int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = line[j];

                    if (matrix[i, j] == 'S')
                    {
                        snakeRow = i;
                        snakeColumn = j;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    matrix[snakeRow, snakeColumn] = '.';

                    snakeRow -= 1;

                    if (snakeRow < 0)
                    {
                        break;
                    }

                    if (matrix[snakeRow, snakeColumn] == '*')
                    {
                        foodQuantity++;

                        if (foodQuantity == 10)
                        {
                            matrix[snakeRow, snakeColumn] = 'S';
                            isEnough = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeColumn] == 'B')
                    {
                        matrix[snakeRow, snakeColumn] = '.';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'B')
                                {
                                    snakeRow = i;
                                    snakeColumn = j;
                                    matrix[i, j] = '.';
                                }
                            }
                        }
                    }
                }
                else if (command == "down")
                {
                    matrix[snakeRow, snakeColumn] = '.';

                    snakeRow += 1;

                    if (snakeRow == matrix.GetLength(0))
                    {
                        break;
                    }

                    if (matrix[snakeRow, snakeColumn] == '*')
                    {
                        foodQuantity++;

                        if (foodQuantity == 10)
                        {
                            matrix[snakeRow, snakeColumn] = 'S';
                            isEnough = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeColumn] == 'B')
                    {
                        matrix[snakeRow, snakeColumn] = '.';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'B')
                                {
                                    snakeRow = i;
                                    snakeColumn = j;
                                    matrix[i, j] = '.';
                                }
                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    matrix[snakeRow, snakeColumn] = '.';
                    snakeColumn += 1;

                    if (snakeColumn == matrix.GetLength(1))
                    {
                        break;
                    }

                    if (matrix[snakeRow, snakeColumn] == '*')
                    {
                        foodQuantity++;

                        if (foodQuantity == 10)
                        {
                            matrix[snakeRow, snakeColumn] = 'S';
                            isEnough = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeColumn] == 'B')
                    {
                        matrix[snakeRow, snakeColumn] = '.';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'B')
                                {
                                    snakeRow = i;
                                    snakeColumn = j;
                                    matrix[i, j] = '.';
                                }
                            }
                        }
                    }
                }
                else if (command == "left")
                {
                    matrix[snakeRow, snakeColumn] = '.';
                    snakeColumn -= 1;

                    if (snakeColumn < 0)
                    {
                        break;
                    }

                    if (matrix[snakeRow, snakeColumn] == '*')
                    {
                        foodQuantity++;

                        if (foodQuantity == 10)
                        {
                            matrix[snakeRow, snakeColumn] = 'S';
                            isEnough = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeColumn] == 'B')
                    {
                        matrix[snakeRow, snakeColumn] = '.';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'B')
                                {
                                    snakeRow = i;
                                    snakeColumn = j;
                                    matrix[i, j] = '.';
                                }
                            }
                        }
                    }
                }
            }

            if (isEnough)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            else
            {
                Console.WriteLine("Game over!");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
