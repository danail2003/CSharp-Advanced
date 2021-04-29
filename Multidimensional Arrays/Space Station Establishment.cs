using System;

namespace Space_Station_Establishment
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int stephenRow = 0;
            int stephenColumn = 0;
            bool isVoid = false;
            int starsPower = 0;

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];

                    if (row[j] == 'S')
                    {
                        stephenRow = i;
                        stephenColumn = j;
                    }
                }
            }

            matrix[stephenRow, stephenColumn] = '-';

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    stephenRow -= 1;

                    if (stephenRow < 0)
                    {
                        isVoid = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[stephenRow, stephenColumn]))
                    {
                        string digit = matrix[stephenRow, stephenColumn].ToString();
                        starsPower += int.Parse(digit);
                        matrix[stephenRow, stephenColumn] = '-';

                        if (starsPower >= 50)
                        {
                            break;
                        }
                    }
                    else if (matrix[stephenRow, stephenColumn] == 'O')
                    {
                        matrix[stephenRow, stephenColumn] = '-';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'O')
                                {
                                    stephenRow = i;
                                    stephenColumn = j;
                                    matrix[i, j] = '-';
                                }
                            }
                        }
                    }
                }
                else if (command == "down")
                {
                    stephenRow += 1;

                    if (stephenRow == matrix.GetLength(0))
                    {
                        isVoid = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[stephenRow, stephenColumn]))
                    {
                        string digit = matrix[stephenRow, stephenColumn].ToString();
                        starsPower += int.Parse(digit);
                        matrix[stephenRow, stephenColumn] = '-';

                        if (starsPower >= 50)
                        {
                            break;
                        }
                    }
                    else if (matrix[stephenRow, stephenColumn] == 'O')
                    {
                        matrix[stephenRow, stephenColumn] = '-';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'O')
                                {
                                    stephenRow = i;
                                    stephenColumn = j;
                                    matrix[i, j] = '-';
                                }
                            }
                        }
                    }
                }
                else if (command == "left")
                {
                    stephenColumn -= 1;

                    if (stephenColumn < 0)
                    {
                        isVoid = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[stephenRow, stephenColumn]))
                    {
                        string digit = matrix[stephenRow, stephenColumn].ToString();
                        starsPower += int.Parse(digit);
                        matrix[stephenRow, stephenColumn] = '-';

                        if (starsPower >= 50)
                        {
                            break;
                        }
                    }
                    else if (matrix[stephenRow, stephenColumn] == 'O')
                    {
                        matrix[stephenRow, stephenColumn] = '-';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'O')
                                {
                                    stephenRow = i;
                                    stephenColumn = j;
                                    matrix[i, j] = '-';
                                }
                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    stephenColumn += 1;

                    if (stephenColumn == matrix.GetLength(1))
                    {
                        isVoid = true;
                        break;
                    }
                    else if (char.IsDigit(matrix[stephenRow, stephenColumn]))
                    {
                        string digit = matrix[stephenRow, stephenColumn].ToString();
                        starsPower += int.Parse(digit);
                        matrix[stephenRow, stephenColumn] = '-';

                        if (starsPower >= 50)
                        {
                            break;
                        }
                    }
                    else if (matrix[stephenRow, stephenColumn] == 'O')
                    {
                        matrix[stephenRow, stephenColumn] = '-';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == 'O')
                                {
                                    stephenRow = i;
                                    stephenColumn = j;
                                    matrix[i, j] = '-';
                                }
                            }
                        }
                    }
                }
            }

            if (isVoid)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {starsPower}");

            if (!isVoid)
            {
                matrix[stephenRow, stephenColumn] = 'S';
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
