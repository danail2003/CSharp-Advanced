using System;

namespace Helen_s_Abduction
{
    class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] field = new char[rows][];
            int parisRow = 0;
            int parisColumn = 0;
            bool isDead = false;

            for (int i = 0; i < rows; i++)
            {
                string row = Console.ReadLine();
                field[i] = new char[row.Length];

                for (int j = 0; j < row.Length; j++)
                {
                    field[i][j] = row[j];

                    if (row[j] == 'P')
                    {
                        parisRow = i;
                        parisColumn = j;
                    }
                }
            }

            field[parisRow][parisColumn] = '-';

            while (true)
            {
                string[] token = Console.ReadLine().Split();

                field[int.Parse(token[1])][int.Parse(token[2])] = 'S';
                energy--;

                if (token[0] == "up")
                {
                    parisRow--;

                    if (parisRow < 0)
                    {
                        parisRow++;
                    }
                    else if (field[parisRow][parisColumn] == 'S')
                    {
                        energy -= 2;

                        if (energy <= 0)
                        {
                            field[parisRow][parisColumn] = 'X';
                            isDead = true;
                            break;
                        }
                        else
                        {
                            field[parisRow][parisColumn] = '-';
                        }
                    }
                    else if (field[parisRow][parisColumn] == 'H')
                    {
                        field[parisRow][parisColumn] = '-';
                        break;
                    }
                }
                else if (token[0] == "down")
                {
                    parisRow++;

                    if (parisRow == field.GetLength(0))
                    {
                        parisRow--;
                    }
                    else if (field[parisRow][parisColumn] == 'S')
                    {
                        energy -= 2;

                        if (energy <= 0)
                        {
                            field[parisRow][parisColumn] = 'X';
                            isDead = true;
                            break;
                        }
                        else
                        {
                            field[parisRow][parisColumn] = '-';
                        }
                    }
                    else if (field[parisRow][parisColumn] == 'H')
                    {
                        field[parisRow][parisColumn] = '-';
                        break;
                    }
                }
                else if (token[0] == "left")
                {
                    parisColumn--;

                    if (parisColumn < 0)
                    {
                        parisColumn++;
                    }
                    else if (field[parisRow][parisColumn] == 'S')
                    {
                        energy -= 2;

                        if (energy <= 0)
                        {
                            field[parisRow][parisColumn] = 'X';
                            isDead = true;
                            break;
                        }
                        else
                        {
                            field[parisRow][parisColumn] = '-';
                        }
                    }
                    else if (field[parisRow][parisColumn] == 'H')
                    {
                        field[parisRow][parisColumn] = '-';
                        break;
                    }
                }
                else if (token[0] == "right")
                {
                    parisColumn++;

                    if (parisColumn == field[parisRow].Length)
                    {
                        parisColumn--;
                    }
                    else if (field[parisRow][parisColumn] == 'S')
                    {
                        energy -= 2;

                        if (energy <= 0)
                        {
                            field[parisRow][parisColumn] = 'X';
                            isDead = true;
                            break;
                        }
                        else
                        {
                            field[parisRow][parisColumn] = '-';
                        }
                    }
                    else if (field[parisRow][parisColumn] == 'H')
                    {
                        field[parisRow][parisColumn] = '-';
                        break;
                    }
                }

                if (energy <= 0)
                {
                    field[parisRow][parisColumn] = 'X';
                    isDead = true;
                    break;
                }
            }

            if (isDead)
            {
                Console.WriteLine($"Paris died at {parisRow};{parisColumn}.");
            }
            else
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
