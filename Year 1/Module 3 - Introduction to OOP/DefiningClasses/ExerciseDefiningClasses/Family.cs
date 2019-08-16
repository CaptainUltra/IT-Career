using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseDefiningClasses
{
    class Family
    {
        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get { return this.members;}
            set { this.members = value;}
        }
        
        public void GetMembers()
        {
            foreach (var member in members)
            {
                System.Console.WriteLine($"{member.Name} {member.Age}");
            }
        }
        public void GetOrderedMembers()
        {
           foreach (var member in members.OrderBy(x => x.Name))
            {
                System.Console.WriteLine($"{member.Name} {member.Age}");
            } 
        }
        
        public void OldestMember()
        {
            Person person = this.members.OrderByDescending(x => x.Age).FirstOrDefault();
            System.Console.WriteLine($"{person.Name} {person.Age}");
        }
        public void AgedOver30()
        {
            foreach (var member in members.OrderBy(x => x.Name))
            {
                if(member.Age >= 30)System.Console.WriteLine($"{member.Name} {member.Age}");
            } 
        }
    }
}