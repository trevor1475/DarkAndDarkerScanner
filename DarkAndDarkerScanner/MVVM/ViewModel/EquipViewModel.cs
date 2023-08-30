using DarkAndDarkerScanner.MVVM.Stores;
using DarkAndDarkerScanner.Core;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class EquipViewModel : ObservableObject
    {
        public RelayCommand ClearStatsCommand { get; }

        public GearViewModel GearVm { get; }

        private CharacterStore _characterStore;

        public EquipViewModel(CharacterStore characterStore)
        {
            _characterStore = characterStore;
            GearVm = new GearViewModel();

            ClearStatsCommand = new RelayCommand(o => { GearVm.ClearStats(); });
        }
    }
}
