namespace PokemonTrainer
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (command != "Tournament")
            {
                string[] info = command.Split();

                Pokemon pokemon = new Pokemon(info[1], info[2], int.Parse(info[3]));

                if (!trainers.ContainsKey(info[0]))
                {
                    trainers[info[0]] = new Trainer(info[0]);
                }

                trainers[info[0]].Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        if (trainer.Pokemons[i].Health <= 0)
                        {
                            trainer.Pokemons.Remove(trainer.Pokemons[i]);
                        }
                    }
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
