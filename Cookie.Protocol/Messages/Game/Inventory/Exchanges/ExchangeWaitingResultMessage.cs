
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5786)]
    public class ExchangeWaitingResultMessage
    {
        [RegularBool]
        public bool Bwait { get; set; }
    }
}
