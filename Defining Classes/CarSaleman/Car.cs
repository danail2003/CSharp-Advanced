namespace CarSaleman
{
    using System.Text;

    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Model}:").AppendLine($"  {this.Engine}");

            if (this.Weight == 0)
            {
                stringBuilder.AppendLine(" Weight: n/a");
            }
            else
            {
                stringBuilder.AppendLine($" Weight: {this.Weight}");
            }

            stringBuilder.AppendLine($" Color: {this.Color}");

            return stringBuilder.ToString().Trim();
        }
    }
}
