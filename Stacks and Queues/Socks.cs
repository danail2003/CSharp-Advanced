using System;
using System.Linq;
using System.Collections.Generic;

namespace Socks
{
    class Program
    {
        static void Main()
        {
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> leftSocks = new Stack<int>(firstNumbers);
            Queue<int> rightSocks = new Queue<int>(secondNumbers);
            List<int> pairs = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                if (leftSocks.Peek() > rightSocks.Peek())
                {
                    pairs.Add(leftSocks.Pop() + rightSocks.Dequeue());
                }
                else if (leftSocks.Peek() < rightSocks.Peek())
                {
                    leftSocks.Pop();
                }
                else if (leftSocks.Peek() == rightSocks.Peek())
                {
                    rightSocks.Dequeue();
                    int increment = leftSocks.Pop() + 1;
                    leftSocks.Push(increment);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
