using System;
using System.Linq;

namespace Action_Print
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split();
            Action<string> print = (x) => Console.WriteLine(x);
            names.ToList().ForEach(print);
        }
    }
}
