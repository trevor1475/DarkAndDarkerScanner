using System;

namespace DarkAndDarkerScanner.Character
{
    public class Cleric : BaseCharacter
    {
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
