
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6578)]
    public class ExchangeCraftPaymentModifiedMessage
    {
        [CustomVar]
        public long GoldSum { get; set; }
    }
}
