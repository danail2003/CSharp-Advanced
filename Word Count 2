using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Word_Count_2
{
    class Program
    {
        static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(new char[] { '\n', '\r', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> allWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                allWords[word] = 0;
            }

            foreach (var word in text)
            {
                if (allWords.ContainsKey(word))
                {
                    allWords[word]++;
                }
            }

            var sorted = allWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            
            File.WriteAllLines("actualResult.txt", allWords.Select(x => $"{x.Key} - {x.Value}"));
            File.WriteAllLines("expectedResult.txt", sorted.Select(x => $"{x.Key} - {x.Value}"));
        }
    }
}
