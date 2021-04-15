using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] allLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> shoots = new Stack<int>(bullets);
            Queue<int> locks = new Queue<int>(allLocks);

            int usedBullets = 0;
            int reloading = 0;
            bool isBreak = true;
            int leftBullets = shoots.Count;
            int leftLocks = locks.Count;

            while (locks.Count > 0)
            {
                if (shoots.Any() && shoots.Peek() > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    shoots.Pop();
                    usedBullets++;
                    leftBullets -= 1;
                }
                else
                {
                    if (shoots.Any())
                    {
                        Console.WriteLine("Bang!");
                        shoots.Pop();
                        locks.Dequeue();
                        usedBullets++;
                        leftBullets -= 1;
                        leftLocks -= 1;
                    }
                }
               
                reloading++;               

                if(leftBullets == 0 && leftLocks > 0)
                {
                    isBreak = false;
                    break;
                }

                if (reloading == sizeOfBarrel && leftBullets > 0)
                {
                    Console.WriteLine("Reloading!");
                    reloading = 0;
                }
            }

            if (isBreak)
            {
                int sum = usedBullets * priceOfBullet;
                int total = intelligence - sum;
                Console.WriteLine($"{leftBullets} bullets left. Earned ${total}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
