namespace Guild
{
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Guild
    {
        private readonly List<Player> players;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.players = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.players.Count;

        public void AddPlayer(Player player)
        {
            if (this.Capacity > this.players.Count)
            {
                this.players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            foreach (var player in players)
            {
                if (player.Name == name)
                {
                    this.players.Remove(player);
                    return true;
                }
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name);

            if (player.Rank == "Trial")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name);

            if (player.Rank == "Member")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string classw)
        {
            Player[] kickedPlayers = this.players.Where(x => x.Class == classw).ToArray();
            this.players.RemoveAll(x => x.Class == classw);

            return kickedPlayers;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in players)
            {
                stringBuilder.AppendLine($"Player {player.Name}: {player.Class}");
                stringBuilder.AppendLine($"Rank: {player.Rank}");
                stringBuilder.AppendLine($"Description: {player.Description}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
