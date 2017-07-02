using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6701)]
    public class FocusedExchangeReadyMessage : ExchangeReadyMessage
    {
        [CustomVar]
        public uint FocusActionId { get; set; }
    }
}