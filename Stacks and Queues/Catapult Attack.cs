using System;
using System.Linq;
using System.Collections.Generic;

namespace Catapult_Attack
{
    class Program
    {
        static void Main()
        {
            int waves = int.Parse(Console.ReadLine());
            List<int> spartanWalls = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> trojanRocks = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                int[] trojans = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (spartanWalls.Any())
                {
                    for (int j = 0; j < trojans.Length; j++)
                    {
                        trojanRocks.Push(trojans[j]);
                    }

                    if (i % 3 == 0)
                    {
                        int plate = int.Parse(Console.ReadLine());
                        spartanWalls.Add(plate);
                    }
                }

                while (trojanRocks.Any() && spartanWalls.Any())
                {
                    if (trojanRocks.Peek() > spartanWalls[0])
                    {
                        int diff = trojanRocks.Pop() - spartanWalls[0];
                        trojanRocks.Push(diff);
                        spartanWalls.RemoveAt(0);
                    }
                    else if (trojanRocks.Peek() < spartanWalls[0])
                    {
                        spartanWalls[0] -= trojanRocks.Pop();
                    }
                    else
                    {
                        trojanRocks.Pop();
                        spartanWalls.RemoveAt(0);
                    }
                }
            }


            if (spartanWalls.Any())
            {
                Console.WriteLine($"Walls left: {string.Join(", ", spartanWalls)}");
            }
            else if (trojanRocks.Any())
            {
                Console.WriteLine($"Rocks left: {string.Join(", ", trojanRocks)}");
            }
        }
    }
}
