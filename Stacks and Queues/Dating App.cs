using System;
using System.Linq;
using System.Collections.Generic;

namespace Dating_App
{
    class Program
    {
        static void Main()
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int matches = 0;

            while (males.Any() && females.Any())
            {
                if (males.Peek() <= 0)
                {
                    males.Pop();
                }
                else if (females.Peek() <= 0)
                {
                    females.Dequeue();
                }
                else if (males.Peek() % 25 == 0)
                {
                    males.Pop();

                    if (males.Any())
                    {
                        males.Pop();
                    }
                }
                else if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();

                    if (females.Any())
                    {
                        females.Dequeue();
                    }
                }
                else if (males.Peek() == females.Peek())
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                }
                else
                {
                    females.Dequeue();
                    males.Push(males.Pop() - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Any())
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
