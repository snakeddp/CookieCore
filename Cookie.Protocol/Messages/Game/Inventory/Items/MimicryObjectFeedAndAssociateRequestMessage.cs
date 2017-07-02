using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6460)]
    public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
    {
        [CustomVar]
        public uint FoodUID { get; set; }

        public sbyte FoodPos { get; set; }

        [RegularBool]
        public bool Preview { get; set; }
    }
}