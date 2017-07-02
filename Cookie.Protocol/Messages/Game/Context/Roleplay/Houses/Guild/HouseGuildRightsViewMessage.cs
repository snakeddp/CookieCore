using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses.Guild
{
    [NetworkMessage(5700)]
    public class HouseGuildRightsViewMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }

        public uint InstanceId { get; set; }
    }
}