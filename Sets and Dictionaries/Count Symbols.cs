using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols[text[i]] = 0;
                }

                symbols[text[i]] += 1;
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
