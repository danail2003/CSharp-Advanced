using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]] = 0;
                }

                dict[numbers[i]] += 1;
            }

            foreach (var number in dict)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
