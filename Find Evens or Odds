using System;
using System.Linq;
using System.Collections.Generic;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            int[] numbers = Console.ReadLine().Split().Select(parser).ToArray();
            string command = Console.ReadLine();
            List<int> range = new List<int>();

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                range.Add(i);
            }

            Predicate<int> isEven = new Predicate<int>(x => x % 2 == 0);
            Predicate<int> isOdd = new Predicate<int>(x => x % 2 != 0);
            List<int> result = new List<int>();

            if (command == "even")
            {
                result = range.FindAll(isEven);
            }
            else if (command == "odd")
            {
                result = range.FindAll(isOdd);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
