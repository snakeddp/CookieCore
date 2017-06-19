
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3003)]
    public class ObjectUseOnCharacterMessage : ObjectUseMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }
    }
}
