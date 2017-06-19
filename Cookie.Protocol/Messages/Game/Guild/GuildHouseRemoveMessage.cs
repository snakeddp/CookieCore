
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6180)]
    public class GuildHouseRemoveMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }
        public uint InstanceId { get; set; }
        [RegularBool]
        public bool SecondHand { get; set; }
    }
}
