using DarkAndDarkerScanner.MVVM.Model.Character;
using DarkAndDarkerScanner.MVVM.Stores;
using DarkAndDarkerScanner.Core;
using System.Configuration;
using DarkAndDarkerScanner.MVVM.Model;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DarkAndDarkerScanner.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private ObservableObject _currentView;
        private CharacterStore _characterStore;
        private Configuration _settings;
        private Config _config;

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
            _settings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            if (_settings.Sections["Config"] == null)
            {
                _settings.Sections.Add("Config", new Config());
            }
            _config = (Config)_settings.GetSection("Config");

            var characters = DeserializeOrInitialize<Dictionary<string, BaseCharacter>>(_config.SavedCharacters);

            if (characters.Count == 0)
            {
                characters.Add(string.Empty, new Barbarian());
            }

            _characterStore = new CharacterStore(_config.SelectedCharacter ?? string.Empty, characters);

            scanCompareVm = new ScanCompareViewModel(_characterStore);
            equipVm = new EquipViewModel(_characterStore);
            settingsVm = new SettingsViewModel(_characterStore);

            CurrentView = scanCompareVm;

            ScanCompareCommand = new RelayCommand(() => { SwitchView(scanCompareVm); });
            EquipCommand = new RelayCommand(() => { SwitchView(equipVm); });
            SettingsCommand = new RelayCommand(() => { SwitchView(settingsVm); });
        }

        ~MainViewModel()
        {
            _config.SelectedCharacter = _characterStore.SelectedCharacterName;
            _config.SavedCharacters = JsonSerializer.Serialize(_characterStore.Characters);
            _config.SavedTarget = JsonSerializer.Serialize(new Target()); // TODO
            _config.EnabledMetrics = JsonSerializer.Serialize(string.Empty); // TODO

            _settings.Save();
        }

        public T DeserializeOrInitialize<T>(string json)
        {
            if (json == null)
            {
                return Activator.CreateInstance<T>();
            }

            return JsonSerializer.Deserialize<T>(json);
        }

        private void SwitchView(ObservableObject view)
        {
            if (CurrentView == equipVm)
            {
                equipVm.SaveGear();
            }

            CurrentView = view;
        }
    }
}
