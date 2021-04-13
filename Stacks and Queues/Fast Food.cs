using System;
using System.Linq;
using System.Collections.Generic;

namespace Fast_Food
{
    class Program
    {
        static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int order = queue.Peek();

                if (quantityOfFood >= order)
                {
                    quantityOfFood -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", queue));
            }
        }
    }
}
