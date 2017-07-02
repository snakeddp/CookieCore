using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5509)]
    public class ExchangeIsReadyMessage
    {
        public double Id { get; set; }

        [RegularBool]
        public bool Ready { get; set; }
    }
}