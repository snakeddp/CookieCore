
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6598)]
    public class ExchangeCrafterJobLevelupMessage
    {
        public sbyte CrafterJobLevel { get; set; }
    }
}
