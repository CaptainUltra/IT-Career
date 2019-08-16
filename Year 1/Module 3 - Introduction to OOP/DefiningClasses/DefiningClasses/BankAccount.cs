using System;

namespace DefiningClasses
{
    public class BankAccount
    {
        private int id;
        public int Id
        {
            get { return this.id;}
            set { this.id = value;}
        }
        private double balance;
        public double Balance
        {
            get { return this.balance;}
            set 
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("There cannnot be negative balance!");
                } 
                this.balance = value;
            }
        }
        public void Deposit(double ammount)
        {
            if(ammount<0) throw new ArgumentOutOfRangeException("Negative ammount cannot be deposited!");
            this.Balance = this.balance + ammount;
        }
        public void Withdraw(double ammount)
        {
            if(this.balance < ammount) throw new Exception("Ammount greater than balance cannot be withdrawn!");
            this.Balance = this.balance - ammount;
        } 
        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance}";
        }
    }
}