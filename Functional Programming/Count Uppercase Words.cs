using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => char.IsUpper(x[0])).ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
