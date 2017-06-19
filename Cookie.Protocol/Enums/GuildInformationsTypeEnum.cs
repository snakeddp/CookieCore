using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GuildInformationsTypeEnum
    {
        InfoGeneral = 1,
        InfoMembers = 2,
        InfoBoosts = 3,
        InfoPaddocks = 4,
        InfoHouses = 5,
        InfoTaxCollectorGuildOnly = 6,
        InfoTaxCollectorAlliance = 7,
        InfoTaxCollectorLeave = 8
    }
}
