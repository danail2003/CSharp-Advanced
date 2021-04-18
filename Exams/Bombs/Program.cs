using System;
using System.Linq;
using System.Collections.Generic;

namespace Bombs
{
    class Program
    {
        static void Main()
        {
            int[] effects = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] casings = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> bombEffects = new Queue<int>(effects);
            Stack<int> bombCasings = new Stack<int>(casings);

            int daturaCount = 0;
            int cherryCount = 0;
            int smokeDecoyCount = 0;
            bool isFullPouch = false;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                if (bombEffects.Peek() + bombCasings.Peek() == 40)
                {
                    daturaCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (bombEffects.Peek() + bombCasings.Peek() == 60)
                {
                    cherryCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (bombEffects.Peek() + bombCasings.Peek() == 120)
                {
                    smokeDecoyCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    int value = bombCasings.Pop() - 5;
                    bombCasings.Push(value);
                }

                if (daturaCount >= 3 && cherryCount >= 3 && smokeDecoyCount >= 3)
                {
                    isFullPouch = true;
                    break;
                }
            }

            if (isFullPouch)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCount}");
        }
    }
}
