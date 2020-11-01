namespace Christmas
{
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class Bag
    {
        private readonly List<Present> presents;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.presents = new List<Present>();
        }

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count => this.presents.Count;

        public void Add(Present present)
        {
            if (this.Capacity > this.presents.Count)
            {
                this.presents.Add(present);
            }
        }

        public bool Remove(string name)
        {
            foreach (var present in presents)
            {
                if (present.Name == name)
                {
                    this.presents.Remove(present);
                    return true;
                }
            }

            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present present = this.presents.OrderByDescending(x => x.Weight).FirstOrDefault();

            return present;
        }

        public Present GetPresent(string name)
        {
            Present present = this.presents.FirstOrDefault(x => x.Name == name);

            return present;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Color} bag contains:");

            foreach (var present in presents)
            {
                stringBuilder.AppendLine($"Present {present.Name} for a {present.Gender}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
