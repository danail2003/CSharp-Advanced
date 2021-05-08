using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            int number = parser(Console.ReadLine());
            int[] sequence = Console.ReadLine().Split().Select(parser).ToArray();
            List<int> numbers = new List<int>();
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < sequence.Length; j++)
                {
                    Predicate<int> isDivisible = x => i % sequence[j] == 0;

                    if (isDivisible(i))
                    {
                        counter++;
                    }

                    if (counter == sequence.Length)
                    {
                        numbers.Add(i);
                    }
                }

                counter = 0;
            }

            Action<int> print = x => Console.Write(x + " ");
            numbers.ToList().ForEach(print);
        }
    }
}
