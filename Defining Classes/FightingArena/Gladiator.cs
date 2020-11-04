namespace FightingArena
{
    using System.Text;

    public class Gladiator
    {
        private string name;
        private Stat stat;
        private Weapon weapon;

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Stat Stat
        {
            get { return this.stat; }
            set { this.stat = value; }
        }

        public Weapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public int GetTotalPower()
        {
            int sum = stat.Agility + stat.Flexibility + stat.Intelligence + stat.Skills + stat.Strength + weapon.Sharpness + weapon.Size + weapon.Solidity;

            return sum;
        }

        public int GetWeaponPower()
        {
            int sum = weapon.Solidity + weapon.Size + weapon.Sharpness;

            return sum;
        }

        public int GetStatPower()
        {
            int sum = stat.Strength + stat.Skills + stat.Intelligence + stat.Flexibility + stat.Agility;

            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"[{this.Name}] - [{GetTotalPower()}]");
            stringBuilder.AppendLine($"  Weapon Power: [{GetWeaponPower()}]");
            stringBuilder.AppendLine($"  Stat Power: [{GetStatPower()}]");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
