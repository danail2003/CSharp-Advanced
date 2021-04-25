using System;
using System.Linq;
using System.Collections.Generic;

namespace Santa_s_Present_Factory
{
    class Program
    {
        static void Main()
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> magics = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> products = new Dictionary<string, int>();
            products["Doll"] = 0;
            products["Wooden train"] = 0;
            products["Teddy bear"] = 0;
            products["Bicycle"] = 0;

            while (materials.Any() && magics.Any())
            {
                if (materials.Peek() * magics.Peek() == 150)
                {
                    products["Doll"]++;
                    magics.Dequeue();
                    materials.Pop();
                }
                else if (materials.Peek() * magics.Peek() == 250)
                {
                    products["Wooden train"]++;
                    materials.Pop();
                    magics.Dequeue();
                }
                else if (materials.Peek() * magics.Peek() == 300)
                {
                    products["Teddy bear"]++;
                    magics.Dequeue();
                    materials.Pop();
                }
                else if (materials.Peek() * magics.Peek() == 400)
                {
                    products["Bicycle"]++;
                    materials.Pop();
                    magics.Dequeue();
                }
                else if (magics.Peek() * materials.Peek() < 0)
                {
                    int diff = materials.Peek() + magics.Peek();
                    magics.Dequeue();
                    materials.Pop();
                    materials.Push(diff);
                }
                else if (materials.Peek() * magics.Peek() > 0)
                {
                    magics.Dequeue();
                    materials.Push(materials.Pop() + 15);
                }
                else if (materials.Peek() == 0 || magics.Peek() == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();
                    }

                    if (magics.Peek() == 0)
                    {
                        magics.Dequeue();
                    }
                }
            }

            if (products["Doll"] >= 1 && products["Wooden train"] >= 1 || products["Teddy bear"] >= 1 && products["Bicycle"] >= 1)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            else if (magics.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magics)}");
            }

            foreach (var present in products.OrderBy(x => x.Key))
            {
                if (present.Value > 0)
                {
                    Console.WriteLine($"{present.Key}: {present.Value}");
                }
            }
        }
    }
}
