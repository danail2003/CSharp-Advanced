using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main()
        {
            string[] children = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            Queue<string> childs = new Queue<string>(children);

            while (childs.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    childs.Enqueue(childs.Dequeue());
                }

                Console.WriteLine($"Removed {childs.Dequeue()}");
            }

            Console.WriteLine($"Last is {childs.Dequeue()}");
        }
    }
}
