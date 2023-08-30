using static DarkAndDarkerScanner.MVVM.Model.GearType;

namespace DarkAndDarkerScanner.MVVM.Model
{
    public class Gear
    {
        public Slot GearSlot;

        public int AllStat = 0;
        public int Strength = 0;
        public int Agility = 0;
        public int Will = 0;
        public int Knowledge = 0;

        public int Health = 0;
        public int Armor = 0;
        public double PhysicalReduction = 0.0;
        public int ResistRating = 0;
        public double MagicResist = 0.0;
        public double MoveSpeed = 0.0;

        public int PhysicalDamage = 0;
        public int TruePhysicalDamage = 0;
        public int PhysicalPower = 0;
        public double PhysicalPowerBonus = 0.0;
        public double ArmorPenetration = 0.0;
        public double ActionSpeed = 0.0;

        public int MagicDamage = 0;
        public int TrueMagicDamage = 0;
        public int MagicPower = 0;
        public double MagicPowerBonus = 0.0;
        public double MagicPenetration = 0.0;
        public double CastSpeed = 0.0;

        public Gear()
        {

        }

        public Slot GetSlot(string gearName)
        {
            return GearType.StaticData[gearName].GearSlot;
        }
    }
}
