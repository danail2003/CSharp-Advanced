﻿using System;

namespace Stack
{
    class StartUp
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Stack<int> elements = new Stack<int>();

            while (command != "END")
            {
                string[] token = command.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                if (token[0] == "Push")
                {
                    for (int i = 1; i < token.Length; i++)
                    {
                        elements.Push(int.Parse(token[i]));
                    }
                }
                else if (token[0] == "Pop")
                {
                    try
                    {
                        elements.Pop();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
