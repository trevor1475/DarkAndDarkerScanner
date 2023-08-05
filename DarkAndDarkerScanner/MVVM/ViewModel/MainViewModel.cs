using DarkAndDarkerScanner.MVVM.Model;
using DarkAndDarkerScannerBackend.Core;

namespace DarkAndDarkerScannerBackend.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private ObservableObject _currentView;
        private readonly DataStore _dataStore;

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
            _dataStore = new DataStore();

            scanCompareVm = new ScanCompareViewModel(_dataStore);
            equipVm = new EquipViewModel(_dataStore);
            settingsVm = new SettingsViewModel(_dataStore);

            CurrentView = scanCompareVm;

            ScanCompareCommand = new RelayCommand(o => { CurrentView = scanCompareVm; });
            EquipCommand = new RelayCommand(o => { CurrentView = equipVm; });
            SettingsCommand = new RelayCommand(o => { CurrentView = settingsVm; });
        }
    }
}
