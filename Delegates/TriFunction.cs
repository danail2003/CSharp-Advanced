using System;
using System.Linq;
using System.Collections.Generic;

namespace TriFunction
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            
            int number = parser(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            
            Func<string, int, bool> isMatch = (a, b) => a.Sum(c => c) >= b;
            Func<Func<string, int, bool>, List<string>, string> returnSum = (a, b) => b.FirstOrDefault(s => a(s, number));
            string result = returnSum(isMatch, names);

            Console.WriteLine(result);
        }
    }
}
