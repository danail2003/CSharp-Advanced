using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<int, int> even = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!even.ContainsKey(number))
                {
                    even[number] = 0;
                }

                even[number]++;
            }

            foreach (var number in even)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
