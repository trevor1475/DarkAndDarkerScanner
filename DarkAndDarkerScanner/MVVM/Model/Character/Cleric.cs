using System;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Cleric : BaseCharacter
    {
        private Dictionary<string, bool> _skills = new Dictionary<string, bool>()
        {
            {"Holy Purification", false},
            {"Judgement", false},
            {"Smite", false},
            {"Spell Memory", false},
            {"Divine Protection", false}
        };
        public override Dictionary<string, bool> Skills { get { return _skills; } }

        private Dictionary<string, bool> _perks = new Dictionary<string, bool>()
        {
            {"Advanced Healer", false},
            {"Blunt Weapon Mastery", false},
            {"Brewmaster", false},
            {"Kindness", false},
            {"Perseverance", false},
            {"Protection from Evil", false},
            {"Requiem", false},
            {"Undead Slaying", false},
            {"Holy Aura", false}
        };
        public override Dictionary<string, bool> Perks { get { return _perks; } }

        public Cleric()
        {
            Strength = 13;
            Agility = 11;
            Will = 30;
            Knowledge = 12;

            IsMagicUser = true;
        }

        internal override double GetSkillMultiplier()
        {
            throw new NotImplementedException();
        }
    }
}
