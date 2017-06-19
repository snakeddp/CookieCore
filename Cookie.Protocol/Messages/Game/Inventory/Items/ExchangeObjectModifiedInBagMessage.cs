
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Inventory.Exchanges;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6008)]
    public class ExchangeObjectModifiedInBagMessage : ExchangeObjectMessage
    {
        public ObjectItem Object { get; set; }
    }
}
