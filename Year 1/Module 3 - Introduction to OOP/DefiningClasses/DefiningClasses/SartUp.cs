using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Person h1 = new Person();
            h1.Name = "Пешо";
            h1.Age = 9;
            h1.IntroduceYourself();
            BankAccount bacc1 = new BankAccount();
            bacc1.Id = 1;
            bacc1.Balance = 255.56;
            h1.Accounts.Add(bacc1);
            System.Console.WriteLine(h1.GetBalance());

            Person h2 = new Person();
            h2.Name = "Пеперекис Ципорус";
            h2.Age = 35;
            BankAccount bacc2 = new BankAccount();
            bacc2.Id = 124143121;
            bacc2.Balance = 25855.56;
            h2.Accounts.Add(bacc2);
            BankAccount bacc3 = new BankAccount();
            bacc3.Id = 154643645;
            bacc3.Balance = 2522355.595216;
            h2.Accounts.Add(bacc3);
            h2.IntroduceYourself();
            System.Console.WriteLine(h2.GetBalance()); */



            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                var cmdArgs = input.Split(" ");
                switch(cmdArgs[0])
                {
                    case "Create": 
                        Create(cmdArgs, accounts); 
                        break;
                    case "Deposit":
                        Deposit(cmdArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(cmdArgs, accounts); 
                        break;
                    case "Print":
                        Print(cmdArgs, accounts); 
                        break;
                }
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var amount = double.Parse(cmdArgs[2]);
            if(accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amount);
            }
            else
            {
                System.Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var amount = double.Parse(cmdArgs[2]);
            if(accounts.ContainsKey(id))
            {
                if(accounts[id].Balance < amount)
                {
                    System.Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
            else
            {
                System.Console.WriteLine("Account does not exist");
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if(accounts.ContainsKey(id))
            {
                 System.Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                System.Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if(accounts.ContainsKey(id))
            {
                System.Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }
    }
}
