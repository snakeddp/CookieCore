using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum CharacterInventoryPositionEnum
    {
        AccessoryPositionHat = 6,
        AccessoryPositionCape = 7,
        AccessoryPositionBelt = 3,
        AccessoryPositionBoots = 5,
        AccessoryPositionAmulet = 0,
        AccessoryPositionShield = 15,
        AccessoryPositionWeapon = 1,
        AccessoryPositionPets = 8,
        AccessoryPositionRideHarness = 29,
        InventoryPositionRingLeft = 2,
        InventoryPositionRingRight = 4,
        InventoryPositionDofus1 = 9,
        InventoryPositionDofus2 = 10,
        InventoryPositionDofus3 = 11,
        InventoryPositionDofus4 = 12,
        InventoryPositionDofus5 = 13,
        InventoryPositionDofus6 = 14,
        InventoryPositionMount = 16,
        InventoryPositionMutation = 20,
        InventoryPositionBoostFood = 21,
        InventoryPositionFirstBonus = 22,
        InventoryPositionSecondBonus = 23,
        InventoryPositionFirstMalus = 24,
        InventoryPositionSecondMalus = 25,
        InventoryPositionRoleplayBuffer = 26,
        InventoryPositionFollower = 27,
        InventoryPositionCompanion = 28,
        InventoryPositionCostume = 30,
        InventoryPositionNotEquiped = 63
    }
}
