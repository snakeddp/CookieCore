
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5661)]
    public class HouseKickIndoorMerchantRequestMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}
