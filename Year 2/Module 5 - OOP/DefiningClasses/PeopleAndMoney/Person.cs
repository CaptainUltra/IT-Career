using System.Collections.Generic;
using System.Linq;

public class Person
{
    private static int count = 0;
    private string name;
    private int age;
    private List<BankAccount> accounts = new List<BankAccount>();
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        Person.count +=1;
    }
    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = accounts;
        Person.count += 1;
    }
    public static int Count
    {
        get{return count};
    }

    public decimal GetBalance()
    {
        return this.Accounts.Sum(x => x.Balance);
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public List<BankAccount> Accounts
    {
        get { return this.accounts; }
        set { this.accounts = value; }
    }
}