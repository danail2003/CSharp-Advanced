using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            HashSet<string> guests = new HashSet<string>();
            string command = Console.ReadLine();
            bool hasParty = false;

            while (command != "END")
            {
                if (command == "PARTY")
                {
                    hasParty = true;
                }

                if (!hasParty)
                {
                    guests.Add(command);
                }
                else
                {
                    guests.Remove(command);
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests.OrderByDescending(x => char.IsDigit(x[0])))
            {
                Console.WriteLine(guest);
            }
        }
    }
}
