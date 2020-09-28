using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            int[] numbers = Console.ReadLine().Split().Select(parser).ToArray();
            Func<int, int, int> comparator = (x1, x2) => (x1 % 2 == 0 && x2 % 2 != 0) ? -1 : (x1 % 2 != 0 && x2 % 2 == 0) ? 1 : x1.CompareTo(x2);
            Array.Sort(numbers, new Comparison<int>(comparator));
            Action<int> print = x => Console.Write(x + " ");
            numbers.ToList().ForEach(print);
        }
    }
}
