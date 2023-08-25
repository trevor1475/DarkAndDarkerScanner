using DarkAndDarkerScanner.MVVM.Model.Character;

namespace DarkAndDarkerScanner.MVVM.Stores
{
    public class CharacterStore
    {
        public BaseCharacter Character;

        public CharacterStore(BaseCharacter characterType)
        {
            Character = characterType;
        }
    }
}
