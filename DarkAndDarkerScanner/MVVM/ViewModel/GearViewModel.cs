using DarkAndDarkerScanner.MVVM.Model;
using DarkAndDarkerScanner.Core;
using static DarkAndDarkerScanner.MVVM.Model.GearType;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class GearViewModel : ObservableObject
    {
        //scan stat section w/ manual entry
        //manual scan button
        //equip comparison
        //equip button
        //ehp

        private Slot _gearSlot;
        public Slot GearSlot
        {
            get
            {
                return _gearSlot;
            }
            set
            {
                _gearSlot = value;
                //RecalculateAll();
                OnPropertyChanged(nameof(GearSlot));
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

        private float _moveSpeed;
        public float MoveSpeed
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

        private int _armor;
        public int Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                _armor = value;
                OnPropertyChanged(nameof(Armor));
            }
        }

        private float _physicalReduction;
        public float PhysicalReduction
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

        private float _physicalPowerBonus;
        public float PhysicalPowerBonus
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

        private float _armorPenetration;
        public float ArmorPenetration
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

        private float _actionSpeed;
        public float ActionSpeed
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

        private int _resistRating;
        public int ResistRating
        {
            get
            {
                return _resistRating;
            }
            set
            {
                _resistRating = value;
                OnPropertyChanged(nameof(ResistRating));
            }
        }

        private float _magicReduction;
        public float MagicReduction
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

        private float _magicPowerBonus;
        public float MagicPowerBonus
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

        private float _magicPenetration;
        public float MagicPenetration
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

        private float _castSpeed;
        public float CastSpeed
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

        public GearViewModel()
        {

        }

        public Gear CreateGear()
        {
            return new Gear()
            {
                GearSlot = GearSlot,

                //TODO
                AllStat = 0,
                Strength = Strength,
                Agility = Agility,
                Will = Will,
                Knowledge = Knowledge,

                Health = Health,
                Armor = Armor,
                PhysicalReduction = PhysicalReduction,
                ResistRating = ResistRating,
                //TODO
                MagicResist = 0,
                MoveSpeed = MoveSpeed,

                PhysicalDamage = BaseDamage + PhysicalDamage,
                TruePhysicalDamage = TruePhysicalDamage,
                PhysicalPower = PhysicalPower,
                PhysicalPowerBonus = PhysicalPowerBonus,
                ArmorPenetration = ArmorPenetration,
                ActionSpeed = ActionSpeed,

                MagicDamage = MagicDamage,
                TrueMagicDamage = TrueMagicDamage,
                MagicPower = MagicPower,
                MagicPowerBonus = MagicPowerBonus,
                MagicPenetration = MagicPenetration,
                CastSpeed = CastSpeed
            };
        }

        public void ClearStats()
        {
            Strength = 0;
            Agility = 0;
            Will = 0;
            Knowledge = 0;

            Health = 0;
            Armor = 0;
            PhysicalReduction = 0.0f;
            ResistRating = 0;
            //todo MagicResist = 0.0f;
            MoveSpeed = 0.0f;

            PhysicalDamage = 0;
            TruePhysicalDamage = 0;
            PhysicalPower = 0;
            PhysicalPowerBonus = 0.0f;
            ArmorPenetration = 0.0f;
            ActionSpeed = 0.0f;

            MagicDamage = 0;
            TrueMagicDamage = 0;
            MagicPower = 0;
            MagicPowerBonus = 0.0f;
            MagicPenetration = 0.0f;
            CastSpeed = 0.0f;
        }
    }
}
