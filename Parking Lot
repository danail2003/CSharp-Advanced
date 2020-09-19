using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] token = command.Split(", ");

                if (token[0] == "IN")
                {
                    cars.Add(token[1]);
                }
                else if (token[0] == "OUT")
                {
                    cars.Remove(token[1]);
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
