using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (!continents.ContainsKey(input[0]))
                {
                    continents[input[0]] = new Dictionary<string, List<string>>();
                }

                if (!continents[input[0]].ContainsKey(input[1]))
                {
                    continents[input[0]][input[1]] = new List<string>();
                }

                continents[input[0]][input[1]].Add(input[2]);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
