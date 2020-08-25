using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Stack<char> reverse = new Stack<char>();

            foreach (char symbol in text)
            {
                reverse.Push(symbol);
            }

            while (reverse.Count > 0)
            {
                Console.Write(reverse.Pop());
            }

            Console.WriteLine();
        }
    }
}
