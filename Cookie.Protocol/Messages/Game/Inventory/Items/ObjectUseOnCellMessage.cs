using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3013)]
    public class ObjectUseOnCellMessage : ObjectUseMessage
    {
        [CustomVar]
        public ushort Cells { get; set; }
    }
}