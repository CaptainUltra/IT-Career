namespace HeroFight.Entities.Heroes
{
    public class Priest : Hero
    {
        private const double powerMultiplier = 7;
        public Priest(string name) 
            : base(name)
        {
            
        }
        public override double Power
        {
            get
            {
                if (this.Weapon != null)
                {
                    double value = (this.Weapon.Strength + this.Weapon.Agility + this.Weapon.Intelligence) / 3.0;
                    return value + value * powerMultiplier;
                }
                return 0;
            }
            protected set
            {
                base.Power = value;
            }
        }
    }
}