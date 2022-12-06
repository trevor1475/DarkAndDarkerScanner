using DarkerScanner.Core;

namespace DarkerScanner.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; }
        }

        public ScanCompareViewModel scanCompareVm { get; set; }
        public EquipViewModel equipVm { get; set; }
        public EquipViewModel settingsVm { get; set; }

        public RelayCommand ScanCompareCommand { get; set; }
        public RelayCommand EquipCommand { get; set; }
        public RelayCommand SettingsCommand { get; set; }

        public MainViewModel()
        {
            scanCompareVm = new ScanCompareViewModel();
            equipVm = new EquipViewModel();
            settingsVm = new EquipViewModel();

            CurrentView = scanCompareVm;

            ScanCompareCommand = new RelayCommand(o => { CurrentView = scanCompareVm; });
            EquipCommand = new RelayCommand(o => { CurrentView = equipVm; });
        }
    }
}
