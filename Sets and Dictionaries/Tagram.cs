using System;
using System.Linq;
using System.Collections.Generic;

namespace Tagram
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> usernames = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command.StartsWith("ban"))
                {
                    string[] token = command.Split();

                    if (usernames.ContainsKey(token[1]))
                    {
                        usernames.Remove(token[1]);
                    }
                }
                else
                {
                    string[] token = command.Split(" -> ");

                    if (!usernames.ContainsKey(token[0]))
                    {
                        usernames[token[0]] = new Dictionary<string, int>();
                    }

                    if (!usernames[token[0]].ContainsKey(token[1]))
                    {
                        usernames[token[0]][token[1]] = 0;
                    }

                    usernames[token[0]][token[1]] += int.Parse(token[2]);
                }

                command = Console.ReadLine();
            }


            foreach (var user in usernames.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine(user.Key);

                foreach (var tag in user.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
