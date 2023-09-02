using DarkAndDarkerScanner.MVVM.Model.Character;
using System.Configuration;

namespace DarkAndDarkerScanner.MVVM.Model
{
    public class Config : ConfigurationSection
    {
        public string SelectedCharacter { get; set; }
        public string SavedTarget { get; set; }
        public string EnabledMetrics { get; set; }
        public string SavedCharacters { get; set; }

        public Config()
        {

        }
    }
}
