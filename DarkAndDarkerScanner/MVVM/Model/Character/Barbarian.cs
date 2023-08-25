using System;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public class Barbarian : BaseCharacter
    {
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
