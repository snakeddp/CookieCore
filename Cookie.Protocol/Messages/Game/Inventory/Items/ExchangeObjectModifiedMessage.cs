
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Inventory.Exchanges;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5519)]
    public class ExchangeObjectModifiedMessage : ExchangeObjectMessage
    {
        public ObjectItem Object { get; set; }
    }
}
