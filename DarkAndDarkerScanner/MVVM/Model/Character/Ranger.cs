using System;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Ranger : BaseCharacter
    {
        private Dictionary<string, bool> _skills = new Dictionary<string, bool>()
        {
            {"Crossbow Mastery", false},
            {"Enhanced Hearing", false},
            {"Kinesthesia", false},
            {"Nimble Hands", false},
            {"Ranged Weapons Mastery", false},
            {"Spear Proficiency", false},
            {"Chase", false},
            {"Trap Mastery", false},
            {"Crippling Shot", false},
            {"Quick Reload", false}
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

        public Ranger()
        {
            Strength = 10;
            Agility = 20;
            Will = 10;
            Knowledge = 10;
        }

        internal override double GetSkillMultiplier()
        {
            throw new NotImplementedException();
        }
    }
}
