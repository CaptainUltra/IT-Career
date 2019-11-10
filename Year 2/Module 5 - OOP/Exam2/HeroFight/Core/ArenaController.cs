namespace HeroFight.Core
{
    using HeroFight.Entities.Heroes;
    using HeroFight.Entities.Weapons;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArenaController : IArenaController
    {
        private Dictionary<string, Hero> heroes;

        public ArenaController()
        {
            this.heroes = new Dictionary<string, Hero>();
        }

        public string CreateHero(List<string> args)
        {
            var heroType = args[0];
            var heroName = args[1];
            Hero hero = null;
            string result = "";
            switch (heroType)
            {
                case "Assassin":
                    {
                        hero = new Assassin(heroName);
                        break;
                    }
                case "Warrior":
                    {
                        hero = new Warrior(heroName);
                        break;
                    }
                case "Priest":
                    {
                        hero = new Priest(heroName);
                        break;
                    }
                default: return $"Invalid type hero: {heroType}.";
            }
            if (!heroes.ContainsKey(heroName))
            {
                this.heroes.Add(heroName, hero);
                result = $"{heroType}: {heroName} joined the Arena!";
            }
            else
            {
                result = $"Hero with name: {heroName} already exists!";
            }
            return result;

        }
        public string CreateWeapon(List<string> args)
        {
            var heroName = args[0];
            var weaponType = args[1];
            var weaponName = args[2];
            var strength = int.Parse(args[3]);
            var agility = int.Parse(args[4]);
            var intelligence = int.Parse(args[5]);
            string result = "";
            if (heroes.ContainsKey(heroName))
            {
                Weapon weapon = null;
                switch (weaponType)
                {
                    case "Bow":
                        {
                            weapon = new Bow(weaponName, strength, agility, intelligence);
                            break;
                        }
                    case "MagicWand":
                        {
                            weapon = new MagicWand(weaponName, strength, agility, intelligence);
                            break;
                        }
                    case "Sword":
                        {
                            weapon = new Sword(weaponName, strength, agility, intelligence);
                            break;
                        }
                    default: return $"Invalid type weapon: {weaponType}.";
                }
                this.heroes[heroName].Weapon = weapon;
                result = $"Successfully armed hero {heroName} with weapon {weaponType}!";
            }
            else
            {
                result = $"Hero with name: {heroName} does not exist!";
            }
            return result;
        }
        public string Fight(List<string> args)
        {
            var heroName1 = args[0];
            var heroName2 = args[1];
            if (!this.heroes.ContainsKey(heroName1))
            {
                return $"Hero with name: {heroName1} does not exist!";
            }
            if (!this.heroes.ContainsKey(heroName2))
            {
                return $"Hero with name: {heroName2} does not exist!";
            }
            var hero1 = this.heroes[heroName1];
            var hero2 = this.heroes[heroName2];
            string winnerName = "";
            double difference = 0;
            if (hero1.Power > hero2.Power)
            {
                winnerName = heroName1;
                difference = hero1.Power - hero2.Power;
                hero1.Experience = 30;
            }
            else if (hero1.Power == hero2.Power)
            {
                difference = 0;
                hero1.Experience = 15;
                hero2.Experience = 15;
            }
            else
            {
                winnerName = heroName2;
                difference = hero2.Power - hero1.Power;
                hero2.Experience = 30;
            }
            if (difference > 0)
                return $"Winner in the battle between {heroName1} and {heroName2} is {winnerName} with {difference:F2}.";
            return $"No winner in battle between {heroName1} and {heroName2}!";
        }
        public string HeroInfo(List<string> args)
        {
            var heroName = args[0];
            StringBuilder result = new StringBuilder();
            if (this.heroes.ContainsKey(heroName))
            {
                var hero = this.heroes[heroName];
                var heroType = hero.GetType().Name;
                var heroLevel = hero.Level;
                var heroExperience = hero.Experience;
                var heroPower = hero.Power;
                result.AppendLine($"{heroType}: {heroName} - Level: {heroLevel}");
                result.AppendLine($"Experience: {heroExperience}");
                if (hero.Weapon != null)
                {
                    var weaponType = hero.Weapon.GetType().Name;
                    var weaponName = hero.Weapon.Name;
                    var weaponStrength = hero.Weapon.Strength;
                    var weaponAgility = hero.Weapon.Agility;
                    var weaponIntelligence = hero.Weapon.Intelligence;
                    result.AppendLine($"{weaponType}: {weaponName}");
                    result.AppendLine($"  *Strength: {weaponStrength}");
                    result.AppendLine($"  *Agility: {weaponAgility}");
                    result.AppendLine($"  *Intelligence: {weaponIntelligence}");
                }
                result.Append($"Power: {heroPower:F2}");
            }
            else
            {
                result.Append($"Hero with name: {heroName} does not exist!");
            }
            return result.ToString();
        }
        public string CloseArena()
        {
            StringBuilder result = new StringBuilder();
            var heroesCount = this.heroes.Count;
            result.AppendLine($"Heroes: {heroesCount}");
            var sortedHeroes = this.heroes
                .OrderByDescending(x => x.Value.Level)
                .ThenByDescending(x => x.Value.Power)
                .ThenBy(x => x.Key);
            if (sortedHeroes.Count() > 0)
            {
                foreach (var hero in sortedHeroes)
                {
                    var heroName = hero.Key;
                    List<string> args = new List<string>();
                    args.Add(heroName);
                    result.AppendLine(this.HeroInfo(args));
                    
                }
            }
            else
            {
                foreach (var hero in sortedHeroes)
                {
                    var heroName = hero.Key;
                    List<string> args = new List<string>();
                    args.Add(heroName);
                    result.Append(this.HeroInfo(args));
                }
            }
            return result.ToString().Trim();
        }
    }
}