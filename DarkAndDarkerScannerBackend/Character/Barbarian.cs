namespace DarkerScanner.Character
{
    public class Barbarian : Character
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
