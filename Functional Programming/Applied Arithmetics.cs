using System;
using System.Linq;
using System.Collections.Generic;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main()
        {
            Func<string, int> parser = new Func<string, int>(int.Parse);
            List<int> numbers = Console.ReadLine().Split().Select(parser).ToList();
            Action<int> print = x => Console.Write(x + " ");

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if (command == "print")
                {
                    numbers.ToList().ForEach(print);
                    Console.WriteLine();
                }
            }
        }
    }
}
