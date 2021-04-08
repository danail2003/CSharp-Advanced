using System;
using System.Linq;
using System.Collections.Generic;

namespace Club_Party
{
    class Program
    {
        static void Main()
        {
            int hallsCapacity = int.Parse(Console.ReadLine());
            List<string> lettersAndNumbers = Console.ReadLine().Split().ToList();

            Dictionary<string, List<int>> halls = new Dictionary<string, List<int>>();
            lettersAndNumbers.Reverse();

            for (int i = 0; i < lettersAndNumbers.Count; i++)
            {
                if (int.TryParse(lettersAndNumbers[i], out int value))
                {
                    lettersAndNumbers.RemoveAt(i);
                    i--;
                }
                else
                {
                    break;
                }
            }

            lettersAndNumbers.Reverse();

            Stack<string> elements = new Stack<string>(lettersAndNumbers);

            int currentCapacity = 0;
            string element = "";

            while (elements.Any())
            {
                bool isNumber = int.TryParse(elements.Peek(), out int value);

                if (!isNumber)
                {
                    element = elements.Pop();
                    halls[element] = new List<int>();
                }
                else
                {
                    if (halls.Any())
                    {
                        if (currentCapacity + value > hallsCapacity)
                        {
                            foreach (var hall in halls)
                            {
                                Console.WriteLine($"{hall.Key} -> {string.Join(", ", hall.Value)}");
                            }

                            halls.Clear();
                            currentCapacity = 0;
                        }
                        else
                        {
                            currentCapacity += value;
                            elements.Pop();
                            halls[element].Add(value);
                        }
                    }
                }
            }
        }
    }
}
