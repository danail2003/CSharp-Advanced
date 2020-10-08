using System;
using System.Linq;
using System.Collections.Generic;

namespace The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main()
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                string[] commands = command.Split(";");

                if (commands[0] == "Add filter")
                {
                    filters.Add(commands[1] + " " + commands[2]);
                }
                else if (commands[0] == "Remove filter")
                {
                    filters.Remove(commands[1] + " " + commands[2]);
                }
            }

            foreach (var filter in filters)
            {
                string[] commands = filter.Split(' ');

                if (commands[0] == "Starts")
                {
                    guests = guests.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    guests = guests.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    guests = guests.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    guests = guests.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            Console.WriteLine(string.Join(" ", guests));
        }
    }
}
