using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();
            List<Person> members = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] person = Console.ReadLine().Split();

                Person nameAndAge = new Person(person[0], int.Parse(person[1]));
                members.Add(nameAndAge);
            }

            List<Person> sortedMembers = members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var member in sortedMembers)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
