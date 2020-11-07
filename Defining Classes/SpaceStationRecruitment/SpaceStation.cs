namespace SpaceStationRecruitment
{
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class SpaceStation
    {
        private List<Astronaut> astronauts;
        private string name;
        private int capacity;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Astronaut = new List<Astronaut>();
        }

        public List<Astronaut> Astronaut
        {
            get { return this.astronauts; }
            set { this.astronauts = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public int Count => astronauts.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.astronauts.Count < Capacity)
            {
                this.astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Name == name)
                {
                    this.astronauts.Remove(astronaut);
                    return true;
                }
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut astronaut = astronauts.OrderByDescending(x => x.Age).FirstOrDefault();
            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.astronauts.FirstOrDefault(x => x.Name == name);
            return astronaut;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astronaut in astronauts)
            {
                stringBuilder.AppendLine($"Astronaut: {astronaut.Name}, {astronaut.Age} ({astronaut.Country})");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
