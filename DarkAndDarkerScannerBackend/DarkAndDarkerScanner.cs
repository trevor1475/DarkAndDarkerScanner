using DarkAndDarkerScannerBackend.Character;
using Newtonsoft.Json;

namespace DarkAndDarkerScannerBackend
{
    class DarkAndDarkerScanner
    {
        Character.Character _character;

        public void main(string[] args)
        {
            Config config = GetConfig();



            var wiz = new Wizard();

            wiz.Equip(new Gear() { Name = "Badger Necklace", Will = 3 });

            //wiz.Compare(new Gear() { Name = "Badger Necklace", Will = 4 });
        }

        public Config GetConfig()
        {
            using (StreamReader configFile = new StreamReader("Config.json"))
            using (var jsonTextReader = new JsonTextReader(configFile))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<Config>(jsonTextReader) ?? new Config();
            }
        }

        public void SaveConfig()
        {
            var config = GetConfig();

            using (StreamWriter configFile = new StreamWriter("Config.json"))
            using (var jsonWriter = new JsonTextWriter(configFile))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(jsonWriter, config);
                jsonWriter.Flush();
            }
        }
    }
}