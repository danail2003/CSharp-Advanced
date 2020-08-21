using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main()
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(clothes);

            int sum = 0;
            int racks = 1;

            while (box.Count > 0)
            {
                sum += box.Peek();

                if (sum <= capacity)
                {
                    box.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
