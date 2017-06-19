
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6030)]
    public class GoldAddedMessage
    {
        public GoldItem Gold { get; set; }
    }
}
