using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[i] = new double[i];
                matrix[i] = numbers;
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    int counter = 0;

                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        int length = matrix[i + 1].Length;
                        matrix[i][j] /= 2;

                        while (length > counter)
                        {
                            matrix[i + 1][j] /= 2;
                            j++;
                            counter++;

                            if (counter == length)
                            {
                                j = 0;
                            }
                        }
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split();

                if (token[0] == "Add")
                {
                    int row = int.Parse(token[1]);
                    int column = int.Parse(token[2]);
                    int value = int.Parse(token[3]);

                    if (row >= 0 && row < matrix.GetLength(0))
                    {
                        int colLength = matrix[row].Length;

                        if (column >= 0 && column < colLength)
                        {
                            matrix[row][column] += value;
                        }
                    }

                }
                else if (token[0] == "Subtract")
                {
                    int row = int.Parse(token[1]);
                    int column = int.Parse(token[2]);
                    int value = int.Parse(token[3]);

                    if (row >= 0 && row < matrix.GetLength(0))
                    {
                        int colLength = matrix[row].Length;
                        
                        if (column >= 0 && column < colLength)
                        {
                            matrix[row][column] -= value;
                        }
                    }                  
                }

                command = Console.ReadLine();
            }

            foreach (var array in matrix)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
