using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main()
        {
            Func<string, double> predicate = new Func<string, double>(double.Parse);
            double[] numbers = Console.ReadLine().Split(", ").Select(predicate).ToArray();
            Func<double, double> vat = new Func<double, double>(x => x * 1.20);
            double[] endPrice = numbers.Select(vat).ToArray();

            foreach (var price in endPrice)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
