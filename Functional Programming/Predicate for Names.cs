using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            int length = parser(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Predicate<string> isLessOrEqual = new Predicate<string>(x => x.Length <= length);
            List<string> endNames = new List<string>();

            foreach (var name in names)
            {
                if (isLessOrEqual(name))
                {
                    endNames.Add(name);
                }
            }

            Action<string> print = x => Console.WriteLine(x);
            endNames.ToList().ForEach(print);
        }
    }
}
