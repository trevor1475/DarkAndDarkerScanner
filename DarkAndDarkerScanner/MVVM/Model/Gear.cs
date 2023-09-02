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
        public double HealthBonus = 0;
        public int BaseArmorRating = 0;
        public int ArmorRating = 0;
        public double PhysicalReduction = 0.0;
        public int BaseMagicResist = 0;
        public int MagicResist = 0;
        public double MagicReduction = 0.0;
        public int BaseMoveSpeed = 0;
        public int MoveSpeed = 0;
        public double MoveSpeedBonus = 0.0;

        public int BaseDamage = 0;
        public int WeaponDamage = 0;
        public int PhysicalDamage = 0;
        public int TruePhysicalDamage = 0;
        public int PhysicalPower = 0;
        public double PhysicalPowerBonus = 0.0;
        public double ArmorPenetration = 0.0;
        public double ActionSpeed = 0.0;

        public int BaseMagicDamage = 0;
        public int MagicDamage = 0;
        public int TrueMagicDamage = 0;
        public int MagicPower = 0;
        public double MagicPowerBonus = 0.0;
        public double MagicPenetration = 0.0;
        public double CastSpeed = 0.0;

        public int Resourcefulness = 0;
        public double InteractionSpeed = 0.0;
        public double MagicalInteractionSpeed = 0.0;
        public double ItemEquipSpeed = 0.0;
        public double BuffDuration = 0.0;
        public double DebuffDuration = 0.0;
        public int MagicalHealing = 0;
        public int PhysicalHealing = 0;

        public double HeadshotReduction = 0.0;
        public double ProjectileReduction = 0.0;

        public Gear()
        {

        }

        public Slot GetSlot(string gearName)
        {
            return GearType.StaticData[gearName].GearSlot;
        }
    }
}
