using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5513)]
    public class ExchangeErrorMessage
    {
        public byte ErrorType { get; set; }
    }
}