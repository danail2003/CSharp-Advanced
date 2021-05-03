using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[,] matrix = new char[number, number];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string symbols = Console.ReadLine();
                char[] elements = new char[symbols.Length];
                for (int j = 0; j < symbols.Length; j++)
                {
                    elements[j] = symbols[j];
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            char searchedSymbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == searchedSymbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
        }
    }
}
