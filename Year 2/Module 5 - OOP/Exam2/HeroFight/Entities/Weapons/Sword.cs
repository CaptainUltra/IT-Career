namespace HeroFight.Entities.Weapons
{
    public class Sword : Weapon
    {
        private const int strengthMultiplier = 3;
        public Sword(string name, int strength, int agility, int intelligence) 
            : base(name, strength + strength * strengthMultiplier, agility, intelligence)
        {
        }
    }
}