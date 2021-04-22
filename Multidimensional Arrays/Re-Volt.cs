using System;

namespace Re_Volt
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int playersRow = 0;
            int playersColumn = 0;
            bool isFinish = false;

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];

                    if (row[j] == 'f')
                    {
                        playersRow = i;
                        playersColumn = j;
                    }
                }
            }

            matrix[playersRow, playersColumn] = '-';

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    playersRow -= 1;

                    if (playersRow < 0)
                    {
                        playersRow = matrix.GetLength(0) - 1;
                    }

                    if (matrix[playersRow, playersColumn] == 'B')
                    {
                        playersRow -= 1;

                        if (playersRow < 0)
                        {
                            playersRow = matrix.GetLength(0) - 1;
                        }
                    }
                    else if (matrix[playersRow, playersColumn] == 'T')
                    {
                        playersRow += 1;

                        if (playersRow == matrix.GetLength(0))
                        {
                            playersRow = 0;
                        }
                    }

                    if (matrix[playersRow, playersColumn] == 'F')
                    {
                        isFinish = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    playersRow += 1;

                    if (playersRow == matrix.GetLength(0))
                    {
                        playersRow = 0;
                    }

                    if (matrix[playersRow, playersColumn] == 'B')
                    {
                        playersRow += 1;

                        if (playersRow == matrix.GetLength(0))
                        {
                            playersRow = 0;
                        }
                    }
                    else if (matrix[playersRow, playersColumn] == 'T')
                    {
                        playersRow -= 1;

                        if (playersRow < 0)
                        {
                            playersRow = matrix.GetLength(0) - 1;
                        }
                    }

                    if (matrix[playersRow, playersColumn] == 'F')
                    {
                        isFinish = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    playersColumn -= 1;

                    if (playersColumn < 0)
                    {
                        playersColumn = matrix.GetLength(1) - 1;
                    }

                    if (matrix[playersRow, playersColumn] == 'B')
                    {
                        playersColumn -= 1;

                        if (playersColumn < 0)
                        {
                            playersColumn = matrix.GetLength(1) - 1;
                        }
                    }
                    else if (matrix[playersRow, playersColumn] == 'T')
                    {
                        playersColumn += 1;

                        if (playersColumn == matrix.GetLength(1))
                        {
                            playersColumn = 0;
                        }
                    }

                    if (matrix[playersRow, playersColumn] == 'F')
                    {
                        isFinish = true;
                        break;
                    }
                }
                else if (command == "right")
                {
                    playersColumn += 1;

                    if (playersColumn == matrix.GetLength(1))
                    {
                        playersColumn = 0;
                    }

                    if (matrix[playersRow, playersColumn] == 'B')
                    {
                        playersColumn += 1;

                        if (playersColumn == matrix.GetLength(1))
                        {
                            playersColumn = 0;
                        }
                    }
                    else if (matrix[playersRow, playersColumn] == 'T')
                    {
                        playersColumn -= 1;

                        if (playersColumn < 0)
                        {
                            playersColumn = matrix.GetLength(1) - 1;
                        }
                    }

                    if (matrix[playersRow, playersColumn] == 'F')
                    {
                        isFinish = true;
                        break;
                    }
                }
            }

            if (isFinish)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            matrix[playersRow, playersColumn] = 'f';

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
