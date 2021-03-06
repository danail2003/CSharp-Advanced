using System;
using System.Linq;
using System.Collections.Generic;

namespace Filter_By_Age
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            int names = int.Parse(Console.ReadLine());

            for (int i = 0; i < names; i++)
            {
                string[] name = Console.ReadLine().Split(", ");

                if (!people.ContainsKey(name[0]))
                {
                    people[name[0]] = int.Parse(name[1]);
                }
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Dictionary<string, int> person = new Dictionary<string, int>();

            if (format == "name")
            {
                if (condition == "younger")
                {                    
                    person = people.Where(x => x.Value < age).ToDictionary(x => x.Key, x => x.Value);
                }
                else if (condition == "older")
                {
                    person = people.Where(x => x.Value >= age).ToDictionary(x => x.Key, x => x.Value);
                }

                foreach (var item in person)
                {
                    Console.WriteLine(item.Key);
                }
            }
            else if (format == "age")
            {
                if (condition == "younger")
                {
                    person = people.Where(x => x.Value < age).ToDictionary(x => x.Key, x => x.Value);
                }
                else if (condition == "older")
                {
                    person = people.Where(x => x.Value >= age).ToDictionary(x => x.Key, x => x.Value);
                }

                foreach (var item in person)
                {
                    Console.WriteLine(item.Value);
                }
            }
            else if (format == "name age")
            {
                if (condition == "younger")
                {
                    person = people.Where(x => x.Value < age).ToDictionary(x => x.Key, x => x.Value);
                }
                else if (condition == "older")
                {
                    person = people.Where(x => x.Value >= age).ToDictionary(x => x.Key, x => x.Value);
                }

                foreach (var item in person)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
