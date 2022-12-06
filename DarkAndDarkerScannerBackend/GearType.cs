using DarkerScanner.Character;

namespace DarkerScanner
{
    public static class GearType
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

        public static Dictionary<string, Tuple<Slot, Type[]>> Type = new Dictionary<string, Tuple<Slot, Type[]>>()
        {
            // 2H Weapons
            {"Bardiche",               new (Slot.TwoHandWeapon, new[] {typeof(Barbarian)})},
            {"Battle Axe",             new (Slot.TwoHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},
            {"Double Axe",             new (Slot.TwoHandWeapon, new[] {typeof(Barbarian)})},
            {"Felling Axe",            new (Slot.TwoHandWeapon, new[] {typeof(Barbarian)})},
            {"Halberd",                new (Slot.TwoHandWeapon, new[] {typeof(Fighter)})},
            {"Longsword",              new (Slot.TwoHandWeapon, new[] {typeof(Fighter)})},
            {"Spear",                  new (Slot.TwoHandWeapon, new[] {typeof(Fighter)})},
            {"WarMaul",                new (Slot.TwoHandWeapon, new[] {typeof(Barbarian), typeof(Cleric)})},
            {"Wizard Staff",           new (Slot.TwoHandWeapon, new[] {typeof(Wizard), typeof(Cleric)})},
            {"Zweihander",             new (Slot.TwoHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},

            // 1H Weapons
            {"Arming Sword",           new (Slot.OneHandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},
            {"Crystal Sword",          new (Slot.OneHandWeapon, new[] {typeof(Wizard)})},
            {"Falchion",               new (Slot.OneHandWeapon, new[] {typeof(Fighter)})},
            {"Flanged Mace",           new (Slot.OneHandWeapon, new[] {typeof(Barbarian)})},
            {"Hatchet",                new (Slot.OneHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},
            {"Horsemans Axe",          new (Slot.OneHandWeapon, new[] {typeof(Barbarian), typeof(Fighter)})},
            {"Morning Star",           new (Slot.OneHandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Rapier",                 new (Slot.OneHandWeapon, new[] {typeof(Ranger), typeof(Rogue)})},
            {"Rondel Dagger",          new (Slot.OneHandWeapon, new[] {typeof(Rogue), typeof(Wizard)})},

            // Ranged
            {"Crossbow",               new (Slot.TwoHandWeapon, new[] {typeof(Fighter), typeof(Ranger), typeof(Wizard)})},
            {"Longbow",                new (Slot.TwoHandWeapon, new[] {typeof(Ranger)})},
            {"Recurve Bow",            new (Slot.TwoHandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},
            {"Survival Bow",           new (Slot.TwoHandWeapon, new[] {typeof(Ranger)})},
            {"Windlass Crossbow",      new (Slot.TwoHandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},

            // Offhands
            {"Buckler",                new (Slot.OffhandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Heater Shield",          new (Slot.OffhandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Pavise",                 new (Slot.OffhandWeapon, new[] {typeof(Fighter), typeof(Ranger)})},
            {"Round Shield",           new (Slot.OffhandWeapon, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Castillion Dagger",      new (Slot.OffhandWeapon, new[] {typeof(Fighter), typeof(Rogue)})},

            //Helmet
            {"Armet",                  new (Slot.Helmet, new[] {typeof(Fighter)})},
            {"Chaperon",               new (Slot.Helmet, new[] {typeof(Cleric)})},
            {"Gjermundbu",             new (Slot.Helmet, new[] {typeof(Barbarian)})},
            {"Kettle Hat",             new (Slot.Helmet, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Leather Cap",            new (Slot.Helmet, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Ranger Hood",            new (Slot.Helmet, new[] {typeof(Ranger)})},
            {"Rogue Cowl",             new (Slot.Helmet, new[] {typeof(Rogue)})},
            {"Visored Barbuta Helm",   new (Slot.Helmet, new[] {typeof(Fighter)})},
            {"Wizard Hat",             new (Slot.Helmet, new[] {typeof(Wizard)})},

            // Chest
            {"Dark Plate Armor",       new (Slot.Chest, new[] {typeof(Fighter)})},
            {"Doublet",                new (Slot.Chest, new[] {typeof(Fighter), typeof(Ranger), typeof(Rogue)})},
            {"Fine Cuirass",           new (Slot.Chest, new[] {typeof(Fighter)})},
            {"Frock",                  new (Slot.Chest, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Marauder Outfit",        new (Slot.Chest, new[] {typeof(Rogue)})},
            {"Mystic Vestments",       new (Slot.Chest, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Northern Full Tunic",    new (Slot.Chest, new[] {typeof(Barbarian)})},
            {"Oracle Robe",            new (Slot.Chest, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Padded Tunic",           new (Slot.Chest, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Regal Gambeson",         new (Slot.Chest, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Templar Armor",          new (Slot.Chest, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Warden Outfit",          new (Slot.Chest, new[] {typeof(Ranger)})},

            // Legs
            {"Cloth Pants",            new (Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Heavy Leather Leggings", new (Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Leather Leggings",       new (Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Loose Trousers",         new (Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Padded Leggings",        new (Slot.Legs, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Plate Pants",            new (Slot.Legs, new[] {typeof(Cleric), typeof(Fighter)})},

            // Gloves
            {"Heavy Guantlet",         new (Slot.Gloves, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Leather Gloves",         new (Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Rawhide Gloves",         new (Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Reinforced Gloves",      new (Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Riveted Gloves",         new (Slot.Gloves, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},

            // Boots
            {"Adventurer Boots",       new (Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Heavy Boots",            new (Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Laced Turn Shoes",       new (Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Lightfoot Boots",        new (Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Old Shoes",              new (Slot.Boots, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Plate Boots",            new (Slot.Boots, new[] {typeof(Cleric), typeof(Fighter)})},
            {"Rugged Boots",           new (Slot.Boots, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Wizard Shoes",           new (Slot.Boots, new[] {typeof(Wizard)})},

            // Necklaces
            {"Ox Pendant",             new (Slot.Necklace, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Fox Pendant",            new (Slot.Necklace, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},
            {"Badger Pendant",         new (Slot.Necklace, new[] {typeof(Cleric), typeof(Wizard)})},
            {"Necklace of Peace",      new (Slot.Necklace, new[] {typeof(Cleric), typeof(Wizard)})},
            // TODO: Add when togglable {"Rat Pendant",        new (Slot.Necklace, new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)})},

            // Rings
            {"Ring of Courage",        new (Slot.Ring, new[] {typeof(Barbarian), typeof(Fighter), typeof(Ranger), typeof(Rogue)})},
            {"Ring of Quickness",      new (Slot.Ring, new[] {typeof(Barbarian), typeof(Fighter), typeof(Ranger), typeof(Rogue)})},
            {"Ring of Resolve",        new (Slot.Ring, new[] {typeof(Cleric), typeof(Wizard)})},
            // TODO: whats the name of knowledge ring
            {"Ring of Knowledge",      new (Slot.Ring, new[] {typeof(Cleric), typeof(Wizard)})},
            // TODO: Add when togglable {"Ring of Survival",        new[] {typeof(Barbarian), typeof(Cleric), typeof(Fighter), typeof(Ranger), typeof(Rogue), typeof(Wizard)}},
        };
    }
}
