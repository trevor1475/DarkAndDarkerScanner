using System;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Barbarian : BaseCharacter
    {
        private Dictionary<string, bool> _skills = new Dictionary<string, bool>()
        {
            {"Rage", false},
            {"Reckless Attack", false},
            {"Savage Roar", false},
            {"War Cry", false},
            {"Achilles Strike", false},
            {"Blood Exchange", false},
            {"Life Siphon", false}
        };
        public override Dictionary<string, bool> Skills { get { return _skills; } }

        private Dictionary<string, bool> _perks = new Dictionary<string, bool>()
        {
            {"Axe Specialization", false},
            {"Berserker", false},
            {"Carnage", false},
            {"Iron Will", false},
            {"Morale Boost", false},
            {"Savage", false},
            {"Crush", false},
            {"Robust", false},
            {"Two-Hander", false},
            {"Potion Chugger", false},
            {"Executioner", false}
        };

        public override Dictionary<string, bool> Perks { get { return _perks; } }

        public Barbarian()
        {
            Strength = 30;
            Agility = 11;
            Will = 18;
            Knowledge = 6;
        }

        internal override double GetSkillMultiplier()
        {
            return 1;
        }
    }
}
