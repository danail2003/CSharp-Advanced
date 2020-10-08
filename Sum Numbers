using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            Func<string, int> predicate = new Func<string, int>(int.Parse);
            int[] numbers = Console.ReadLine().Split(", ").Select(predicate).ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
