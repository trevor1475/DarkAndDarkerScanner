namespace DarkerScanner.Character
{
    internal class Ranger : Character
    {
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
