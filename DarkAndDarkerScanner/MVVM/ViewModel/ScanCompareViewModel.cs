using DarkAndDarkerScanner.MVVM.Model.Character;
using DarkAndDarkerScanner.MVVM.Stores;
using DarkAndDarkerScanner.Core;
using System;
using System.ComponentModel;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class ScanCompareViewModel : ObservableObject
    {
        private CharacterStore _characterStore;
        private BaseCharacter _character => _characterStore.Character;

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

        public RelayCommand EquipGearCommand { get; }

        public GearViewModel GearVm { get; set; }

        public ScanCompareViewModel(CharacterStore characterStore)
        {
            _characterStore = characterStore;
            GearVm = new GearViewModel();

            EquipGearCommand = new RelayCommand(() => { _character.Equip(GearVm.CreateGear()); });

            GearVm.PropertyChanged += new PropertyChangedEventHandler(OnGearVmPropertyChange);
        }

        ~ScanCompareViewModel()
        {
            GearVm.PropertyChanged -= new PropertyChangedEventHandler(OnGearVmPropertyChange);
        }

        private void OnGearVmPropertyChange(object? sender, PropertyChangedEventArgs e)
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
            var oldGear = _character.Equip(GearVm.CreateGear());
            var newMetric = metric();
            _character.Equip(oldGear);
            var calc = newMetric / oldMetric;
            return !Double.IsNaN(calc) && !Double.IsInfinity(calc) ? calc : 0.0;
        }
    }
}
