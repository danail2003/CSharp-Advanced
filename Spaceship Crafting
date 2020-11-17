using System;
using System.Linq;
using System.Collections.Generic;

namespace Spaceship_Crafting
{
    class Program
    {
        static void Main()
        {
            int[] chemicalLiquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] physicalItems = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> liquids = new Queue<int>(chemicalLiquids);
            Stack<int> items = new Stack<int>(physicalItems);
            Dictionary<string, int> endProduct = new Dictionary<string, int>
            {
                ["Glass"] = 0,
                ["Aluminium"] = 0,
                ["Lithium"] = 0,
                ["Carbon fiber"] = 0
            };

            while (liquids.Any() && items.Any())
            {
                if (liquids.Peek() + items.Peek() == 25)
                {
                    liquids.Dequeue();
                    items.Pop();
                    endProduct["Glass"] += 1;
                }
                else if (liquids.Peek() + items.Peek() == 50)
                {
                    liquids.Dequeue();
                    items.Pop();
                    endProduct["Aluminium"] += 1;
                }
                else if (liquids.Peek() + items.Peek() == 75)
                {
                    liquids.Dequeue();
                    items.Pop();
                    endProduct["Lithium"] += 1;
                }
                else if (liquids.Peek() + items.Peek() == 100)
                {
                    liquids.Dequeue();
                    items.Pop();
                    endProduct["Carbon fiber"] += 1;
                }
                else
                {
                    liquids.Dequeue();
                    int increasing = items.Pop() + 3;
                    items.Push(increasing);
                }
            }

            if (endProduct["Glass"] >= 1 && endProduct["Lithium"] >= 1 && endProduct["Aluminium"] >= 1 && endProduct["Carbon fiber"] >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Any())
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var item in endProduct.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
