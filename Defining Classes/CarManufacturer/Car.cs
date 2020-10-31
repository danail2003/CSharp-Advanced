namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Pressure { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Pressure = tires;
        }

        public void Drive(double distance)
        {
            double fuel = FuelConsumption * distance / 100;

            if (fuel > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= fuel;
            }
        }

        public string WhoAmI()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"Make: {this.Make}");
            print.AppendLine($"Model: {this.Model}");
            print.AppendLine($"Year: {this.Year}");
            print.Append($"Fuel: {this.FuelQuantity:f2}L");

            return print.ToString();
        }
    }
}
