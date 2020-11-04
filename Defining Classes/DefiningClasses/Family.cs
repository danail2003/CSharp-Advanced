namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    class Family
    {
        private readonly List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = people.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }
    }
}
