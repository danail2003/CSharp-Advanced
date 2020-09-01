using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main()
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }
                else if (name == "Paid")
                {
                    while (names.Count > 0)
                    {
                        string removedNames = names.Dequeue();

                        Console.WriteLine(removedNames);
                    }
                }
                else
                {
                    names.Enqueue(name);
                }
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
