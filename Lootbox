using System;
using System.Linq;
using System.Collections.Generic;

namespace Lootbox
{
    class Program
    {
        static void Main()
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int claimedItems = 0;

            while (firstBox.Any() && secondBox.Any())
            {
                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    claimedItems += firstBox.Dequeue() + secondBox.Pop();
                }
                else
                {
                    int item = secondBox.Pop();
                    firstBox.Enqueue(item);
                }
            }

            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (!secondBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
