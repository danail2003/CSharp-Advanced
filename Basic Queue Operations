using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            int dequeue = integers[1];
            int number = integers[2];

            for (int i = 0; i < dequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
