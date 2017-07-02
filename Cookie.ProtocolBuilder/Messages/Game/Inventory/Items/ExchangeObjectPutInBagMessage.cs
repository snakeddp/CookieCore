using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6009)]
    public class ExchangeObjectPutInBagMessage : ExchangeObjectMessage
    {
        public ObjectItem Object { get; set; }
    }
}