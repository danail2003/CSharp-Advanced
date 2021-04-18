namespace Parking
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    public class Parking
    {
        private readonly List<Car> cars; 

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.cars = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => this.cars.Count;

        public void Add(Car car)
        {
            if (this.cars.Count < this.Capacity)
            {
                this.cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = this.cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);

            return this.cars.Remove(car);
        }

        public Car GetLatestCar()
        {
            if (this.cars.Count == 0)
            {
                return null;
            }

            Car car = this.cars.First();

            foreach (var currentCar in this.cars)
            {
                if (currentCar.Year > car.Year)
                {
                    car = currentCar;
                }
            }

            return car;
        }

        public Car GetCar(string manufacturer, string model)
        {
            return this.cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }

        public string GetStatistics()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in this.cars)
            {
                stringBuilder.AppendLine(car.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
