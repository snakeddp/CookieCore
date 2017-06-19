
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses.Guild
{
    [NetworkMessage(5704)]
    public class HouseGuildShareRequestMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }
        public uint InstanceId { get; set; }
        [RegularBool]
        public bool Enable { get; set; }
        [CustomVar]
        public uint Rights { get; set; }
    }
}
