namespace Heroes
{
    using System.Text;

    public class Item
    {
        private int strength;
        private int ability;
        private int intelligence;

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public int Ability
        {
            get { return this.ability; }
            set { this.ability = value; }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set { this.intelligence = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Item:");
            stringBuilder.AppendLine($"  * Strength: {this.Strength}");
            stringBuilder.AppendLine($"  * Ability: {this.Ability}");
            stringBuilder.AppendLine($"  * Intelligence: {this.Intelligence}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
