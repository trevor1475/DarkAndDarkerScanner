namespace DarkerScanner.Character
{
    internal class Fighter : Character
    {
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
