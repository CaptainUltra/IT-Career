namespace HeroFight.Entities.Weapons
{
    public class Bow : Weapon
    {
        private const int strengthMultiplier = 1;
        private const int agilityMultiplier = 2;
        public Bow(string name, int strength, int agility, int intelligence) 
            : base(name, strength + strength * strengthMultiplier, agility + agility * agilityMultiplier, intelligence)
        {
        }
    }
}