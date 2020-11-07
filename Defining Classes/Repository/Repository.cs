namespace Repository
{
    using System.Collections.Generic;

    public class Repository
    {
        private Dictionary<int, Person> people;
        private int id = 0;

        public Repository()
        {
            this.People = new Dictionary<int, Person>();
            this.ID = id;
        }

        public int Count => this.people.Count;

        public Dictionary<int, Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public void Add(Person person)
        {
            this.people.Add(id++, person);
        }

        public Person Get(int id)
        {
            foreach (var person in people)
            {
                if (person.Key == id)
                {
                    return person.Value;
                }
            }

            return null;
        }

        public bool Update(int id, Person newPerson)
        {
            foreach (var person in people)
            {
                if (person.Key == id)
                {
                    this.people[id] = newPerson;
                    return true;
                }
            }

            return false;
        }

        public bool Delete(int id)
        {
            foreach (var person in people)
            {
                if (person.Key == id)
                {
                    this.people.Remove(id);
                    return true;
                }
            }

            return false;
        }
    }
}
