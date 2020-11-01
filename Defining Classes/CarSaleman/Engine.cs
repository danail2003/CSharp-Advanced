namespace CarSaleman
{
    using System.Text;

    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine()
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Model}:").AppendLine($"   Power: {this.Power}");

            if (this.Displacement == 0)
            {
                stringBuilder.AppendLine($"   Displacement: n/a");
            }
            else
            {
                stringBuilder.AppendLine($"   Displacement: {this.Displacement}");
            }

            stringBuilder.AppendLine($"   Efficiency: {this.Efficiency}");

            return stringBuilder.ToString().Trim();
        }
    }
}
