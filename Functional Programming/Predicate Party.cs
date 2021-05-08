using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_Party_
{
    class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Predicate<string> isParty = x => x == "Party!";
            Predicate<string> isDouble = x => x == "Double";
            Predicate<string> isRemove = x => x == "Remove";
            Predicate<string> isStarts = x => x == "StartsWith";
            Predicate<string> isEnds = x => x == "EndsWith";
            Predicate<string> isLength = x => x == "Length";

            while (true)
            {
                string command = Console.ReadLine();

                if (isParty(command))
                {
                    break;
                }

                string[] token = command.Split();

                if (isDouble(token[0]))
                {
                    if (isStarts(token[1]))
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].StartsWith(token[2]))
                            {
                               names = names.Prepend(names[i]).ToList();
                                i++;
                            }
                        }
                    }
                    else if (isEnds(token[1]))
                    {
                        if (isEnds(token[1]))
                        {
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].EndsWith(token[2]))
                                {
                                   names = names.Prepend(names[i]).ToList();
                                    i++;
                                }
                            }
                        }
                    }
                    else if (isLength(token[1]))
                    {
                        int length = int.Parse(token[2]);

                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].Length == length)
                            {
                                names = names.Prepend(names[i]).ToList();
                                i++;
                            }
                        }
                    }
                }
                else if (isRemove(token[0]))
                {
                    if (isStarts(token[1]))
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].StartsWith(token[2]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                    }
                    else if (isEnds(token[1]))
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].EndsWith(token[2]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                    }
                    else if (isLength(token[1]))
                    {
                        int length = int.Parse(token[2]);

                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].Length == length)
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            if (names.Any())
            {
                Console.Write($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
