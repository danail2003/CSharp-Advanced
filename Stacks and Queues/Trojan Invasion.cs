using System;
using System.Linq;
using System.Collections.Generic;

namespace Trojan_Invasion
{
    class Program
    {
        static void Main()
        {
            int waves = int.Parse(Console.ReadLine());
            List<int> spartanDefense = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> allTrojans = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                int[] trojans = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (spartanDefense.Any())
                {
                    for (int j = 0; j < trojans.Length; j++)
                    {
                        allTrojans.Push(trojans[j]);
                    }

                    if (i % 3 == 0)
                    {
                        int plate = int.Parse(Console.ReadLine());
                        spartanDefense.Add(plate);
                    }
                }

                while (allTrojans.Any() && spartanDefense.Any())
                {
                    int currentPlate = spartanDefense[0];

                    if (allTrojans.Peek() > currentPlate)
                    {
                        int diff = allTrojans.Pop() - currentPlate;
                        allTrojans.Push(diff);
                        spartanDefense.RemoveAt(0);
                    }
                    else if (allTrojans.Peek() < currentPlate)
                    {
                        currentPlate -= allTrojans.Pop();
                        spartanDefense[0] = currentPlate;
                    }
                    else
                    {
                        allTrojans.Pop();
                        spartanDefense.RemoveAt(0);
                    }
                }
            }


            if (spartanDefense.Any())
            {
                Console.WriteLine($"The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", spartanDefense)}");
            }
            else if (allTrojans.Any())
            {
                Console.WriteLine($"The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", allTrojans)}");
            }
        }
    }
}
