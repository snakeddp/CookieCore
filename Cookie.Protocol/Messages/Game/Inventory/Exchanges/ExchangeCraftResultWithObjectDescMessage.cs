using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5999)]
    public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
    {
        public ObjectItemNotInContainer ObjectInfo { get; set; }
    }
}