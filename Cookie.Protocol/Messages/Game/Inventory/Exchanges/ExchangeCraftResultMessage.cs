using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5790)]
    public class ExchangeCraftResultMessage
    {
        public sbyte CraftResult { get; set; }
    }
}