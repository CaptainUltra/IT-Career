namespace HeroFight.Entities.Weapons
{
    using Contracts;
    using System;
    using System.Text;

    public abstract class Weapon : IWeapon
    {
        private string name;
        private int strength;
        private int agility;
        private int intelligence;
        protected Weapon(string name, int strength, int agility, int intelligence)
        {
            this.Name = name;
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Weapon name cannot be null, empty or whitespace.");
                }
                this.name = value;
            }
        }

        public int Strength
        {
            get
            {
                return this.strength;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Strength cannot be less than 0!");
                }
                this.strength = value;
            }
        }

        public int Agility
        {
            get
            {
                return this.agility;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Agility cannot be less than 0!");
                }
                this.agility = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return this.intelligence;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Intelligence cannot be less than 0!");
                }
                this.intelligence = value;
            }
        }
    }
}