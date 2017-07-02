using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6597)]
    public class ExchangeCraftCountRequestMessage
    {
        [CustomVar]
        public int Count { get; set; }
    }
}