using System.Collections.Generic;

namespace DarkAndDarkerScanner
{
    internal class Config
    {
        public string SelectedClass { get; set; }
        public Dictionary<string, bool> Skills { get; set; }
        public Dictionary<string, bool> Perks { get; set; }
        public Gear[] EquippedGear { get; set; }
    }
}
