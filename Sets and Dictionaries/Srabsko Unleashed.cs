using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Srabsko_Unleashed
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                Regex regex = new Regex(@"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)");
                Match match = regex.Match(command);

                if (match.Success)
                {
                    string[] token = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int revenue = int.Parse(token[token.Length - 1]) * int.Parse(token[token.Length - 2]);

                    string[] singerAndVenue = token.SkipLast(2).ToArray();
                    string joined = string.Join(" ", singerAndVenue).ToString();

                    string singer = joined.Split("@").First();
                    string venue = joined.Split("@").Last();

                    if (!concerts.ContainsKey(venue))
                    {
                        concerts[venue] = new Dictionary<string, int>();
                    }

                    if (!concerts[venue].ContainsKey(singer))
                    {
                        concerts[venue][singer] = 0;
                    }

                    concerts[venue][singer] += revenue;
                }

                command = Console.ReadLine();
            }

            foreach (var singer in concerts)
            {
                Console.WriteLine(singer.Key);

                foreach (var venues in singer.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {venues.Key}-> {venues.Value}");
                }
            }
        }
    }
}
