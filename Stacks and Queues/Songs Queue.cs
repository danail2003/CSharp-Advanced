using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main()
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsForPlay = new Queue<string>(songs);

            while (songsForPlay.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    if (songsForPlay.Count > 0)
                    {
                        songsForPlay.Dequeue();
                    }
                }
                else if (command.Contains("Add"))
                {
                    command = command.Replace("Add ", "");

                    if (songsForPlay.Contains(command))
                    {
                        Console.WriteLine($"{command} is already contained!");
                    }
                    else
                    {
                        songsForPlay.Enqueue(command);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsForPlay));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
