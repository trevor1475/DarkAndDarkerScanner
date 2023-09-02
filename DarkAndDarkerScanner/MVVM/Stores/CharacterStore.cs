using DarkAndDarkerScanner.MVVM.Model.Character;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Stores
{
    public class CharacterStore
    {

        private string _selectedCharacterName;
        public string SelectedCharacterName
        {
            get { return _selectedCharacterName; }
            set
            {
                _selectedCharacterName = value;
                Character = Characters[value];
            }
        }

        public Dictionary<string, BaseCharacter> Characters
        {
            get;
            private set;
        }

        public BaseCharacter Character
        {
            get;
            private set;
        }

        public CharacterStore(string selectedCharacterName, Dictionary<string, BaseCharacter> characters)
        {
            Characters = characters; 
            SelectedCharacterName = selectedCharacterName;
        }

        public void NameCharacter(string characterName)
        {
            Characters.Remove(_selectedCharacterName);
            Characters.Add(characterName, Character);

            SelectedCharacterName = characterName;
        }
    }
}
