using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main()
        {
            int countOfCars = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int counter = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < countOfCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            counter++;
                            string passed = cars.Dequeue();

                            Console.WriteLine($"{passed} passed!");
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
