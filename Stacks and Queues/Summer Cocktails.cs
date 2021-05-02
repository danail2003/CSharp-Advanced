using System;
using System.Linq;
using System.Collections.Generic;

namespace Summer_Cocktails
{
    class Program
    {
        static void Main()
        {
            int[] ingredients = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] freshness = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> allIngredients = new Queue<int>(ingredients);
            Stack<int> freshnessLevel = new Stack<int>(freshness);

            SortedDictionary<string, int> cocktails = new SortedDictionary<string, int>
            {
                ["Mimosa"] = 0,
                ["Daiquiri"] = 0,
                ["Sunshine"] = 0,
                ["Mojito"] = 0
            };

            int counter = 0;

            while (allIngredients.Any() && freshnessLevel.Any())
            {
                if (allIngredients.Peek() == 0)
                {
                    allIngredients.Dequeue();
                }
                else if (allIngredients.Peek() * freshnessLevel.Peek() == 150)
                {
                    cocktails["Mimosa"]++;
                    allIngredients.Dequeue();
                    freshnessLevel.Pop();
                    counter++;
                }
                else if (allIngredients.Peek() * freshnessLevel.Peek() == 250)
                {
                    cocktails["Daiquiri"]++;
                    allIngredients.Dequeue();
                    freshnessLevel.Pop();
                    counter++;
                }
                else if (allIngredients.Peek() * freshnessLevel.Peek() == 300)
                {
                    cocktails["Sunshine"]++;
                    allIngredients.Dequeue();
                    freshnessLevel.Pop();
                    counter++;
                }
                else if (allIngredients.Peek() * freshnessLevel.Peek() == 400)
                {
                    cocktails["Mojito"]++;
                    allIngredients.Dequeue();
                    freshnessLevel.Pop();
                    counter++;
                }
                else
                {
                    freshnessLevel.Pop();
                    int ingredient = allIngredients.Dequeue() + 5;
                    allIngredients.Enqueue(ingredient);
                }
            }

            if (counter >= 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            if (allIngredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {allIngredients.Sum()}");
            }

            foreach (var cocktail in cocktails)
            {
                if (cocktail.Value > 0)
                {
                    Console.WriteLine($"# {cocktail.Key} --> {cocktail.Value}");
                }
            }
        }
    }
}
