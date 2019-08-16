using System;
using System.Collections.Generic;

namespace ExercisePerson
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> secondTeam;
        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.secondTeam = new List<Person>();
        }
        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                secondTeam.Add(person);
            }
        }
        public string Name
        {
            get { return this.name;}
            set {
                    if(value.Length < 3)
                    {
                        throw new ArgumentException("Name must contain at least 3 symbols");
                    }
                    this.name = value;
                }
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly();}
        }
        public IReadOnlyCollection<Person> SecondTeam
        {
            get { return this.secondTeam.AsReadOnly();}
        }
    }
}