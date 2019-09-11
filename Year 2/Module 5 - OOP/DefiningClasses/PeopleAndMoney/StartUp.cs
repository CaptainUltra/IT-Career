using System;
using System.Collections.Generic;

namespace PeopleAndMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person person1 = new Person("P1", 22);
            BankAccount account1 = new BankAccount(225, 55);
            person1.Accounts.Add(account1);
            System.Console.WriteLine(person1.GetBalance());
            System.Console.WriteLine(account1.ToString());*/


            var accounts = new Dictionary<int, BankAccount>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split();
                var cmdType = cmdArgs[0];
                switch (cmdType)
                {
                    case "Create": Create(cmdArgs, accounts); break;
                    case "Deposit": Deposit(cmdArgs, accounts); break;
                    case "Withdraw": Withdraw(cmdArgs, accounts); break;
                    case "Print": Print(cmdArgs, accounts); break;
                }
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (!accounts.ContainsKey(id))
                Console.WriteLine("Account doesn't exist!");
            else
            {
                System.Console.WriteLine(accounts[id].ToString());
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var ammount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
                Console.WriteLine("Account doesn't exist!");
            else
            {
                accounts[id].Withdraw(ammount);
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var ammount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
                Console.WriteLine("Account doesn't exist!");
            else
            {
                accounts[id].Deposit(ammount);
            }
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
                Console.WriteLine("Account already exists");
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }
    }
}
