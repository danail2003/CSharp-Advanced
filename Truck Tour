using System;
using System.Linq;
using System.Collections.Generic;

namespace Truck_Tour
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int k = 0;
            int sum = 0;
            int m = 0;
            int[] pumpsInfo = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                int[] pumpInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumpsInfo[i] = pumpInfo[0];
                pumpsInfo[i + n] = pumpInfo[1];
            }

            Queue<int> pumps = new Queue<int>();

            pumps.Enqueue(0);
            m++;
            int amountOfGas = pumpsInfo[0];
            int distanceToNext = pumpsInfo[n];
            sum = amountOfGas - distanceToNext;

            for (int i = 1; i <= n + k; i++)
            {
                if (sum < 0)
                {
                    pumps.Clear();
                    k += m;
                    m = 0;
                    pumps.Enqueue(i);
                    amountOfGas = pumpsInfo[i % n];
                    distanceToNext = pumpsInfo[i % n + n];
                    sum = amountOfGas - distanceToNext;
                }
                else
                {
                    m++;
                    pumps.Enqueue(i);
                    amountOfGas = pumpsInfo[i % n];
                    distanceToNext = pumpsInfo[i % n + n];
                    sum += amountOfGas - distanceToNext;
                }
            }

            Console.WriteLine(pumps.Peek());
        }
    }
}
