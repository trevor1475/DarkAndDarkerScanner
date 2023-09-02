using System;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Fighter : BaseCharacter
    {
        private Dictionary<string, bool> _skills = new Dictionary<string, bool>()
        {
            {"Adrenaline Rush", false},
            {"Breakthrough", false},
            {"Second Wind", false},
            {"Sprint", false},
            {"Taunt", false},
            {"Victory Strike", false},
            {"Perfect Block", false},
            {"Shield Slam", false}
        };
        public override Dictionary<string, bool> Skills { get { return _skills; } }

        private Dictionary<string, bool> _perks = new Dictionary<string, bool>()
        {
            {"Barricade", false},
            {"Combo Attack", false},
            {"Counterattack", false},
            {"Defense Expert", false},
            {"Dual Wield", false},
            {"Projectile Resistance", false},
            {"Shield Expert", false},
            {"Swift", false},
            {"Weapon Mastery", false},
            {"Adrenaline Spike", false},
            {"Slayer", false}
        };
        public override Dictionary<string, bool> Perks { get { return _perks; } }

        public Fighter()
        {
            Strength = 15;
            Agility = 15;
            Will = 15;
            Knowledge = 15;
        }

        internal override double GetSkillMultiplier()
        {
            throw new NotImplementedException();
        }
    }
}
