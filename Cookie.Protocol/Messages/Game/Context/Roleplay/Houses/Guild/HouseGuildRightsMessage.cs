using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses.Guild
{
    [NetworkMessage(5703)]
    public class HouseGuildRightsMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }

        public uint InstanceId { get; set; }

        [RegularBool]
        public bool SecondHand { get; set; }

        public GuildInformations GuildInfo { get; set; }

        [CustomVar]
        public uint Rights { get; set; }
    }
}