using DarkAndDarkerScanner.MVVM.Model.Character;
using System;
using System.Collections.Generic;

namespace DarkAndDarkerScanner.MVVM.Model
{
    public class GearType
    {
        public enum Slot
        {
            OneHandWeapon,
            TwoHandWeapon,
            Shield,
            OffhandWeapon,
            Helmet,
            Chest,
            Legs,
            Gloves,
            Boots,
            Necklace,
            Ring
        }

        public Slot GearSlot { get; set; }

        public List<Type> EquippableBy { get; set; }

        public GearType(Slot gearSlot, Type[] gearEquippableBy)
        {
            GearSlot = gearSlot;
            EquippableBy = new List<Type>(gearEquippableBy);
        }

        public GearType(Slot gearSlot, List<Type> gearEquippableBy)
        {
            GearSlot = gearSlot;
            EquippableBy = gearEquippableBy;
        }

        public static Dictionary<string, GearType> StaticData = new Dictionary<string, GearType>()
        {
            // 2H Weapons
            {"Bardiche",               new GearType(Slot.TwoHandWeapon, new[] {typeof(Barbarian)})},
            {"Battle Axe",             new GearType(Slot.TwoHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},
            {"Double Axe",             new GearType(Slot.TwoHandWeapon, new[] {typeof(Barbarian)})},
            {"Felling Axe",            new GearType(Slot.TwoHandWeapon, new[] {typeof(Barbarian)})},
            {"Halberd",                new GearType(Slot.TwoHandWeapon, new[] {typeof(Fighter)})},
            {"Longsword",              new GearType(Slot.TwoHandWeapon, new[] {typeof(Fighter)})},
            {"Spear",                  new GearType(Slot.TwoHandWeapon, new[] {typeof(Fighter)})},
            {"WarMaul",                new GearType(Slot.TwoHandWeapon, new[] {typeof(Barbarian), typeof(Cleric)})},
            {"Wizard Staff",           new GearType(Slot.TwoHandWeapon, new[] {typeof(Wizard), typeof(Cleric)})},
            {"Zweihander",             new GearType(Slot.TwoHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},

            // 1H Weapons
            {"Arming Sword",           new GearType(Slot.OneHandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},
            {"Crystal Sword",          new GearType(Slot.OneHandWeapon, new[] {typeof(Wizard)})},
            {"Falchion",               new GearType(Slot.OneHandWeapon, new[] {typeof(Fighter)})},
            {"Flanged Mace",           new GearType(Slot.OneHandWeapon, new[] {typeof(Barbarian)})},
            {"Hatchet",                new GearType(Slot.OneHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},
            {"Horsemans Axe",          new GearType(Slot.OneHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},
            {"Morning Star",           new GearType(Slot.OneHandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Rapier",                 new GearType(Slot.OneHandWeapon, new[] {typeof(Ranger), typeof(Rogue)})},
            {"Rondel Dagger",          new GearType(Slot.OneHandWeapon, new[] {typeof(Rogue), typeof(Wizard)})},

            // Ranged
            {"Crossbow",               new GearType(Slot.TwoHandWeapon, new[] {typeof(Fighter), typeof(Ranger), typeof(Wizard)})},
            {"Longbow",                new GearType(Slot.TwoHandWeapon, new[] {typeof(Ranger)})},
            {"Recurve Bow",            new GearType(Slot.TwoHandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},
            {"Survival Bow",           new GearType(Slot.TwoHandWeapon, new[] {typeof(Ranger)})},
            {"Windlass Crossbow",      new GearType(Slot.TwoHandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},

            // Offhands
            {"Buckler",                new GearType(Slot.OffhandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Heater Shield",          new GearType(Slot.OffhandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Pavise",                 new GearType(Slot.OffhandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},
            {"Round Shield",           new GearType(Slot.OffhandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Castillion Dagger",      new GearType(Slot.OffhandWeapon, new[] {typeof(Fighter), typeof(Rogue)})},

            //Helmet
            {"Armet",                  new GearType(Slot.Helmet, new[] {typeof(Fighter)})},
            {"Chaperon",               new GearType(Slot.Helmet, new[] {typeof(Cleric)})},
            {"Gjermundbu",             new GearType(Slot.Helmet, new[] {typeof(Barbarian)})},
            {"Kettle Hat",             new GearType(Slot.Helmet, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Leather Cap",            new GearType(Slot.Helmet, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Ranger Hood",            new GearType(Slot.Helmet, new[] {typeof(Ranger)})},
            {"Rogue Cowl",             new GearType(Slot.Helmet, new[] {typeof(Rogue)})},
            {"Visored Barbuta Helm",   new GearType(Slot.Helmet, new[] {typeof(Fighter)})},
            {"Wizard Hat",             new GearType(Slot.Helmet, new[] {typeof(Wizard)})},

            // Chest
            {"Dark Plate Armor",       new GearType(Slot.Chest, new[] {typeof(Fighter)})},
            {"Doublet",                new GearType(Slot.Chest, new[] {typeof(Fighter), typeof(Ranger), typeof(Rogue)})},
            {"Fine Cuirass",           new GearType(Slot.Chest, new[] {typeof(Fighter)})},
            {"Frock",                  new GearType(Slot.Chest, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Marauder Outfit",        new GearType(Slot.Chest, new[] {typeof(Rogue)})},
            {"Mystic Vestments",       new GearType(Slot.Chest, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Northern Full Tunic",    new GearType(Slot.Chest, new[] {typeof(Barbarian)})},
            {"Oracle Robe",            new GearType(Slot.Chest, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Padded Tunic",           new GearType(Slot.Chest, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Regal Gambeson",         new GearType(Slot.Chest, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Templar Armor",          new GearType(Slot.Chest, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Warden Outfit",          new GearType(Slot.Chest, new[] {typeof(Ranger)})},

            // Legs
            {"Cloth Pants",            new GearType(Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Heavy Leather Leggings", new GearType(Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Leather Leggings",       new GearType(Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Loose Trousers",         new GearType(Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Padded Leggings",        new GearType(Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Plate Pants",            new GearType(Slot.Legs, new[] {typeof(Cleric), typeof(Fighter)})},

            // Gloves
            {"Heavy Guantlet",         new GearType(Slot.Gloves, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Leather Gloves",         new GearType(Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Rawhide Gloves",         new GearType(Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Reinforced Gloves",      new GearType(Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Riveted Gloves",         new GearType(Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},

            // Boots
            {"Adventurer Boots",       new GearType(Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Heavy Boots",            new GearType(Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Laced Turn Shoes",       new GearType(Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Lightfoot Boots",        new GearType(Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Old Shoes",              new GearType(Slot.Boots, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Plate Boots",            new GearType(Slot.Boots, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Rugged Boots",           new GearType(Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Wizard Shoes",           new GearType(Slot.Boots, new[] {typeof(Wizard)})},

            // Necklaces
            {"Ox Pendant",             new GearType(Slot.Necklace, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Fox Pendant",            new GearType(Slot.Necklace, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Badger Pendant",         new GearType(Slot.Necklace, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Necklace of Peace",      new GearType(Slot.Necklace, new[] {typeof(Cleric), typeof(Wizard)})},
            // TODO: Add when togglable {"Rat Pendant",        new (Slot.Necklace, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},

            // Rings
            {"Ring of Courage",        new GearType(Slot.Ring, new[] {typeof(Barbarian), typeof(Fighter), typeof(Ranger), typeof(Rogue)})},
            {"Ring of Quickness",      new GearType(Slot.Ring, new[] {typeof(Barbarian), typeof(Fighter), typeof(Ranger), typeof(Rogue)})},
            {"Ring of Resolve",        new GearType(Slot.Ring, new[] {typeof(Cleric), typeof(Wizard)})},
            // TODO: whats the name of knowledge ring
            {"Ring of Knowledge",      new GearType(Slot.Ring, new[] {typeof(Cleric), typeof(Wizard)})},
            // TODO: Add when togglable {"Ring of Survival",        new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)}},
        };
    }
}
