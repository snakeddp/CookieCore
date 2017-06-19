using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GuildRightsBitEnum
    {
        GuildRightNone = 0,
        GuildRightBoss = 1,
        GuildRightManageGuildBoosts = 2,
        GuildRightManageRights = 4,
        GuildRightInviteNewMembers = 8,
        GuildRightBanMembers = 16,
        GuildRightManageXpContribution = 32,
        GuildRightManageRanks = 64,
        GuildRightHireTaxCollector = 128,
        GuildRightManageMyXpContribution = 256,
        GuildRightCollect = 512,
        GuildRightUsePaddocks = 4096,
        GuildRightOrganizePaddocks = 8192,
        GuildRightTakeOthersMountsInPaddocks = 16384,
        GuildRightDefensePriority = 32768,
        GuildRightCollectMyTaxCollector = 65536,
        GuildRightSetAlliancePrism = 131072,
        GuildRightTalkInAllianceChan = 262144
    }
}
