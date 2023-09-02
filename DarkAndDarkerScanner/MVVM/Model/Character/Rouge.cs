using System;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Rogue : BaseCharacter
    {
        private Dictionary<string, bool> _skills = new Dictionary<string, bool>()
        {
            {"Crossbow Mastery", false},
            {"Enhanced Hearing", false},
            {"Ambush", false},
            {"Back Attack", false},
            {"Creep", false},
            {"Dagger Expert", false},
            {"Hidden Pockets", false},
            {"Lockpick Expert", false},
            {"Pickpocket", false},
            {"Poisoned Weapon", false},
            {"Stealth", false},
            {"Trap Detection", false},
            {"Double Jump", false},
            {"Jokester", false},
            {"Shadow Runner", false},
            {"Thrust", false},
            {"Hand Crossbow Mastery", false}
        };
        public override Dictionary<string, bool> Skills { get { return _skills; } }

        private Dictionary<string, bool> _perks = new Dictionary<string, bool>()
        {
            {"Field Ration", false},
            {"Multishot", false},
            {"Quick Fire", false},
            {"Quickshot	", false},
            {"True Shot", false},
            {"Forceful Shot", false},
            {"Penetrating Shot", false}
        };
        public override Dictionary<string, bool> Perks { get { return _perks; } }

        public Rogue()
        {
            Strength = 8;
            Agility = 35;
            Will = 5;
            Knowledge = 12;
        }

        internal override double GetSkillMultiplier()
        {
            throw new NotImplementedException();
        }
    }
}
