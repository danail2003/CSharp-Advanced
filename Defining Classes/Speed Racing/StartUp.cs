namespace SpeedRacing
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int countOfCars = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();

                Car car = new Car
                {
                    Model = inputInfo[0],
                    FuelAmount = double.Parse(inputInfo[1]),
                    FuelConsumptionPerKilometer = double.Parse(inputInfo[2])
                };

                allCars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] drive = command.Split();
                double distance = double.Parse(drive[2]);

                allCars.Where(x => x.Model == drive[1]).ToList().ForEach(x => x.Travelled(distance));

                command = Console.ReadLine();
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
