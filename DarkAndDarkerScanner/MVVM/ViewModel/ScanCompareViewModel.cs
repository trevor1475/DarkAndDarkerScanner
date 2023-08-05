using DarkAndDarkerScanner;
using DarkAndDarkerScanner.Character;
using DarkAndDarkerScanner.MVVM.Model;
using DarkAndDarkerScannerBackend.Core;
using System;

namespace DarkAndDarkerScannerBackend.MVVM.ViewModel
{
    public class ScanCompareViewModel : ObservableObject
    {
        //scan stat section w/ manual entry
        //manual scan button
        //equip comparison
        //equip button

        public ScanCompareViewModel(DataStore _dataStore)
        {
            
        }

        public double RecalculateDmg(BaseCharacter character, Gear newGear)
        {
            if (!character.CanEquip(newGear.Name))
                return -999; // TODO: popup error

            character.Equip(newGear);
            return character.CalculateDamage();
        }

        public double RecalculateActionSpeed(BaseCharacter character, Gear newGear)
        {
            if (!character.CanEquip(newGear.Name))
                return -999; // TODO: popup error

            character.Equip(newGear);
            return character.CalculateDamage();
        }

        public double RecalculateCastSpeed(BaseCharacter character, Gear newGear)
        {
            if (!character.CanEquip(newGear.Name))
                return -999; // TODO: popup error

            character.Equip(newGear);
            return character.CalculateDamage();
        }

        public double RecalculateMoveSpeed(BaseCharacter character, Gear newGear)
        {
            if (!character.CanEquip(newGear.Name))
                return -999; // TODO: popup error

            character.Equip(newGear);
            return character.CalculateDamage();
        }

        public double RecalculateDps(BaseCharacter character, Gear newGear)
        {
            if (!character.CanEquip(newGear.Name))
                return -999; // TODO: popup error

            character.Equip(newGear);
            // TODO: class based speed
            return RecalculateDmg(character, newGear) * Math.Max(RecalculateActionSpeed(character, newGear), RecalculateCastSpeed(character, newGear));
        }
    }
}
