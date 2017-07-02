using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ObjectErrorEnum
    {
        InventoryFull = 1,
        CannotEquipTwice = 2,
        NotTradable = 3,
        CannotDrop = 4,
        CannotDropNoPlace = 5,
        CannotDestroy = 6,
        LevelTooLow = 7,
        LivingObjectRefusedFood = 8,
        CannotUnequip = 9,
        CannotEquipHere = 10,
        Criterions = 11,
        SymbioticObjectError = 12
    }
}