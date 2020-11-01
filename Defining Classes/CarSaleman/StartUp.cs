namespace CarSaleman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int countOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine();

                engine.Model = engineInfo[0];
                engine.Power = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 3)
                {

                    if (int.TryParse(engineInfo[2], out int displacement))
                    {
                        engine.Displacement = int.Parse(engineInfo[2]);
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    engine.Displacement = int.Parse(engineInfo[2]);
                    engine.Efficiency = engineInfo[3];
                }

                engines.Add(engine);
            }

            int countOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Engine engine = engines.FirstOrDefault(x => x.Model == carsInfo[1]);
                engine.Model = carsInfo[1];

                Car car = new Car(engine);

                car.Model = carsInfo[0];

                if (carsInfo.Length == 3)
                {
                    if (int.TryParse(carsInfo[2], out int weight))
                    {
                        car.Weight = int.Parse(carsInfo[2]);
                    }
                    else
                    {
                        car.Color = carsInfo[2];
                    }
                }
                else if (carsInfo.Length == 4)
                {
                    car.Weight = int.Parse(carsInfo[2]);
                    car.Color = carsInfo[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
