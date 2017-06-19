
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3004)]
    public class ObjectErrorMessage
    {
        public byte Reason { get; set; }
    }
}
