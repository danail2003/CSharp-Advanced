namespace RawData
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int j = 5; j < carInfo.Length; j += 2)
                {
                    double pressure = double.Parse(carInfo[j]);
                    int age = int.Parse(carInfo[j + 1]);

                    Tire tire = new Tire(pressure, age);
                    tires[counter++] = tire;
                }

                Engine engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                Cargo cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                Car car = new Car(carInfo[0], engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tire.Any(x => x.TirePressure < 1)).ToList().ForEach(x => Console.WriteLine(x.Model));
            }
            else if (command == "flamable")
            {
                cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList().ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
