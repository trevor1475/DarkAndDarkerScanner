using System;

namespace DarkAndDarkerScanner.Character
{
    public class Rogue : BaseCharacter
    {
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
