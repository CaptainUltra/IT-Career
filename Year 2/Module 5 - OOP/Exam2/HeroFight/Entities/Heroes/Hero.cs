namespace HeroFight.Entities.Heroes
{
    using HeroFight.Entities.Weapons;
    using Contracts;
    using System;
    using System.Text;

    public abstract class Hero : IHero
    {
        private string name;
        private int experience;
        private double power;
        protected Hero(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null, empty or whitespace.");
                }
                this.name = value;
            }
        }

        public int Level { get; private set; }

        public int Experience
        {
            get
            {
                return this.experience;
            }
            set
            {
                if (this.experience + value >= 100)
                {
                    this.experience = this.experience + value - 100;
                    this.Level++;
                }
                else
                this.experience += value;
            }
        }

        public Weapon Weapon {get; set;}

        public virtual double Power
        {
            get
            {
                if (this.Weapon != null)
                {
                    double value = (this.Weapon.Strength + this.Weapon.Agility + this.Weapon.Intelligence) / 3.0;
                    return value;
                }
                return 0;
            }
            protected set
            {
                this.power = value;
            }
        }
    }
}