
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Mount;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6179)]
    public class UpdateMountBoostMessage
    {
        [CustomVar]
        public int RideId { get; set; }
    }
}
