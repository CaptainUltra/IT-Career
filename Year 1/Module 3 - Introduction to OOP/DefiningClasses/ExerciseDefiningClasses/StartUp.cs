using System;

namespace ExerciseDefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            Person person = new Person(); 
            for (int i = 0; i < n; i++)
            {
                int age = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                person.Age = age;
                person.Name = name;
                family.Members.Add(person);
                person = new Person(); 
            }
            family.GetOrderedMembers();
            family.OldestMember();
            family.AgedOver30();
        }
    }
}
