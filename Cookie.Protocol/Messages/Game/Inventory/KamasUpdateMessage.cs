
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory
{
    [NetworkMessage(5537)]
    public class KamasUpdateMessage
    {
        [CustomVar]
        public long KamasTotal { get; set; }
    }
}
