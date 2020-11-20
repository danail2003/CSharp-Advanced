using System;
using System.Linq;
using System.Collections.Generic;

namespace The_Kitchen
{
    class Program
    {
        static void Main()
        {
            int[] knives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] forks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(knives);
            Queue<int> queue = new Queue<int>(forks);
            List<int> sets = new List<int>();

            while (stack.Any() && queue.Any())
            {
                if (stack.Peek() > queue.Peek())
                {
                    int sum = stack.Pop() + queue.Dequeue();
                    sets.Add(sum);
                }
                else if (stack.Peek() < queue.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    int knive = stack.Pop() + 1;
                    stack.Push(knive);
                    queue.Dequeue();
                }
            }

            Console.WriteLine($"The biggest set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
