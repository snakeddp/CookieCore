using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3029)]
    public class ObjectModifiedMessage
    {
        public ObjectItem Object { get; set; }
    }
}