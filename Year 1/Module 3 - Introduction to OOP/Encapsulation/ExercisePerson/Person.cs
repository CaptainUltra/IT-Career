using System;

namespace ExercisePerson
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;
        private decimal salary;
        public Person(string name, string surname,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string name, string surname,int age, decimal salary) :this(name, surname, age)
        {
            this.Salary = salary;
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
        public string Surname
        {
            get { return this.surname;}
            set {
                    if(value.Length < 3)
                    {
                        throw new ArgumentException("Surame must contain at least 3 symbols");
                    }
                    this.surname = value;
                }
        }
        public int Age
        {
            get { return this.age;}
            set {
                    if(value<=0)
                    {
                        throw new ArgumentException("Age cannot be zero or negative integer");
                    }
                    this.age = value;
                }
        }
        public decimal Salary
        {
            get { return this.salary;}
            set {
                    if(value<460)
                    {
                        throw new ArgumentException("Salary cannnot be less than 460 leva");
                    }
                    this.salary = value;
                }
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Surname} get {this.Salary} leva";
        }
        
    }
}