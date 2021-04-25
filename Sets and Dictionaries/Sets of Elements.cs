using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main()
        {
            int[] sets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>(sets[0]);
            HashSet<int> secondSet = new HashSet<int>(sets[1]);

            for (int i = 0; i < sets[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < sets[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}
