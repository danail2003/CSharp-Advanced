using System;
using System.Linq;
using System.Collections.Generic;

namespace Hit_List
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> personsInfo = new Dictionary<string, Dictionary<string, string>>();
            int targetIndex = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end transmissions")
                {
                    break;
                }

                string[] token = command.Split(new char[] { '=', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (!personsInfo.ContainsKey(token[0]))
                {
                    personsInfo[token[0]] = new Dictionary<string, string>();
                }

                for (int i = 1; i < token.Length; i += 2)
                {
                    personsInfo[token[0]][token[i]] = token[i + 1];
                }
            }

            string killPerson = Console.ReadLine();

            string[] parts = killPerson.Split();
            string person = parts[1];
            int sum = 0;

            foreach (var people in personsInfo)
            {
                if (people.Key == person)
                {
                    Console.WriteLine($"Info on {people.Key}:");

                    foreach (var info in people.Value.OrderBy(x => x.Key))
                    {
                        sum += info.Key.Length + info.Value.Length;
                        Console.WriteLine($"---{info.Key}: {info.Value}");
                    }
                }
            }

            Console.WriteLine($"Info index: {sum}");

            if (sum >= targetIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                int diff = targetIndex - sum;
                Console.WriteLine($"Need {diff} more info.");
            }
        }
    }
}
