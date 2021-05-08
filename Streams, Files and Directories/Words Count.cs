using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Words_Count
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> keys = new Dictionary<string, int>();
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '.', '-', ',', '?', ' ', '!', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                keys[word] = 0;
            }

            foreach (var word in text)
            {
                if (keys.ContainsKey(word))
                {
                    keys[word]++;
                }
            }

            var count = keys.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            File.WriteAllLines("Output.txt", count.Select(x => $"{x.Key} - {x.Value}"));
        }
    }
}
