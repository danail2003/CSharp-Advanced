namespace SpaceStationRecruitment
{
    using System.Text;

    public class Astronaut
    {
        private string name;
        private int age;
        private string country;

        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Astronaut: {this.Name}, {this.Age} ({this.Country})");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
