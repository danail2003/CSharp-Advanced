using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (array[0] == 1)
                {
                    stack.Push(array[1]);
                }
                else if (array[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (array[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (array[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
