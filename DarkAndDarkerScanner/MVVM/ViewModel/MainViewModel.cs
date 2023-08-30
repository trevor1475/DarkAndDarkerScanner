using DarkAndDarkerScanner.MVVM.Model.Character;
using DarkAndDarkerScanner.MVVM.Stores;
using DarkAndDarkerScanner.Core;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private ObservableObject _currentView;

        public ObservableObject CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public ScanCompareViewModel scanCompareVm { get; set; }
        public EquipViewModel equipVm { get; set; }
        public SettingsViewModel settingsVm { get; set; }

        public RelayCommand ScanCompareCommand { get; set; }
        public RelayCommand EquipCommand { get; set; }
        public RelayCommand SettingsCommand { get; set; }

        public MainViewModel()
        {
            var barb = new Barbarian();
            var _characterStore = new CharacterStore(barb);

            scanCompareVm = new ScanCompareViewModel(_characterStore);
            equipVm = new EquipViewModel(_characterStore);
            settingsVm = new SettingsViewModel(_characterStore);

            CurrentView = scanCompareVm;

            ScanCompareCommand = new RelayCommand(o => { CurrentView = scanCompareVm; });
            EquipCommand = new RelayCommand(o => { CurrentView = equipVm; });
            SettingsCommand = new RelayCommand(o => { CurrentView = settingsVm; });
        }
    }
}
