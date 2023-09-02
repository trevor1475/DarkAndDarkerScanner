using DarkAndDarkerScanner.MVVM.Stores;
using DarkAndDarkerScanner.Core;
using static DarkAndDarkerScanner.MVVM.Model.GearType;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class EquipViewModel : ObservableObject
    {
        public RelayCommand ClearStatsCommand { get; }

        public GearViewModel GearVm { get; }

        private CharacterStore _characterStore;
        private Slot lastGearSlot;

        public EquipViewModel(CharacterStore characterStore)
        {
            _characterStore = characterStore;
            GearVm = new GearViewModel();

            ClearStatsCommand = new RelayCommand(GearVm.ClearStats);

            GearVm.PropertyChanging += GearVm_PropertyChanging;
            GearVm.PropertyChanged += GearVm_PropertyChanged;

            var equippedGear = _characterStore.Character.EquippedGear;
            GearVm.GearSlot = equippedGear.Find(x => x.GearSlot == Slot.OneHandWeapon || x.GearSlot == Slot.TwoHandWeapon)?.GearSlot
                ?? (equippedGear.Count >= 1 ? equippedGear[0].GearSlot : Slot.OneHandWeapon);
        }

        ~EquipViewModel()
        {
            GearVm.PropertyChanging -= GearVm_PropertyChanging;
            GearVm.PropertyChanged -= GearVm_PropertyChanged;
        }

        private void GearVm_PropertyChanging(object? sender, System.ComponentModel.PropertyChangingEventArgs e)
        {
            lastGearSlot = GearVm.GearSlot;
        }

        private void GearVm_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(GearVm.GearSlot))
            {
                SaveGear(lastGearSlot);
                GearVm.ClearStats();
                GearVm.LoadStats(_characterStore.Character.GetSlot(GearVm.GearSlot));
            }
        }

        public void SaveGear(Slot? overwriteSlot = null)
        {
            var gear = GearVm.CreateGear();

            if (overwriteSlot.HasValue)
            {
                gear.GearSlot = overwriteSlot.Value;
            }

            _characterStore.Character.Equip(gear);
        }
    }
}
