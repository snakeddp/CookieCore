using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6014)]
    public class ObjectJobAddedMessage
    {
        public sbyte JobId { get; set; }
    }
}