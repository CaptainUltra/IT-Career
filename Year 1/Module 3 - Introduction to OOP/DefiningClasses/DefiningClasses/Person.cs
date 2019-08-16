using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();
        public string Name
        {
            get { return this.name;}
            set { this.name = value;}
        }
        public int Age
        {
            get { return this.age;}
            set { this.age = value;}
        }
        public List<BankAccount> Accounts
        {
            get { return this.accounts;}
            set { this.accounts = value;}
        }
        public void IntroduceYourself()
        {
            System.Console.WriteLine("Hello, I am {0} and I'm {1} years old!", this.name, this.age);
        }
        public double GetBalance()
        {
            return  accounts.Sum(element => element.Balance);
        }        
    }
}
