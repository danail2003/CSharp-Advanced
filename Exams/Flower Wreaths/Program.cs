using System;
using System.Linq;
using System.Collections.Generic;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main()
        {
            int[] lilies = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(lilies);
            Queue<int> queue = new Queue<int>(roses);

            int wreaths = 0;
            int flowers = 0;

            while (stack.Count > 0 && queue.Count > 0)
            {
                if (stack.Peek() + queue.Peek() == 15)
                {
                    wreaths++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (stack.Peek() + queue.Peek() > 15)
                {
                    int value = stack.Pop() - 2;
                    stack.Push(value);
                }
                else
                {
                    flowers += stack.Pop() + queue.Dequeue();
                }
            }

            wreaths += (flowers / 15);

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                int diff = 5 - wreaths;

                Console.WriteLine($"You didn't make it, you need {diff} wreaths more!");
            }
        }
    }
}
