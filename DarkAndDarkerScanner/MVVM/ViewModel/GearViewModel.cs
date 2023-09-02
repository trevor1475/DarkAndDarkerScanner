using DarkAndDarkerScanner.MVVM.Model;
using DarkAndDarkerScanner.Core;
using static DarkAndDarkerScanner.MVVM.Model.GearType;
using System.ComponentModel;
using System;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class GearViewModel : ObservableObject, INotifyPropertyChanging
    {
        //scan stat section w/ manual entry
        //manual scan button
        //equip comparison
        //equip button
        //ehp

        public event PropertyChangingEventHandler? PropertyChanging;

        private Slot _gearSlot;
        public Slot GearSlot
        {
            get
            {
                return _gearSlot;
            }
            set
            {
                PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(GearSlot)));
                _gearSlot = value;
                OnPropertyChanged(nameof(GearSlot));
            }
        }

        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
            }
        }

        private double _healthBonus;
        public double HealthBonus
        {
            get
            {
                return _healthBonus;
            }
            set
            {
                _healthBonus = value;
                OnPropertyChanged(nameof(HealthBonus));
            }
        }

        private int _allStat;
        public int AllStat
        {
            get
            {
                return _allStat;
            }
            set
            {
                _allStat = value;
                OnPropertyChanged(nameof(AllStat));
            }
        }

        private int _strength;
        public int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }

        private int _agility;
        public int Agility
        {
            get
            {
                return _agility;
            }
            set
            {
                _agility = value;
                OnPropertyChanged(nameof(Agility));
            }
        }

        private int _knowledge;
        public int Knowledge
        {
            get
            {
                return _knowledge;
            }
            set
            {
                _knowledge = value;
                OnPropertyChanged(nameof(Knowledge));
            }
        }

        private int _will;
        public int Will
        {
            get
            {
                return _will;
            }
            set
            {
                _will = value;
                OnPropertyChanged(nameof(Will));
            }
        }

        private int _baseMoveSpeed;
        public int BaseMoveSpeed
        {
            get
            {
                return _baseMoveSpeed;
            }
            set
            {
                _baseMoveSpeed = value;
                OnPropertyChanged(nameof(BaseMoveSpeed));
            }
        }

        private int _moveSpeed;
        public int MoveSpeed
        {
            get
            {
                return _moveSpeed;
            }
            set
            {
                _moveSpeed = value;
                OnPropertyChanged(nameof(MoveSpeed));
            }
        }

        private double _moveSpeedBonus;
        public double MoveSpeedBonus
        {
            get
            {
                return _moveSpeedBonus;
            }
            set
            {
                _moveSpeedBonus = value;
                OnPropertyChanged(nameof(MoveSpeedBonus));
            }
        }

        private int _baseArmorRating;
        public int BaseArmorRating
        {
            get
            {
                return _baseArmorRating;
            }
            set
            {
                _baseArmorRating = value;
                OnPropertyChanged(nameof(BaseArmorRating));
            }
        }

        private int _armorRating;
        public int ArmorRating
        {
            get
            {
                return _armorRating;
            }
            set
            {
                _armorRating = value;
                OnPropertyChanged(nameof(ArmorRating));
            }
        }

        private double _physicalReduction;
        public double PhysicalReduction
        {
            get
            {
                return _physicalReduction;
            }
            set
            {
                _physicalReduction = value;
                OnPropertyChanged(nameof(PhysicalReduction));
            }
        }

        private int _baseDamage;
        public int BaseDamage
        {
            get
            {
                return _baseDamage;
            }
            set
            {
                _baseDamage = value;
                //RecalculateDps();
                OnPropertyChanged(nameof(BaseDamage));
            }
        }

        private int _weaponDamage;
        public int WeaponDamage
        {
            get
            {
                return _weaponDamage;
            }
            set
            {
                _weaponDamage = value;
                OnPropertyChanged(nameof(WeaponDamage));
            }
        }

        private int _physicalDamage;
        public int PhysicalDamage
        {
            get
            {
                return _physicalDamage;
            }
            set
            {
                _physicalDamage = value;
                OnPropertyChanged(nameof(PhysicalDamage));
            }
        }

        private int _truePhysicalDamage;
        public int TruePhysicalDamage
        {
            get
            {
                return _truePhysicalDamage;
            }
            set
            {
                _truePhysicalDamage = value;
                OnPropertyChanged(nameof(TruePhysicalDamage));
            }
        }

        private int _phyiscalPower;
        public int PhysicalPower
        {
            get
            {
                return _phyiscalPower;
            }
            set
            {
                _phyiscalPower = value;
                OnPropertyChanged(nameof(PhysicalPower));
            }
        }

        private double _physicalPowerBonus;
        public double PhysicalPowerBonus
        {
            get
            {
                return _physicalPowerBonus;
            }
            set
            {
                _physicalPowerBonus = value;
                OnPropertyChanged(nameof(PhysicalPowerBonus));
            }
        }

        private double _armorPenetration;
        public double ArmorPenetration
        {
            get
            {
                return _armorPenetration;
            }
            set
            {
                _armorPenetration = value;
                OnPropertyChanged(nameof(ArmorPenetration));
            }
        }

        private double _actionSpeed;
        public double ActionSpeed
        {
            get
            {
                return _actionSpeed;
            }
            set
            {
                _actionSpeed = value;
                OnPropertyChanged(nameof(ActionSpeed));
            }
        }

        private int _baseMagicResist;
        public int BaseMagicResist
        {
            get
            {
                return _baseMagicResist;
            }
            set
            {
                _baseMagicResist = value;
                OnPropertyChanged(nameof(BaseMagicResist));
            }
        }

        private int _magicRating;
        public int MagicResist
        {
            get
            {
                return _magicRating;
            }
            set
            {
                _magicRating = value;
                OnPropertyChanged(nameof(MagicResist));
            }
        }

        private double _magicReduction;
        public double MagicReduction
        {
            get
            {
                return _magicReduction;
            }
            set
            {
                _magicReduction = value;
                OnPropertyChanged(nameof(MagicReduction));
            }
        }

        private int _baseMagicDamage;
        public int BaseMagicDamage
        {
            get
            {
                return _baseMagicDamage;
            }
            set
            {
                _baseMagicDamage = value;
                OnPropertyChanged(nameof(BaseMagicDamage));
            }
        }

        private int _magicDamage;
        public int MagicDamage
        {
            get
            {
                return _magicDamage;
            }
            set
            {
                _magicDamage = value;
                OnPropertyChanged(nameof(MagicDamage));
            }
        }

        private int _trueMagicDamage;
        public int TrueMagicDamage
        {
            get
            {
                return _trueMagicDamage;
            }
            set
            {
                _trueMagicDamage = value;
                OnPropertyChanged(nameof(TrueMagicDamage));
            }
        }

        private int _magicPower;
        public int MagicPower
        {
            get
            {
                return _magicPower;
            }
            set
            {
                _magicPower = value;
                OnPropertyChanged(nameof(MagicPower));
            }
        }

        private double _magicPowerBonus;
        public double MagicPowerBonus
        {
            get
            {
                return _magicPowerBonus;
            }
            set
            {
                _magicPowerBonus = value;
                OnPropertyChanged(nameof(MagicPowerBonus));
            }
        }

        private double _magicPenetration;
        public double MagicPenetration
        {
            get
            {
                return _magicPenetration;
            }
            set
            {
                _magicPenetration = value;
                OnPropertyChanged(nameof(MagicPenetration));
            }
        }

        private double _castSpeed;
        public double CastSpeed
        {
            get
            {
                return _castSpeed;
            }
            set
            {
                _castSpeed = value;
                OnPropertyChanged(nameof(CastSpeed));
            }
        }

        private int _resourcefulness;
        public int Resourcefulness
        {
            get
            {
                return _resourcefulness;
            }
            set
            {
                _resourcefulness = value;
                OnPropertyChanged(nameof(Resourcefulness));
            }
        }

        private double _interactionSpeed;
        public double InteractionSpeed
        {
            get
            {
                return _interactionSpeed;
            }
            set
            {
                _interactionSpeed = value;
                OnPropertyChanged(nameof(InteractionSpeed));
            }
        }

        private double _ItemEquipSpeed;
        public double ItemEquipSpeed
        {
            get
            {
                return _ItemEquipSpeed;
            }
            set
            {
                _ItemEquipSpeed = value;
                OnPropertyChanged(nameof(ItemEquipSpeed));
            }
        }

        private double _magicalInteractionSpeed;
        public double MagicalInteractionSpeed
        {
            get
            {
                return _magicalInteractionSpeed;
            }
            set
            {
                _magicalInteractionSpeed = value;
                OnPropertyChanged(nameof(MagicalInteractionSpeed));
            }
        }

        private double _buffDuration;
        public double BuffDuration
        {
            get
            {
                return _buffDuration;
            }
            set
            {
                _buffDuration = value;
                OnPropertyChanged(nameof(BuffDuration));
            }
        }

        private double _debuffDuration;
        public double DebuffDuration
        {
            get
            {
                return _debuffDuration;
            }
            set
            {
                _debuffDuration = value;
                OnPropertyChanged(nameof(DebuffDuration));
            }
        }

        private int _magicalHealing;
        public int MagicalHealing
        {
            get
            {
                return _magicalHealing;
            }
            set
            {
                _magicalHealing = value;
                OnPropertyChanged(nameof(MagicalHealing));
            }
        }

        private int _physicalHealing;
        public int PhysicalHealing
        {
            get
            {
                return _physicalHealing;
            }
            set
            {
                _physicalHealing = value;
                OnPropertyChanged(nameof(PhysicalHealing));
            }
        }

        private double _headshotReduction;
        public double HeadshotReduction
        {
            get
            {
                return _headshotReduction;
            }
            set
            {
                _headshotReduction = value;
                OnPropertyChanged(nameof(HeadshotReduction));
            }
        }

        private double _projectileReduction;
        public double ProjectileReduction
        {
            get
            {
                return _projectileReduction;
            }
            set
            {
                _projectileReduction = value;
                OnPropertyChanged(nameof(ProjectileReduction));
            }
        }

        public GearViewModel()
        {

        }

        public Gear CreateGear()
        {
            return new Gear()
            {
                GearSlot = GearSlot,

                AllStat = AllStat,
                Strength = Strength,
                Agility = Agility,
                Will = Will,
                Knowledge = Knowledge,

                Health = Health,
                ArmorRating = ArmorRating,
                PhysicalReduction = PhysicalReduction,
                MagicResist = MagicResist,
                MagicReduction = MagicReduction,
                BaseMoveSpeed = BaseMoveSpeed,
                MoveSpeed = MoveSpeed,
                MoveSpeedBonus = MoveSpeedBonus,

                BaseDamage = BaseDamage,
                PhysicalDamage = PhysicalDamage,
                TruePhysicalDamage = TruePhysicalDamage,
                PhysicalPower = PhysicalPower,
                PhysicalPowerBonus = PhysicalPowerBonus,
                ArmorPenetration = ArmorPenetration,
                ActionSpeed = ActionSpeed,

                BaseMagicDamage = BaseMagicDamage,
                MagicDamage = MagicDamage,
                TrueMagicDamage = TrueMagicDamage,
                MagicPower = MagicPower,
                MagicPowerBonus = MagicPowerBonus,
                MagicPenetration = MagicPenetration,
                CastSpeed = CastSpeed,

                Resourcefulness = Resourcefulness,
                InteractionSpeed = InteractionSpeed,
                MagicalInteractionSpeed = MagicalInteractionSpeed,
                ItemEquipSpeed = ItemEquipSpeed,
                BuffDuration = BuffDuration,
                DebuffDuration = DebuffDuration,
                MagicalHealing = MagicalHealing,
                PhysicalHealing = PhysicalHealing,
                HeadshotReduction = HeadshotReduction,
                ProjectileReduction = ProjectileReduction
            };
        }

        public void LoadStats(Gear? gear)
        {
            if (gear != null)
            {
                AllStat = gear.AllStat;
                Strength = gear.Strength;
                Agility = gear.Agility;
                Will = gear.Will;
                Knowledge = gear.Knowledge;

                Health = gear.Health;
                ArmorRating = gear.ArmorRating;
                PhysicalReduction = gear.PhysicalReduction;
                MagicResist = gear.MagicResist;
                MagicReduction = gear.MagicReduction;
                BaseMoveSpeed = gear.BaseMoveSpeed;
                MoveSpeed = gear.MoveSpeed;
                MoveSpeedBonus = gear.MoveSpeedBonus;

                BaseDamage = gear.BaseDamage;
                PhysicalDamage = gear.PhysicalDamage;
                TruePhysicalDamage = gear.TruePhysicalDamage;
                PhysicalPower = gear.PhysicalPower;
                PhysicalPowerBonus = gear.PhysicalPowerBonus;
                ArmorPenetration = gear.ArmorPenetration;
                ActionSpeed = gear.ActionSpeed;

                BaseMagicDamage = gear.BaseMagicDamage;
                MagicDamage = gear.MagicDamage;
                TrueMagicDamage = gear.TrueMagicDamage;
                MagicPower = gear.MagicPower;
                MagicPowerBonus = gear.MagicPowerBonus;
                MagicPenetration = gear.MagicPenetration;
                CastSpeed = gear.CastSpeed;

                Resourcefulness = gear.Resourcefulness;
                InteractionSpeed = gear.InteractionSpeed;
                MagicalInteractionSpeed = gear.MagicalInteractionSpeed;
                ItemEquipSpeed = gear.ItemEquipSpeed;
                BuffDuration = gear.BuffDuration;
                DebuffDuration = gear.DebuffDuration;
                MagicalHealing = gear.MagicalHealing;
                PhysicalHealing = gear.PhysicalHealing;
                HeadshotReduction = gear.HeadshotReduction;
                ProjectileReduction = gear.ProjectileReduction;
            }
        }

        public void ClearStats()
        {
            AllStat = 0;
            Strength = 0;
            Agility = 0;
            Will = 0;
            Knowledge = 0;

            Health = 0;
            HealthBonus = 0.0;
            BaseArmorRating = 0;
            ArmorRating = 0;
            PhysicalReduction = 0.0;
            BaseMagicResist = 0;
            MagicResist = 0;
            MagicReduction = 0.0;
            BaseMoveSpeed = 0;
            MoveSpeed = 0;
            MoveSpeedBonus = 0.0;

            BaseDamage = 0;
            WeaponDamage = 0;
            PhysicalDamage = 0;
            TruePhysicalDamage = 0;
            PhysicalPower = 0;
            PhysicalPowerBonus = 0.0;
            ArmorPenetration = 0.0;
            ActionSpeed = 0.0;

            BaseMagicDamage = 0;
            MagicDamage = 0;
            TrueMagicDamage = 0;
            MagicPower = 0;
            MagicPowerBonus = 0.0;
            MagicPenetration = 0.0;
            CastSpeed = 0.0;

            Resourcefulness = 0;
            InteractionSpeed = 0.0;
            MagicalInteractionSpeed = 0.0;
            ItemEquipSpeed = 0.0;
            BuffDuration = 0.0;
            DebuffDuration = 0.0;
            MagicalHealing = 0;
            PhysicalHealing = 0;

            HeadshotReduction = 0.0;
            ProjectileReduction = 0.0;
    }
    }
}
