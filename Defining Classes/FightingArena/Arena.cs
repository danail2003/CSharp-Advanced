using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;
        private string name;

        public Arena(string name)
        {
            this.Gladiators = new List<Gladiator>();
            this.Name = name;
        }

        public List<Gladiator> Gladiators
        {
            get { return this.gladiators; }
            set { this.gladiators = value; }
        }

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }       

        public int Count => this.gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            gladiators = gladiators.Where(x => x.Name != name).ToList();
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiator = gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator gladiator = gladiators.OrderByDescending(x => x.GetWeaponPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator gladiator = gladiators.OrderByDescending(x => x.GetTotalPower()).FirstOrDefault();

            return gladiator;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"[{this.Name}] - [{this.gladiators.Count}] gladiators are participating.");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
