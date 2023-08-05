using System;

namespace DarkAndDarkerScanner.Character
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
            throw new NotImplementedException();
        }
    }
}
