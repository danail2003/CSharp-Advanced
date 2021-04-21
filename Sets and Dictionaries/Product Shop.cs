using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main()
        {
            SortedDictionary <string, Dictionary<string, double>> shopsPrices = new SortedDictionary <string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] token = command.Split(", ");

                if (!shopsPrices.ContainsKey(token[0]))
                {
                    shopsPrices[token[0]] = new Dictionary<string, double>();
                }

                if (!shopsPrices[token[0]].ContainsKey(token[1]))
                {
                    shopsPrices[token[0]][token[1]] = double.Parse(token[2]);
                }

                command = Console.ReadLine();
            }

            foreach (var shop in shopsPrices)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
