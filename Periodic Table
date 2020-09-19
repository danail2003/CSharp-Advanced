using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] token = Console.ReadLine().Split();

                for (int j = 0; j < token.Length; j++)
                {
                    elements.Add(token[j]);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
