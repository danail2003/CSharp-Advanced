using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            
            int[] numbers = Console.ReadLine().Split().Select(parser).ToArray();
            int number = parser(Console.ReadLine());
            
            Predicate<int> divisible = new Predicate<int>(x => x % number == 0);
            List<int> reverse = new List<int>();

            foreach (var item in numbers)
            {
                if (!divisible(item))
                {
                    reverse.Add(item);
                }
            }

            reverse.Reverse();
            Action<int> print = x => Console.Write(x + " ");
            reverse.ToList().ForEach(print);
            
            Console.WriteLine();
        }
    }
}
