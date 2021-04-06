using System;

namespace Book_Worm
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                matrix[i] = new char[row.Length];

                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i][j] = row[j];
                }
            }

            int playersRow = 0;
            int playersColumn = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'P')
                    {
                        playersRow = i;
                        playersColumn = j;
                    }
                }
            }

            matrix[playersRow][playersColumn] = '-';

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up")
                {
                    playersRow -= 1;

                    if (playersRow >= 0)
                    {
                        if (char.IsLetter(matrix[playersRow][playersColumn]))
                        {
                            text += matrix[playersRow][playersColumn];
                            matrix[playersRow][playersColumn] = '-';
                        }
                    }
                    else
                    {
                        playersRow += 1;
                        text = text.Remove(text.Length - 1);
                    }
                }
                else if (command == "down")
                {
                    playersRow += 1;

                    if (playersRow < matrix.GetLength(0))
                    {
                        if (char.IsLetter(matrix[playersRow][playersColumn]))
                        {
                            text += matrix[playersRow][playersColumn];
                            matrix[playersRow][playersColumn] = '-';
                        }
                    }
                    else
                    {
                        playersRow -= 1;
                        text = text.Remove(text.Length - 1);
                    }
                }
                else if (command == "left")
                {
                    playersColumn -= 1;

                    if (playersColumn >= 0)
                    {
                        if (char.IsLetter(matrix[playersRow][playersColumn]))
                        {
                            text += matrix[playersRow][playersColumn];
                            matrix[playersRow][playersColumn] = '-';
                        }
                    }
                    else
                    {
                        playersColumn += 1;
                        text = text.Remove(text.Length - 1);
                    }
                }
                else if (command == "right")
                {
                    playersColumn += 1;

                    if (playersColumn < matrix[playersRow].Length)
                    {
                        if (char.IsLetter(matrix[playersRow][playersColumn]))
                        {
                            text += matrix[playersRow][playersColumn];
                            matrix[playersRow][playersColumn] = '-';
                        }
                    }
                    else
                    {
                        playersColumn -= 1;
                        text = text.Remove(text.Length - 1);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(text);

            matrix[playersRow][playersColumn] = 'P';

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
