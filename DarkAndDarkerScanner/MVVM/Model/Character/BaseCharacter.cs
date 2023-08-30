using System;

namespace DarkAndDarkerScanner.MVVM.Model.Character
{
    public abstract class BaseCharacter
    {
        private const int PUNCH_DAMAGE = 15;

        // TODO: variable adjust
        double HeadshotAccuracy = 0.8;

        public bool IsMagicUser = false;

        // Base
        private int baseHealth = 60;
        private double basePhyscialReduction = -0.1;
        private double baseMagicResist = -0.24;
        private int baseResistRating = -20;

        private double basePhysicalPowerBonus = -0.41;
        private double baseMagicalPowerBonus = -0.75;
        private double baseActionSpeed = -0.45;
        private double baseCastingSpeed = -1;
        private int baseMovementSpeedRating = 300;

        // Total
        public int Strength = 0;
        public int Agility = 0;
        public int Will = 0;
        public int Knowledge = 0;

        public int Health = 0;
        public int Armor = 0;
        public double PhysicalReduction = 0.0;
        public int ResistRating = 0;
        public double MagicResist = 0.0;
        public double MovementSpeed = 0.0;

        public int PhysicalDamage = 0;
        public int TruePhysicalDamage = 0;
        public int PhysicalPower = 0;
        public double PhysicalPowerBonus = 0.0;
        public double ArmorPenetration = 0.0;
        public double ActionSpeed = 0.0;

        public int MagicalDamage = 0;
        public int TrueMagicalDamage = 0;
        public int MagicalPower = 0;
        public double MagicalPowerBonus = 0.0;
        public double MagicPenetration = 0.0;
        public double CastingSpeed = 0.0;

        public Gear Weapon = new Gear();
        public Gear Offhand = new Gear();
        public Gear Helmet = new Gear();
        public Gear Chest = new Gear();
        public Gear Legs = new Gear();
        public Gear Gloves = new Gear();
        public Gear Boots = new Gear();
        public Gear Necklace = new Gear();
        public Gear Ring1 = new Gear();
        public Gear Ring2 = new Gear();

        public BaseCharacter()
        {
            
        }

        public int GetHealth()
        {
            return baseHealth + Health
                + Math.Min(10, Strength) * 3
                + Math.Min(1, Math.Max(Strength - 10, 0)) * 2
                + Math.Min(4, Math.Max(Strength - 11, 0)) * 2
                + Math.Max(Strength - 15, 0) * 2;
        }

        public double GetPhysicalReduction()
        {
            return basePhyscialReduction + PhysicalReduction
                + Math.Min(10, Armor) * 0.01
                + Math.Min(9, Math.Max(Armor - 10, 0)) * 0.005
                + Math.Min(10, Math.Max(Armor - 20, 0)) * 0.04
                + Math.Min(10, Math.Max(Armor - 30, 0)) * 0.03
                + Math.Min(10, Math.Max(Armor - 40, 0)) * 0.02
                + Math.Min(50, Math.Max(Armor - 50, 0)) * 0.01
                + Math.Min(50, Math.Max(Armor - 100, 0)) * 0.02
                + Math.Max(Armor - 150, 0) * 0.03;
        }

        public double GetMagicalReduction()
        {
            int resistRating = baseResistRating + ResistRating
                + Math.Min(6, Will) * 4
                + Math.Max(Will - 6, 0) * 3;

            return baseMagicResist + MagicResist
                + Math.Min(10, resistRating) * 0.01
                + Math.Min(9, Math.Max(resistRating - 8, 0)) * 0.005
                + Math.Min(2, Math.Max(resistRating - 9, 0)) * 0.004
                + Math.Min(4, Math.Max(resistRating - 11, 0)) * 0.003
                + Math.Min(3, Math.Max(resistRating - 12, 0)) * 0.004
                + Math.Min(2, Math.Max(resistRating - 15, 0)) * 0.006
                + Math.Min(10, Math.Max(resistRating - 15, 0)) * 0.003
                + Math.Min(10, Math.Max(resistRating - 15, 0)) * 0.002
                + Math.Min(50, Math.Max(resistRating - 15, 0)) * 0.001
                + Math.Min(50, Math.Max(resistRating - 15, 0)) * 0.002
                + Math.Max(resistRating - 15, 0) * 0.003;
        }

        public double GetPhysicalPowerBonus()
        {
            var totalPower = PhysicalPower + Strength;
            return basePhysicalPowerBonus + PhysicalPowerBonus
                + Math.Min(10, totalPower) * 0.03
                + Math.Min(1, Math.Max(totalPower - 10, 0)) * 0.03
                + Math.Min(4, Math.Max(totalPower - 11, 0)) * 0.02
                + Math.Max(totalPower - 15, 0) * 0.01;
        }

        public double GetMagicalPowerBonus()
        {
            var totalPower = MagicalPower + Will;
            return baseMagicalPowerBonus + MagicalPowerBonus
                + Math.Min(15, totalPower) * 0.05
                + Math.Min(10, Math.Max(totalPower - 15, 0)) * 0.03
                + Math.Min(15, Math.Max(totalPower - 25, 0)) * 0.02
                + Math.Max(totalPower - 40, 0) * 0.01;
        }

        public double GetActionSpeed()
        {
            return baseActionSpeed + ActionSpeed
                + Math.Min(15, Agility) * 0.03
                + Math.Min(10, Math.Max(Agility - 15, 0)) * 0.01
                + Math.Min(15, Math.Max(Agility - 25, 0)) * 0.02
                + Math.Min(10, Math.Max(Agility - 40, 0)) * 0.01
                + Math.Max(Agility - 50, 0) * 0.005;
        }

        public double GetCastingSpeed()
        {
            return baseCastingSpeed + CastingSpeed
                + Knowledge * 0.05;
        }

        public double GetMovementSpeed()
        {
            return (baseMovementSpeedRating + Agility) / 3 + MovementSpeed;
        }

        public bool CanEquip(string gearName)
        {
            if (GearType.StaticData.ContainsKey(gearName))
            {
                return GearType.StaticData[gearName].EquippableBy.Contains(this.GetType());
            }

            // TODO: log error
            return false;
        }

        // TODO: Better equip --- 2h issue
        public Gear Equip(Gear newGear, int replacementSlot = 1)
        {
            Gear? oldGear = null;

            switch (newGear.GearSlot)
            {
                case GearType.Slot.OneHandWeapon:
                    oldGear = Weapon;
                    Weapon = newGear;
                    break;
                case GearType.Slot.OffhandWeapon:
                    //TODO
                    //if (Weapon.IsTwoHanded)
                    //{
                        //RemoveStats(Weapon);
                    //}
                    oldGear = Offhand;
                    Weapon = newGear;
                    break;
                case GearType.Slot.TwoHandWeapon:
                    oldGear = Weapon;
                    RemoveStats(Offhand);
                    Weapon = newGear;
                    break;
                case GearType.Slot.Helmet:
                    oldGear = Helmet;
                    Helmet = newGear;
                    break;
                case GearType.Slot.Chest:
                    oldGear = Chest;
                    Chest = newGear;
                    break;
                case GearType.Slot.Legs:
                    oldGear = Legs;
                    Legs = newGear;
                    break;
                case GearType.Slot.Gloves:
                    oldGear = Gloves;
                    Gloves = newGear;
                    break;
                case GearType.Slot.Boots:
                    oldGear = Boots;
                    Boots = newGear;
                    break;
                case GearType.Slot.Necklace:
                    oldGear = Necklace;
                    Necklace = newGear;
                    break;
                case GearType.Slot.Ring:
                    if (replacementSlot == 1)
                    {
                        oldGear = Ring1;
                        Ring1 = newGear;
                    }
                    else if (replacementSlot == 2)
                    {
                        oldGear = Ring2;
                        Ring2 = newGear;
                    }
                    else
                    {
                        // TODO: error log
                        return null;
                    }

                    break;

                default:
                    break;
            }

            if (oldGear != null)
                RemoveStats(oldGear);

            if (newGear != null)
                AddStats(newGear);

            return oldGear;
        }

        public double CalculateDamage()
        {
            return Math.Max(IsMagicUser ? MagicalDamage : PhysicalDamage, PUNCH_DAMAGE)
                * (1 + (IsMagicUser ? MagicalPowerBonus : PhysicalPowerBonus))
                * GetSkillMultiplier()
                * GetHeadshotMultiplier()
                * (1 - (IsMagicUser ? MagicResist : PhysicalReduction) + (IsMagicUser ? MagicPenetration : ArmorPenetration))
                + (IsMagicUser ? TrueMagicalDamage : TruePhysicalDamage);
        }

        private double GetHeadshotMultiplier()
        {
            return 1 + .5 * HeadshotAccuracy;
        }

        internal abstract double GetSkillMultiplier();

        public double CalculateDps()
        {
            return CalculateDamage() * Math.Max(GetActionSpeed(), GetCastingSpeed());
        }

        private void AddStats(Gear gear)
        {
            Strength += (gear.Strength + gear.AllStat);
            Agility += (gear.Agility + gear.AllStat);
            Will += (gear.Will + gear.AllStat);
            Knowledge += (gear.Knowledge + gear.AllStat);

            Health += gear.Health;
            Armor += gear.Armor;
            PhysicalReduction += gear.PhysicalReduction;
            ResistRating += gear.ResistRating;
            MagicResist += gear.MagicResist;
            MovementSpeed += gear.MoveSpeed;
            
            PhysicalDamage += gear.PhysicalDamage;
            TruePhysicalDamage += gear.TruePhysicalDamage;
            PhysicalPower += gear.PhysicalPower;
            PhysicalPowerBonus += gear.PhysicalPowerBonus;
            ArmorPenetration += gear.ArmorPenetration;
            ActionSpeed += gear.ActionSpeed;
            
            MagicalDamage += gear.MagicDamage;
            TrueMagicalDamage += gear.TrueMagicDamage;
            MagicalPower += gear.MagicPower;
            MagicalPowerBonus += gear.MagicPowerBonus;
            MagicPenetration += gear.MagicPenetration;
            CastingSpeed += gear.CastSpeed;
        }

        private void RemoveStats(Gear gear)
        {
            Strength -= (gear.Strength + gear.AllStat);
            Agility -= (gear.Agility + gear.AllStat);
            Will -= (gear.Will + gear.AllStat);
            Knowledge -= (gear.Knowledge + gear.AllStat);

            Health -= gear.Health;
            Armor -= gear.Armor;
            PhysicalReduction -= gear.PhysicalReduction;
            ResistRating -= gear.ResistRating;
            MagicResist -= gear.MagicResist;
            MovementSpeed -= gear.MoveSpeed;

            PhysicalDamage -= gear.PhysicalDamage;
            TruePhysicalDamage -= gear.TruePhysicalDamage;
            PhysicalPower -= gear.PhysicalPower;
            PhysicalPowerBonus -= gear.PhysicalPowerBonus;
            ArmorPenetration -= gear.ArmorPenetration;
            ActionSpeed -= gear.ActionSpeed;

            MagicalDamage -= gear.MagicDamage;
            TrueMagicalDamage -= gear.TrueMagicDamage;
            MagicalPower -= gear.MagicPower;
            MagicalPowerBonus -= gear.MagicPowerBonus;
            MagicPenetration -= gear.MagicPenetration;
            CastingSpeed -= gear.CastSpeed;
        }
    }
}
