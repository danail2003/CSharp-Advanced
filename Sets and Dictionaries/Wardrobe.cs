using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] token = Console.ReadLine().Split(" -> ");

                if (!clothes.ContainsKey(token[0]))
                {
                    clothes[token[0]] = new Dictionary<string, int>();
                }

                string[] kindOfClothes = token[1].Split(",");

                for (int j = 0; j < kindOfClothes.Length; j++)
                {
                    if (!clothes[token[0]].ContainsKey(kindOfClothes[j]))
                    {
                        clothes[token[0]][kindOfClothes[j]] = 0;
                    }

                    clothes[token[0]][kindOfClothes[j]] += 1;
                }
            }

            string[] chosenCloth = Console.ReadLine().Split();

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if(color.Key == chosenCloth[0] && cloth.Key == chosenCloth[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
