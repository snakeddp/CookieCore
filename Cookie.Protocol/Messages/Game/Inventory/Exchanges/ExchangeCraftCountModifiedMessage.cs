using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6595)]
    public class ExchangeCraftCountModifiedMessage
    {
        [CustomVar]
        public int Count { get; set; }
    }
}