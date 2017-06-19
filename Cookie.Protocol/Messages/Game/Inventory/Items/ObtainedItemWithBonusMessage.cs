
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6520)]
    public class ObtainedItemWithBonusMessage : ObtainedItemMessage
    {
        [CustomVar]
        public uint BonusQuantity { get; set; }
    }
}
