using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = row;               
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split();
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (parts[0] == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (parts[0] == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            foreach (var array in jaggedArray)
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
