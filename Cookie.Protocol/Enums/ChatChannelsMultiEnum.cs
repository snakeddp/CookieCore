using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ChatChannelsMultiEnum
    {
        ChannelGlobal = 0,
        ChannelTeam = 1,
        ChannelGuild = 2,
        ChannelAlliance = 3,
        ChannelParty = 4,
        ChannelSales = 5,
        ChannelSeek = 6,
        ChannelNoob = 7,
        ChannelAdmin = 8,
        ChannelAds = 12,
        ChannelArena = 13,
        ChannelCommunity = 14
    }
}
