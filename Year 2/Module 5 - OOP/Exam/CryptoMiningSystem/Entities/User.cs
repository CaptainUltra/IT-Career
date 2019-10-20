namespace CryptoMiningSystem.Entities
{
    using System;
    using Contracts;
    public class User : IUser
    {
        private string name;
        private decimal money;

        public User(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.Computer = null;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }
                this.name = value;
            }
        }

        public int Stars => (int) this.Money / 100;

        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("User's money cannot be less than 0!");
                }
                this.money = value;
            }
        }

        public Computer Computer { get; set;}
    }
}