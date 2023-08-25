using DarkAndDarkerScanner.MVVM.Model;
using DarkAndDarkerScanner.MVVM.Model.Character;
using DarkAndDarkerScanner.MVVM.Stores;
using DarkAndDarkerScannerBackend.Core;
using System;
using static DarkAndDarkerScanner.MVVM.Model.GearType;

namespace DarkAndDarkerScannerBackend.MVVM.ViewModel
{
    public class ScanCompareViewModel : ObservableObject
    {
        //scan stat section w/ manual entry
        //manual scan button
        //equip comparison
        //equip button
        //ehp

        private CharacterStore _characterStore;
        private BaseCharacter _character => _characterStore.Character;

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
                RecalculateAll();
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
                RecalculateDps();
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

        private int _physicalPowerBonus;
        public int PhysicalPowerBonus
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

        private int _armorPenetration;
        public int ArmorPenetration
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

        private int _actionSpeed;
        public int ActionSpeed
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

        private int _magicPowerBonus;
        public int MagicPowerBonus
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

        private int _magicPenetration;
        public int MagicPenetration
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

        private int _castSpeed;
        public int CastSpeed
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

        private double _dpsMetric;
        public double DpsMetric
        {
            get
            {
                return _dpsMetric;
            }
            set
            {
                _dpsMetric = value;
                OnPropertyChanged(nameof(DpsMetric));
            }
        }

        private double _damageMetric;
        public double DamageMetric
        {
            get
            {
                return _damageMetric;
            }
            set
            {
                _damageMetric = value;
                OnPropertyChanged(nameof(DamageMetric));
            }
        }

        private double _actionSpeedMetric;
        public double ActionSpeedMetric
        {
            get
            {
                return _actionSpeedMetric;
            }
            set
            {
                _actionSpeedMetric = value;
                OnPropertyChanged(nameof(ActionSpeedMetric));
            }
        }

        private double _castSpeedMetric;
        public double CastSpeedMetric
        {
            get
            {
                return _castSpeedMetric;
            }
            set
            {
                _castSpeedMetric = value;
                OnPropertyChanged(nameof(CastSpeedMetric));
            }
        }

        private double _moveSpeedMetric;
        public double MoveSpeedMetric
        {
            get
            {
                return _moveSpeedMetric;
            }
            set
            {
                _moveSpeedMetric = value;
                OnPropertyChanged(nameof(MoveSpeedMetric));
            }
        }


        public ScanCompareViewModel(CharacterStore characterStore)
        {
            _characterStore = characterStore;
        }

        public void RecalculateAll()
        {
            RecalculateDmg();
            RecalculateActionSpeed();
            RecalculateCastSpeed();
            RecalculateMoveSpeed();
            RecalculateDps();
        }

        public void RecalculateDmg()
        {
            //if (!character.CanEquip(newGear.Name))
            //    return -999; // TODO: popup error


            DamageMetric = RecalculateMetric(_character.CalculateDamage);
        }

        public void RecalculateActionSpeed()
        {
            //if (!character.CanEquip(newGear.Name))
            //    return -999; // TODO: popup error

            ActionSpeedMetric = RecalculateMetric(_character.GetActionSpeed);
        }

        public void RecalculateCastSpeed()
        {
            //if (!character.CanEquip(newGear.Name))
            //    return -999; // TODO: popup error

            CastSpeedMetric = RecalculateMetric(_character.GetCastingSpeed);
        }

        public void RecalculateMoveSpeed()
        {
            //if (!character.CanEquip(newGear.Name))
            //    return -999; // TODO: popup error

            MoveSpeedMetric = RecalculateMetric(_character.GetMovementSpeed);
        }

        public void RecalculateDps()
        {
            //if (!character.CanEquip(newGear.Name))
            //    return -999; // TODO: popup error

            DpsMetric = RecalculateMetric(_character.CalculateDps);
        }

        private double RecalculateMetric(Func<double> metric)
        {
            var oldMetric = metric();
            var oldGear = _character.Equip(CreateGear(), GearSlot);
            var newMetric = metric();
            _character.Equip(oldGear, GearSlot);
            var calc = newMetric / oldMetric;
            return !Double.IsNaN(calc) && !Double.IsInfinity(calc) ? calc : 0.0;
        }

        private Gear CreateGear()
        {
            return new Gear()
            {
                AllStat = 0,
                Strength = Strength,
                Agility = Agility,
                Will = Will,
                Knowledge = Knowledge,

                Health = Health,
                Armor = Armor,
                PhysicalReduction = PhysicalReduction,
                ResistRating = ResistRating,
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
    }
}
