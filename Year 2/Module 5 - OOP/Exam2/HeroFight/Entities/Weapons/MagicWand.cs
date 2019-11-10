namespace HeroFight.Entities.Weapons
{
    public class MagicWand : Weapon
    {
        private const int intelligenceMultiplier = 4;
        public MagicWand(string name, int strength, int agility, int intelligence) 
            : base(name, strength, agility, intelligence + intelligence * intelligenceMultiplier)
        {
        }
    }
}