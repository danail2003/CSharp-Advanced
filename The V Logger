using System;
using System.Linq;
using System.Collections.Generic;

namespace The_V_Logger
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] token = command.Split();

                if (token[1] == "followed")
                {
                    if(vloggers.ContainsKey(token[0]) && vloggers.ContainsKey(token[2]) && token[0] != token[2])
                    {
                        vloggers[token[2]]["followers"].Add(token[0]);
                        vloggers[token[0]]["following"].Add(token[2]);
                    }
                }
                else
                {
                    if (!vloggers.ContainsKey(token[0]))
                    {
                        vloggers[token[0]] = new Dictionary<string, HashSet<string>>();
                        vloggers[token[0]]["followers"] = new HashSet<string>();
                        vloggers[token[0]]["following"] = new HashSet<string>();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in vloggers.OrderByDescending(x=>x.Value["followers"].Count).ThenBy(x=>x.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var followers in vlogger.Value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }

                counter++;
            }
        }
    }
}
