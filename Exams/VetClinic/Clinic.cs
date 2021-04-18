using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace VetClinic
{
    public class Clinic
    {
        private readonly List<Pet> pets;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.pets = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count => this.pets.Count;

        public void Add(Pet pet)
        {
            if (this.Capacity > this.pets.Count)
            {
                this.pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = this.pets.FirstOrDefault(x => x.Name == name);

            return this.pets.Remove(pet);
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = this.pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);

            return pet;
        }

        public Pet GetOldestPet()
        {
            Pet pet = this.pets.OrderByDescending(x => x.Age).FirstOrDefault();

            return pet;
        }

        public string GetStatistics()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("The clinic has the following patients:");

            foreach (var pet in this.pets)
            {
                stringBuilder.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
