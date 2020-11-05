namespace Rabbits
{
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class Cage
    {
        private readonly List<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.rabbits.Count;

        public void Add(Rabbit rabbit)
        {
            if (this.rabbits.Count < this.Capacity)
            {
                this.rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = this.rabbits.FirstOrDefault(x => x.Name == name);

            if (rabbit != null)
            {
                this.rabbits.Remove(rabbit);
                return true;
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            for (int i = 0; i < rabbits.Count; i++)
            {
                if (this.rabbits[i].Species == species)
                {
                    this.rabbits.Remove(rabbits[i]);
                    i--;
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.rabbits.FirstOrDefault(x => x.Name == name);
            rabbit.Available = false;

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] bunnies = this.rabbits.Where(x => x.Species == species).ToArray();

            foreach (var bunny in bunnies)
            {
                bunny.Available = false;
            }

            return bunnies;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in rabbits)
            {
                if (rabbit.Available == true)
                {
                    stringBuilder.AppendLine($"Rabbit ({rabbit.Species}): {rabbit.Name}");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
