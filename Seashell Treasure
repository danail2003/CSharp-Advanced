using System;
using System.Collections.Generic;

namespace Seashell_Treasure
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] jaggedArray = new string[rows][];
            int stolenSeashells = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] seashell = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                jaggedArray[i] = new string[i];
                jaggedArray[i] = seashell;
            }

            string command = Console.ReadLine();
            List<string> seashells = new List<string>();

            while (command != "Sunset")
            {
                string[] token = command.Split();

                if (token[0] == "Collect")
                {
                    int row = int.Parse(token[1]);
                    int column = int.Parse(token[2]);

                    if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                    {
                        if (jaggedArray[row][column] != "-")
                        {
                            seashells.Add(jaggedArray[row][column]);
                            jaggedArray[row][column] = "-";
                        }
                    }
                }
                else if (token[0] == "Steal")
                {
                    int row = int.Parse(token[1]);
                    int column = int.Parse(token[2]);
                    int counter = 0;

                    if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                    {
                        if (jaggedArray[row][column] != "-")
                        {
                            stolenSeashells++;
                            jaggedArray[row][column] = "-";
                        }

                        while (counter != 3)
                        {
                            if (token[3] == "up")
                            {
                                row -= 1;

                                if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                                {
                                    if (jaggedArray[row][column] != "-")
                                    {
                                        stolenSeashells++;
                                        jaggedArray[row][column] = "-";
                                    }
                                }
                            }
                            else if (token[3] == "down")
                            {
                                row += 1;

                                if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                                {
                                    if (jaggedArray[row][column] != "-")
                                    {
                                        stolenSeashells++;
                                        jaggedArray[row][column] = "-";
                                    }
                                }
                            }
                            else if (token[3] == "right")
                            {
                                column += 1;

                                if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                                {
                                    if (jaggedArray[row][column] != "-")
                                    {
                                        stolenSeashells++;
                                        jaggedArray[row][column] = "-";
                                    }
                                }
                            }
                            else if (token[3] == "left")
                            {
                                column -= 1;

                                if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                                {
                                    if (jaggedArray[row][column] != "-")
                                    {
                                        stolenSeashells++;
                                        jaggedArray[row][column] = "-";
                                    }
                                }
                            }

                            counter++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var array in jaggedArray)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.Write($"Collected seashells: {seashells.Count} ");

            if (seashells.Count > 0)
            {
                Console.WriteLine($"-> {string.Join(", ", seashells)}");
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine($"Stolen seashells: {stolenSeashells}");
        }
    }
}
