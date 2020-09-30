using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            int[] numbers = Console.ReadLine().Split().Select(parser).ToArray();
            Func<int[], int> minNumber = new Func<int[], int>(x => numbers.Min());
            int number = minNumber(numbers);
            Console.WriteLine(number);
        }
    }
}
