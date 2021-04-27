using System;
using System.Linq;
using System.Collections.Generic;

namespace Snake_Moves
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[rowsAndCol[0], rowsAndCol[1]];
            string snake = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            int counter = 0;

            for (int i = 0; i < snake.Length; i++)
            {
                queue.Enqueue(snake[i]);
                counter++;

                if (counter == matrix.Length)
                {
                    break;
                }

                if(i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            List<char> reverse = new List<char>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i % 2 != 0 && queue.Any())
                    {
                        reverse.Add(queue.Dequeue());

                        if(j + 1 == matrix.GetLength(1))
                        {
                            for (int k = reverse.Count - 1; k >= 0; k--)
                            {
                                matrix[i, k] = reverse[0];
                                reverse.RemoveAt(0);
                            }
                        }
                    }
                    else
                    {
                        if (queue.Any())
                        {
                            matrix[i, j] = queue.Dequeue();
                        }
                    }
                }

                reverse.Clear();
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
