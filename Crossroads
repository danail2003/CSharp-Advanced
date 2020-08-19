using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counter = 0;

            Queue<string> car = new Queue<string>();

            while (command != "END")
            {
                int greenSeconds = greenLight;
                int freeSeconds = freeWindow;

                if (command == "green")
                {
                    while(greenSeconds > 0 && car.Count > 0)
                    {
                        string currentCar = car.Dequeue();
                        greenSeconds -= currentCar.Length;

                        if (greenSeconds >= 0)
                        {
                            counter++;
                        }
                        else
                        {
                            freeSeconds += greenSeconds;

                            if (freeSeconds < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length + freeSeconds]}.");
                                return;
                            }

                            counter++;
                        }
                    }
                }
                else
                {
                    car.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
