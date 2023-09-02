using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Wizard : BaseCharacter
    {

        private Dictionary<string, bool> _skills = new Dictionary<string, bool>()
        {
            {"Magic Missles", false},
            {"Fireball", false},
            {"Direct Hit", false},
            {"Splash Damage", false}
        };
        public override Dictionary<string, bool> Skills { get { return _skills; } }

        private Dictionary<string, bool> _perks = new Dictionary<string, bool>()
        {
            {"Mana Surge", false},
            {"Arcane Feedback", false},
            {"Arcane Mastery", false},
            {"Fire Mastery", false}
        };

        public override Dictionary<string, bool> Perks { get { return _perks; } }

        public Wizard()
        {
            Strength = 5;
            Agility = 20;
            Will = 33;
            Knowledge = 12;

            IsMagicUser = true;
        }

        internal override double GetSkillMultiplier()
        {
            double multiplier = 1;

            if (Perks["Mana Surge"])
            {
                multiplier += 0.05;
            }
            if (Perks["Arcane Feedback"] && Skills["Magic Missles"])
            {
                multiplier += 0.05;
            }
            if (Perks["Arcane Mastery"] && Skills["Magic Missles"])
            {
                multiplier += 0.05;
            }
            if (Perks["Fire Mastery"] && Skills["Fireball"])
            {
                multiplier += 0.05;
            }

            return multiplier;
        }
    }
}
