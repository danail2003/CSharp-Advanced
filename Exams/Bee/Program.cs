using System;

namespace Bee
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int beeRow = 0;
            int beeColumn = 0;
            int pollinates = 0;
            bool isGoesOut = false;

            for (int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = line[j];

                    if (line[j] == 'B')
                    {
                        beeRow = i;
                        beeColumn = j;
                    }
                }
            }

            string command = Console.ReadLine();

            matrix[beeRow, beeColumn] = '.';

            while (command != "End")
            {
                if (command == "up")
                {
                    if (beeRow == 0)
                    {
                        matrix[beeRow, beeColumn] = '.';
                        isGoesOut = true;
                        break;
                    }

                    beeRow -= 1;

                    if (matrix[beeRow, beeColumn] == 'O')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        beeRow -= 1;

                        if (matrix[beeRow, beeColumn] == 'f')
                        {
                            matrix[beeRow, beeColumn] = '.';
                            pollinates++;
                        }
                    }
                    else if (matrix[beeRow, beeColumn] == 'f')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        pollinates++;
                    }
                }
                else if (command == "down")
                {
                    if (beeRow + 1 == matrix.GetLength(0))
                    {
                        matrix[beeRow, beeColumn] = '.';
                        isGoesOut = true;
                        break;
                    }

                    beeRow += 1;

                    if (matrix[beeRow, beeColumn] == 'O')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        beeRow += 1;

                        if (matrix[beeRow, beeColumn] == 'f')
                        {
                            matrix[beeRow, beeColumn] = '.';
                            pollinates++;
                        }
                    }
                    else if (matrix[beeRow, beeColumn] == 'f')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        pollinates++;
                    }
                }
                else if (command == "left")
                {
                    if (beeColumn == 0)
                    {
                        matrix[beeRow, beeColumn] = '.';
                        isGoesOut = true;
                        break;
                    }

                    beeColumn -= 1;

                    if (matrix[beeRow, beeColumn] == 'O')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        beeColumn -= 1;

                        if (matrix[beeRow, beeColumn] == 'f')
                        {
                            matrix[beeRow, beeColumn] = '.';
                            pollinates++;
                        }
                    }
                    else if (matrix[beeRow, beeColumn] == 'f')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        pollinates++;
                    }
                }
                else if (command == "right")
                {
                    if (beeColumn + 1 == matrix.GetLength(1))
                    {
                        matrix[beeRow, beeColumn] = '.';
                        isGoesOut = true;
                        break;
                    }

                    beeColumn += 1;

                    if (matrix[beeRow, beeColumn] == 'O')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        beeColumn += 1;

                        if (matrix[beeRow, beeColumn] == 'f')
                        {
                            matrix[beeRow, beeColumn] = '.';
                            pollinates++;
                        }
                    }
                    else if (matrix[beeRow, beeColumn] == 'f')
                    {
                        matrix[beeRow, beeColumn] = '.';
                        pollinates++;
                    }
                }

                command = Console.ReadLine();
            }

            if (isGoesOut)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (!isGoesOut)
            {
                matrix[beeRow, beeColumn] = 'B';
            }

            if (pollinates >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinates} flowers!");
            }
            else
            {
                int diff = 5 - pollinates;

                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {diff} flowers more");
            }

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
