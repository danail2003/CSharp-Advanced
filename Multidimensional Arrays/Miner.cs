using System;
using System.Linq;
using System.Collections.Generic;

namespace Miner
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            List<string> commands = Console.ReadLine().Split().ToList();

            char[,] matrix = new char[size, size];
            int coals = 0;
            int rowIndex = 0;
            int columnIndex = 0;
            bool isEnd = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 's')
                    {
                        rowIndex = i;
                        columnIndex = j;
                    }
                    else if (matrix[i, j] == 'c')
                    {
                        coals++;
                    }
                }
            }

            matrix[rowIndex, columnIndex] = '*';

            while (commands.Count > 0 && coals != 0 && !isEnd)
            {
                if (commands[0] == "up")
                {
                    if (rowIndex - 1 >= 0 && rowIndex - 1 < matrix.GetLength(0))
                    {
                        rowIndex -= 1;
                        if (matrix[rowIndex, columnIndex] == 'c')
                        {
                            coals -= 1;
                            matrix[rowIndex, columnIndex] = '*';
                        }
                        else if (matrix[rowIndex, columnIndex] == 'e')
                        {
                            isEnd = true;
                        }
                    }
                }
                else if (commands[0] == "down")
                {
                    if (rowIndex + 1 >= 0 && rowIndex + 1 < matrix.GetLength(0))
                    {
                        rowIndex += 1;
                        if (matrix[rowIndex, columnIndex] == 'c')
                        {
                            coals -= 1;
                            matrix[rowIndex, columnIndex] = '*';
                        }
                        else if (matrix[rowIndex, columnIndex] == 'e')
                        {
                            isEnd = true;
                        }
                    }
                }
                else if (commands[0] == "left")
                {
                    if (columnIndex - 1 >= 0 && columnIndex - 1 < matrix.GetLength(1))
                    {
                        columnIndex -= 1;
                        if (matrix[rowIndex, columnIndex] == 'c')
                        {
                            coals -= 1;
                            matrix[rowIndex, columnIndex] = '*';
                        }
                        else if (matrix[rowIndex, columnIndex] == 'e')
                        {
                            isEnd = true;
                        }
                    }
                }
                else if (commands[0] == "right")
                {
                    if (columnIndex + 1 >= 0 && columnIndex + 1 < matrix.GetLength(1))
                    {
                        columnIndex += 1;
                        if (matrix[rowIndex, columnIndex] == 'c')
                        {
                            coals -= 1;
                            matrix[rowIndex, columnIndex] = '*';
                        }
                        else if (matrix[rowIndex, columnIndex] == 'e')
                        {
                            isEnd = true;
                        }
                    }
                }

                commands.RemoveAt(0);
            }

            if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({rowIndex}, {columnIndex})");
            }
            else if (isEnd)
            {
                Console.WriteLine($"Game over! ({rowIndex}, {columnIndex})");
            }
            else
            {
                Console.WriteLine($"{coals} coals left. ({rowIndex}, {columnIndex})");
            }
        }
    }
}
