namespace Guild
{
    using System.Text;

    public class Player
    {
        public Player(string name, string classw)
        {
            this.Name = name;
            this.Class = classw;
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public string Name { get; set; }
        public string Class { get; set; }

        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Player {Name}: {Class}");
            stringBuilder.AppendLine($"Rank: {Rank}");
            stringBuilder.AppendLine($"Description: {Description}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
