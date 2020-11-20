using System;
using System.Linq;
using System.Collections.Generic;

namespace Travel_Map
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> mapsWithCost = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] token = command.Split(" > ");
                int price = int.Parse(token[2]);

                if (!mapsWithCost.ContainsKey(token[0]))
                {
                    mapsWithCost[token[0]] = new Dictionary<string, int>();
                }

                if (mapsWithCost[token[0]].ContainsKey(token[1]))
                {
                    if (mapsWithCost[token[0]][token[1]] > price)
                    {
                        mapsWithCost[token[0]][token[1]] = price;
                    }
                }
                else
                {
                    mapsWithCost[token[0]][token[1]] = price;
                }

                command = Console.ReadLine();
            }

            foreach (var country in mapsWithCost.OrderBy(x => x.Key))
            {
                Console.Write($"{country.Key} -> ");

                foreach (var town in country.Value.OrderBy(x => x.Value))
                {
                    Console.Write($"{town.Key} -> {town.Value} ");
                }

                Console.WriteLine();
            }
        }
    }
}
