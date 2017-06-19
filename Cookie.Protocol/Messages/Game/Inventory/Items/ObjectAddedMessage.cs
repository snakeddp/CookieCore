
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3025)]
    public class ObjectAddedMessage
    {
        public ObjectItem Object { get; set; }
    }
}
