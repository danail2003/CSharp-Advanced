using System;
using System.Linq;
using System.Collections.Generic;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main()
        {
            int[] sequenceOfCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sequenceOfBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(sequenceOfCups);
            Stack<int> bottles = new Stack<int>(sequenceOfBottles);
            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                if (bottles.Peek() < cups.Peek())
                {
                    int diff = cups.Dequeue() - bottles.Pop();

                    while (diff > 0)
                    {
                        if (diff >= bottles.Peek())
                        {
                            diff -= bottles.Pop();
                        }
                        else
                        {
                            int bottle = bottles.Peek();
                            wastedWater += bottles.Pop() - diff;
                            diff -= bottle;

                            if (diff < 0)
                            {
                                diff = 0;
                            }
                        }
                    }
                }
                else if (bottles.Peek() > cups.Peek())
                {
                    wastedWater += bottles.Pop() - cups.Dequeue();
                }
                else
                {
                    bottles.Pop();
                    cups.Dequeue();
                }
            }

            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
