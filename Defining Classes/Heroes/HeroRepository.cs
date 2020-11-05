namespace Heroes
{
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            this.Heroes = new List<Hero>();
        }

        public int Count => this.heroes.Count;

        public List<Hero> Heroes
        {
            get { return this.heroes; }
            set { this.heroes = value; }
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public void Remove(string name)
        {
            foreach (var hero in heroes)
            {
                if (hero.Name == name)
                {
                    this.heroes.Remove(hero);
                    break;
                }
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();

            return hero;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var hero in heroes)
            {
                stringBuilder.AppendLine($"{hero}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
