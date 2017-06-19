using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ExchangeTypeEnum
    {
        NpcShop = 0,
        PlayerTrade = 1,
        NpcTrade = 2,
        Craft = 3,
        DisconnectedVendor = 4,
        Storage = 5,
        ShopStock = 6,
        Taxcollector = 8,
        NpcModifyTrade = 9,
        BidhouseSell = 10,
        BidhouseBuy = 11,
        MulticraftCrafter = 12,
        MulticraftCustomer = 13,
        JobIndex = 14,
        Mount = 15,
        MountStable = 16,
        NpcResurectPet = 17,
        NpcTradeRide = 18,
        RealestateHouse = 19,
        RealestateFarm = 20,
        RunesTrade = 21,
        RecycleTrade = 22,
        Bank = 23,
        Trashbin = 24,
        AlliancePrism = 25,
        Havenbag = 26,
        NpcTradeMuldo = 27
    }
}
