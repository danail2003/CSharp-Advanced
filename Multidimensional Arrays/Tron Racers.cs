using System;

namespace Tron_Racers
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int firstPlayersRow = 0;
            int firstPlayersColumn = 0;
            int secondPlayersRow = 0;
            int secondPlayersColumn = 0;
            bool isDead = false;

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = row[j];

                    if (row[j] == 'f')
                    {
                        firstPlayersRow = i;
                        firstPlayersColumn = j;
                    }
                    else if (row[j] == 's')
                    {
                        secondPlayersRow = i;
                        secondPlayersColumn = j;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "up")
                {
                    firstPlayersRow -= 1;

                    if (firstPlayersRow < 0)
                    {
                        firstPlayersRow = matrix.GetLength(0) - 1;
                    }

                    bool isTrue = Trail(matrix, firstPlayersRow, firstPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
                else if (command[0] == "down")
                {
                    firstPlayersRow += 1;

                    if (firstPlayersRow == matrix.GetLength(0))
                    {
                        firstPlayersRow = 0;
                    }

                    bool isTrue = Trail(matrix, firstPlayersRow, firstPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
                else if (command[0] == "left")
                {
                    firstPlayersColumn -= 1;

                    if (firstPlayersColumn < 0)
                    {
                        firstPlayersColumn = matrix.GetLength(1) - 1;
                    }

                    bool isTrue = Trail(matrix, firstPlayersRow, firstPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
                else if (command[0] == "right")
                {
                    firstPlayersColumn += 1;

                    if (firstPlayersColumn == matrix.GetLength(1))
                    {
                        firstPlayersColumn = 0;
                    }

                    bool isTrue = Trail(matrix, firstPlayersRow, firstPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }

                if (command[1] == "up")
                {
                    secondPlayersRow -= 1;

                    if (secondPlayersRow < 0)
                    {
                        secondPlayersRow = matrix.GetLength(0) - 1;
                    }

                    bool isTrue = SecondTrail(matrix, secondPlayersRow, secondPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
                else if (command[1] == "down")
                {
                    secondPlayersRow += 1;

                    if (secondPlayersRow == matrix.GetLength(0))
                    {
                        secondPlayersRow = 0;
                    }

                    bool isTrue = SecondTrail(matrix, secondPlayersRow, secondPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
                else if (command[1] == "left")
                {
                    secondPlayersColumn -= 1;

                    if (secondPlayersColumn < 0)
                    {
                        secondPlayersColumn = matrix.GetLength(1) - 1;
                    }

                    bool isTrue = SecondTrail(matrix, secondPlayersRow, secondPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
                else if (command[1] == "right")
                {
                    secondPlayersColumn += 1;

                    if (secondPlayersColumn == matrix.GetLength(1))
                    {
                        secondPlayersColumn = 0;
                    }

                    bool isTrue = SecondTrail(matrix, secondPlayersRow, secondPlayersColumn, isDead);

                    if (isTrue)
                    {
                        break;
                    }
                }
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

        static bool Trail(char[,] matrix, int firstPlayersRow, int firstPlayersColumn, bool isDead)
        {
            if (matrix[firstPlayersRow, firstPlayersColumn] == 's')
            {
                matrix[firstPlayersRow, firstPlayersColumn] = 'x';
                isDead = true;
            }
            else
            {
                matrix[firstPlayersRow, firstPlayersColumn] = 'f';
            }

            return isDead;
        }

        static bool SecondTrail(char[,] matrix, int secondPlayersRow, int secondPlayersColumn, bool isDead)
        {
            if (matrix[secondPlayersRow, secondPlayersColumn] == 'f')
            {
                matrix[secondPlayersRow, secondPlayersColumn] = 'x';
                isDead = true;
            }
            else
            {
                matrix[secondPlayersRow, secondPlayersColumn] = 's';
            }

            return isDead;
        }
    }
}
