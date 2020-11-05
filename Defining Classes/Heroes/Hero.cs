namespace Heroes
{
    using System.Text;

    public class Hero
    {
        private string name;
        private int level;
        private Item item;

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public Item Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            stringBuilder.AppendLine($"Item:");
            stringBuilder.AppendLine($"  * Strength: {this.Item.Strength}");
            stringBuilder.AppendLine($"  * Ability: {this.Item.Ability}");
            stringBuilder.AppendLine($"  * Intelligence: {this.Item.Intelligence}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
