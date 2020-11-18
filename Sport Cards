using System;
using System.Linq;
using System.Collections.Generic;

namespace Sport_Cards
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> cards = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split(" - ");

                if (token[0].StartsWith("check"))
                {
                    string[] parts = command.Split();

                    if (cards.ContainsKey(parts[1]))
                    {
                        Console.WriteLine($"{parts[1]} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{parts[1]} is not available!");
                    }

                    continue;
                }

                double price = double.Parse(token[2]);

                if (!cards.ContainsKey(token[0]))
                {
                    cards[token[0]] = new Dictionary<string, double>();
                }

                cards[token[0]][token[1]] = price;
            }

            foreach (var card in cards.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{card.Key}:");

                foreach (var sport in card.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{sport.Key} - {sport.Value:f2}");
                }
            }
        }
    }
}
