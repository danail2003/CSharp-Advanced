namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tire;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tire)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tire;
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public Tire[] Tire
        {
            get { return this.tire; }
            set { this.tire = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
    }
}
